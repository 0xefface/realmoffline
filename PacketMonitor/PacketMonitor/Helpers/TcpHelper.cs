using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.Net;
using System.Net.NetworkInformation;
using System.Drawing;
using System.Diagnostics;

namespace PacketMonitor.Helpers
{
#region Managed IP Helper API
    public class TcpHelper
    {
        /// <summary>
        /// Prints out all tcpconnections and the state of the connection
        /// as well as the process using it.
        /// </summary>
        /// <returns>a string with all the info</returns>
        public static string PrintOutTcpConnections()
        {
            StringBuilder result = new StringBuilder();
            try
            {
                foreach (TcpRow tcpRow in ManagedIpHelper.GetExtendedTcpTable(true))
                {
                    result.AppendLine(string.Format("  {0,-7}{1,-23}{2, -23}{3,-14}{4}", "TCP", tcpRow.LocalEndPoint, tcpRow.RemoteEndPoint, tcpRow.State, Process.GetProcessById(tcpRow.ProcessId).ProcessName));
                }
            }
            catch (Exception ex) { mainForm.WriteLine(ex.Message, Color.Red); }
            return result.ToString();
        }
        public static Process GetProcessCommunicatingWithRemoteIP(IPAddress address)
        {
            Process result = null;
            try
            {
                foreach (TcpRow tcpRow in ManagedIpHelper.GetExtendedTcpTable(true))
                {
                    //mainForm.WriteLine(string.Format("Comparing {0} to {1}", tcpRow.RemoteEndPoint.ToString(), address.ToString()));
                    string compare = tcpRow.RemoteEndPoint.Address.ToString();
                    if (compare.Contains(address.ToString())) { result = Process.GetProcessById(tcpRow.ProcessId); }
                }
            }
            catch (Exception ex) { mainForm.WriteLine(ex.Message, Color.Red); }
            return result;
        }
        /// <summary>
        /// Gets a process that is listening on port
        /// </summary>
        /// <param name="port">the port to check </param>
        /// <returns>the process listening on this port, if none returns null</returns>
        public static Process GetProcessByPortInUse(int port)
        {
            Process result = null;
            int tryPort = 0;
            try
            {
                foreach (TcpRow tcpRow in ManagedIpHelper.GetExtendedTcpTable(true))
                {
                    string parse = string.Format("{0,-7}", tcpRow.LocalEndPoint).Split(':').Last().Trim();
                    if (int.TryParse(parse, out tryPort))
                    {
                        if(tryPort == port)
                        result = Process.GetProcessById(tcpRow.ProcessId);
                    }
                }
            }
            catch (Exception ex) { mainForm.WriteLine(ex.Message, Color.Red); }
            return result;
        }
        /// <summary>
        /// Returns a port in use by a process
        /// </summary>
        /// <param name="process">The process you want to check</param>
        /// <returns>the port this process is using, if the process
        /// does not use a port it returns 0</returns>
        public static int FindPortInUseByProcess(Process process)
        {
            int result = 0;
            try
            {
                foreach (TcpRow tcpRow in ManagedIpHelper.GetExtendedTcpTable(true))
                {
                    if (tcpRow.ProcessId == process.Id)
                    {
                        // the port is everything after : IE: 0.0.0.0:2869 
                        string parse = string.Format("{0,-7}", tcpRow.LocalEndPoint).Split(':').Last();
                        int.TryParse(parse.Trim(), out result);
                    }
                }
            }
            catch (Exception ex) { mainForm.WriteLine(ex.Message, Color.Red); }
            return result;
        }
        public static byte[] Read(IntPtr handle, IntPtr address, UInt32 size, ref UInt32 bytes)
        {
            byte[] buffer = new byte[size];
            ReadProcessMemory(handle, address, buffer, size, ref bytes);
            return buffer;
        }
        [DllImport("Kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, UInt32 nSize, ref UInt32 lpNumberOfBytesRead);
    }
public class TcpTable : IEnumerable<TcpRow>
{
    #region Private Fields

    private IEnumerable<TcpRow> tcpRows;

    #endregion

    #region Constructors

    public TcpTable(IEnumerable<TcpRow> tcpRows)
    {
        this.tcpRows = tcpRows;
    }

    #endregion

    #region Public Properties

    public IEnumerable<TcpRow> Rows
    {
        get { return this.tcpRows; }
    }

    #endregion

    #region IEnumerable<TcpRow> Members

    public IEnumerator<TcpRow> GetEnumerator()
    {
        return this.tcpRows.GetEnumerator();
    }

    #endregion

    #region IEnumerable Members

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.tcpRows.GetEnumerator();
    }

    #endregion
}

public class TcpRow
{
    #region Private Fields

    private IPEndPoint localEndPoint;
    private IPEndPoint remoteEndPoint;
    private TcpState state;
    private int processId;

    #endregion

    #region Constructors

    public TcpRow(IpHelper.TcpRow tcpRow)
    {
        this.state = tcpRow.state;
        this.processId = tcpRow.owningPid;

        int localPort = (tcpRow.localPort1 << 8) + (tcpRow.localPort2) + (tcpRow.localPort3 << 24) + (tcpRow.localPort4 << 16);
        long localAddress = tcpRow.localAddr;
        this.localEndPoint = new IPEndPoint(localAddress, localPort);

        int remotePort = (tcpRow.remotePort1 << 8) + (tcpRow.remotePort2) + (tcpRow.remotePort3 << 24) + (tcpRow.remotePort4 << 16);
        long remoteAddress = tcpRow.remoteAddr;
        this.remoteEndPoint = new IPEndPoint(remoteAddress, remotePort);
    }

    #endregion

    #region Public Properties

    public IPEndPoint LocalEndPoint
    {
        get { return this.localEndPoint; }
    }

    public IPEndPoint RemoteEndPoint
    {
        get { return this.remoteEndPoint; }
    }

    public TcpState State
    {
        get { return this.state; }
    }

    public int ProcessId
    {
        get { return this.processId; }
    }

    #endregion
}

public static class ManagedIpHelper
{
    #region Public Methods

    public static TcpTable GetExtendedTcpTable(bool sorted)
    {
        List<TcpRow> tcpRows = new List<TcpRow>();

        IntPtr tcpTable = IntPtr.Zero;
        int tcpTableLength = 0;

        if (IpHelper.GetExtendedTcpTable(tcpTable, ref tcpTableLength, sorted, IpHelper.AfInet, IpHelper.TcpTableType.OwnerPidAll, 0) != 0)
        {
            try
            {
                tcpTable = Marshal.AllocHGlobal(tcpTableLength);
                if (IpHelper.GetExtendedTcpTable(tcpTable, ref tcpTableLength, true, IpHelper.AfInet, IpHelper.TcpTableType.OwnerPidAll, 0) == 0)
                {
                    IpHelper.TcpTable table = (IpHelper.TcpTable)Marshal.PtrToStructure(tcpTable, typeof(IpHelper.TcpTable));

                    IntPtr rowPtr = (IntPtr)((long)tcpTable + Marshal.SizeOf(table.length));
                    for (int i = 0; i < table.length; ++i)
                    {
                        tcpRows.Add(new TcpRow((IpHelper.TcpRow)Marshal.PtrToStructure(rowPtr, typeof(IpHelper.TcpRow))));
                        rowPtr = (IntPtr)((long)rowPtr + Marshal.SizeOf(typeof(IpHelper.TcpRow)));
                    }
                }
            }
            finally
            {
                if (tcpTable != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(tcpTable);
                }
            }
        }

        return new TcpTable(tcpRows);
    }

    #endregion
}

#endregion

#region P/Invoke IP Helper API

/// <summary>
/// <see cref="http://msdn2.microsoft.com/en-us/library/aa366073.aspx"/>
/// </summary>
public static class IpHelper
{
    #region Public Fields

    public const string DllName = "iphlpapi.dll";
    public const int AfInet = 2;

    #endregion

    #region Public Methods

    /// <summary>
    /// <see cref="http://msdn2.microsoft.com/en-us/library/aa365928.aspx"/>
    /// </summary>
    [DllImport(IpHelper.DllName, SetLastError = true)]
    public static extern uint GetExtendedTcpTable(IntPtr tcpTable, ref int tcpTableLength, bool sort, int ipVersion, TcpTableType tcpTableType, int reserved);

    #endregion

    #region Public Enums

    /// <summary>
    /// <see cref="http://msdn2.microsoft.com/en-us/library/aa366386.aspx"/>
    /// </summary>
    public enum TcpTableType
    {
        BasicListener,
        BasicConnections,
        BasicAll,
        OwnerPidListener,
        OwnerPidConnections,
        OwnerPidAll,
        OwnerModuleListener,
        OwnerModuleConnections,
        OwnerModuleAll,
    }

    #endregion

    #region Public Structs

    /// <summary>
    /// <see cref="http://msdn2.microsoft.com/en-us/library/aa366921.aspx"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct TcpTable
    {
        public uint length;
        public TcpRow row;
    }

    /// <summary>
    /// <see cref="http://msdn2.microsoft.com/en-us/library/aa366913.aspx"/>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct TcpRow
    {
        public TcpState state;
        public uint localAddr;
        public byte localPort1;
        public byte localPort2;
        public byte localPort3;
        public byte localPort4;
        public uint remoteAddr;
        public byte remotePort1;
        public byte remotePort2;
        public byte remotePort3;
        public byte remotePort4;
        public int owningPid;
    }

    #endregion
}

#endregion
}
