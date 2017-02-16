using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpPcap;
using PacketDotNet;
using PacketMonitor.Helpers;
using System.Diagnostics;
using System.Net;
using System.Drawing.Text;

namespace PacketMonitor
{
    public partial class mainForm : Form
    {
        #region Properties and Fields
        private static mainForm This { get; set; }
        private ICaptureDevice Device { get; set; }
        private Process ProcessUsingIP { get; set; }
        private bool IsMonitoringIpAddresses { get; set; }
        #endregion
        #region Constructors
        public mainForm()
        {
            This = this;
            IsMonitoringIpAddresses = false;
            InitializeComponent();
            this.listViewDevices.DoubleClick += new EventHandler(listViewDevices_DoubleClick);
            this.FormClosing += new FormClosingEventHandler(mainForm_FormClosing);
        }
        #endregion
        #region Form Load
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Before we display this form to user, we need to gather some info
            try
            {
                this.listViewDevices.Items.AddRange(Globals.GetDevices(this.listViewDevices));
            }
            catch { }
        }
        #endregion
        #region Writelines
        public static void Write(string message)
        {
            if (This.rtfOutput.InvokeRequired)
            {
                This.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        This.rtfOutput.AppendText(message);
                    });
            }
            else
            {
                This.rtfOutput.AppendText(message);
            }
        }
        public static void Write(string message, Color color)
        {
            if (This.rtfOutput.InvokeRequired)
            {
                This.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        This.rtfOutput.SelectionColor = color;
                        This.rtfOutput.AppendText(message);
                    });
            }
            else
            {
                This.rtfOutput.SelectionColor = color;
                This.rtfOutput.AppendText(message);
            }
        }
        public static void Write(string message, Color color, Font font)
        {
            if (This.rtfOutput.InvokeRequired)
            {
                This.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        This.rtfOutput.SelectionColor = color;
                        This.rtfOutput.SelectionFont = font;
                        This.rtfOutput.AppendText(message);
                    });
            }
            else
            {
                This.rtfOutput.SelectionColor = color;
                This.rtfOutput.SelectionFont = font;
                This.rtfOutput.AppendText(message);
            }
        }
        // Lines
        public static void WriteLine(string message)
        {
            if (This.rtfOutput.InvokeRequired)
            {
                This.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        This.rtfOutput.AppendText(message + "\n");
                    });
            }
            else
            {
                This.rtfOutput.AppendText(message + "\n");
            }
        }
        public static void WriteLine(string message, Color color)
        {
            if (This.rtfOutput.InvokeRequired)
            {
                This.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        This.rtfOutput.SelectionColor = color;
                        This.rtfOutput.AppendText(message+"\n");
                    });
            }
            else
            {
                This.rtfOutput.SelectionColor = color;
                This.rtfOutput.AppendText(message + "\n");
            }
        }
        public static void WriteLine(string message, Color color, Font font)
        {
            if (This.rtfOutput.InvokeRequired)
            {
                This.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        This.rtfOutput.SelectionColor = color;
                        This.rtfOutput.SelectionFont = font;
                        This.rtfOutput.AppendText(message+"\n");
                    });
            }
            else
            {
                This.rtfOutput.SelectionColor = color;
                This.rtfOutput.SelectionFont = font;
                This.rtfOutput.AppendText(message+"\n");
            }
        }
        #endregion
        #region Events
        private void listViewDevices_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = this.listViewDevices.SelectedItems[0];
            // Clear and stop any current devices
            if(Device != null)
            {
                try
                {
                    this.CloseDevice(Device);
                }
                catch { }
            }
            Device = item.Tag as ICaptureDevice;
            if (!string.IsNullOrEmpty(txt_Ip.Text))
            {
                // If we are monitoring ip addresses, get them
                List<string> ips = Globals.SplitIPList(txt_Ip.Text);
                IsMonitoringIpAddresses = true;
                Font newFont = new Font(FontFamily.Families[2], 12, FontStyle.Bold);
                mainForm.Write("Monitoring Ip Addreses: ", Color.Black, newFont);

                foreach (string adds in ips)
                {
                    mainForm.Write(string.Format("{0} ", adds), Color.Black, newFont);
                }
                mainForm.WriteLine("");
                mainForm.Write("Packets sent from you are green    ", Color.Green);
                mainForm.Write("Packets sent to you from a remote ip are red", Color.Red);
                mainForm.WriteLine("");
            }
            if (!OpenDevice(Device)) { mainForm.WriteLine(string.Format("Unable to open device {0}", Device.Description), Color.Red); }
        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CloseDevice(Device);
            }
            catch { }
        }
        private void device_OnPacketArrival(object sender, SharpPcap.CaptureEventArgs e)
        {
            // Parse our ip
            IPAddress[] toMonitor;

            
            try
            {
                Packet packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
                TcpPacket tcp = packet.Extract(typeof(TcpPacket)) as TcpPacket;


                if (tcp != null)
                {
                    IpPacket ipPacket = (IpPacket)tcp.ParentPacket;
                    FontFamily lcFamily = null;
                    lcFamily = new FontFamily("Lucida Console");

                    if (lcFamily == null)
                        lcFamily = new FontFamily(GenericFontFamilies.Monospace);

                    System.Drawing.Font font = new Font(lcFamily, 8);
                    //mainForm.WriteLine(string.Format("From IP: {0} {1}",ipPacket.DestinationAddress.ToString(), ipPacket.DestinationAddress.AddressFamily.ToString()));
                    if (IsMonitoringIpAddresses && !string.IsNullOrEmpty(txt_Ip.Text))
                    {
                        foreach (string ip in Globals.SplitIPList(txt_Ip.Text))
                        {
                            // Try to parse
                            IPAddress a = null;
                            if (IPAddress.TryParse(ip, out a)) { }
                                //mainForm.WriteLine(string.Format("Parsed to {0}", Globals.ToUncompressedString(a)));

                            //if (ipPacket.DestinationAddress.ToString() == ip || ipPacket.SourceAddress.ToString() == ip)
                            if (Globals.ToUncompressedString(ipPacket.DestinationAddress) == Globals.ToUncompressedString(a) || Globals.ToUncompressedString(ipPacket.SourceAddress) == Globals.ToUncompressedString(a))
                            {
                                //mainForm.WriteLine("Matched IP", Color.Red);
                                // get the process using this ip and port
                                ProcessUsingIP = TcpHelper.GetProcessCommunicatingWithRemoteIP(ipPacket.DestinationAddress);
                                if (ProcessUsingIP != null)
                                {
                                    //mainForm.WriteLine(string.Format("Got Process {0}", ProcessUsingIP.ProcessName)); 
                                    byte[] pMem = null;
                                    if (Globals.TryGetAllProcessMemoryBytes(ProcessUsingIP, out pMem))
                                    {
                                        //mainForm.WriteLine(Globals.FormatBytes(pMem).Trim());
                                    }
                                }
                                // Write it out
                                if (Globals.FormatBytes(tcp.PayloadData).Trim() != "{ 0x };")
                                {
                                    if (ipPacket.SourceAddress.ToString() == ip)
                                    {
                                        mainForm.WriteLine(string.Format("From Ip {0} port {1} to Ip {2} port {3}", ipPacket.SourceAddress, tcp.SourcePort, ipPacket.DestinationAddress, tcp.DestinationPort), Color.Blue);
                                        mainForm.WriteLine(Globals.FormatBytes(tcp.PayloadData), Color.Red);
                                        mainForm.WriteLine(string.Format("Data                   Raw Hex Output - length={0} bytes", tcp.PayloadData.Length), Color.Red);
                                        mainForm.WriteLine(Globals.NiceHexOutput(tcp.PayloadData), Color.Red, font);
                                    }
                                    else
                                    {
                                        mainForm.WriteLine(string.Format("From Ip {0} port {1} to Ip {2} port {3}", ipPacket.SourceAddress, tcp.SourcePort, ipPacket.DestinationAddress, tcp.DestinationPort), Color.Blue);
                                        mainForm.WriteLine(Globals.FormatBytes(tcp.PayloadData), Color.Green);
                                        mainForm.WriteLine(string.Format("Data                   Raw Hex Output - length={0} bytes", tcp.PayloadData.Length), Color.Green);
                                        mainForm.WriteLine(Globals.NiceHexOutput(tcp.PayloadData), Color.Green, font);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Write it all out
                        if (Globals.FormatBytes(tcp.PayloadData).Trim() != "{ 0x };")
                        {
                            mainForm.WriteLine(string.Format("From Ip {0} port {1} to Ip {2} port {3}", ipPacket.SourceAddress, tcp.SourcePort, ipPacket.DestinationAddress, tcp.DestinationPort), Color.Blue);
                            mainForm.WriteLine(Globals.FormatBytes(tcp.PayloadData), Color.Black);
                            mainForm.WriteLine(string.Format("Data                   Raw Hex Output - length={0} bytes", tcp.PayloadData.Length), Color.Black);
                            mainForm.WriteLine(Globals.NiceHexOutput(tcp.PayloadData), Color.Black, font);
                        }
                    }
                }
            }
            catch { }
        }
        #endregion
        #region Functions
        public bool OpenDevice(ICaptureDevice device)
        {
            mainForm.WriteLine(string.Format("Using device {0}", Device.Description), Color.Black);
            mainForm.WriteLine("");
            int readTimeoutMilliseconds = 1000;
            if (device is SharpPcap.AirPcap.AirPcapDevice)
            {
                // NOTE: AirPcap devices cannot disable local capture
                var airPcap = device as SharpPcap.AirPcap.AirPcapDevice;
                airPcap.Open(SharpPcap.WinPcap.OpenFlags.DataTransferUdp, readTimeoutMilliseconds);
            }
            else if (device is SharpPcap.WinPcap.WinPcapDevice)
            {
                var winPcap = device as SharpPcap.WinPcap.WinPcapDevice;
                winPcap.Open(SharpPcap.WinPcap.OpenFlags.DataTransferUdp | SharpPcap.WinPcap.OpenFlags.NoCaptureLocal, readTimeoutMilliseconds);
            }
            else if (device is SharpPcap.LibPcap.LibPcapLiveDevice)
            {
                var livePcapDevice = device as SharpPcap.LibPcap.LibPcapLiveDevice;
                livePcapDevice.Open(SharpPcap.DeviceMode.Promiscuous, readTimeoutMilliseconds);
            }
            else
            {
                mainForm.WriteLine("Unknown device type of " + device.GetType().ToString(), Color.Red);
                return false;
            }
            // Register our handler function to the 'packet arrival' event
            device.OnPacketArrival +=
            new SharpPcap.PacketArrivalEventHandler(device_OnPacketArrival);
            device.StartCapture();
            return true;
        }
        public void CloseDevice(ICaptureDevice device)
        {
            Device.StopCapture();
            Device.OnPacketArrival -= new SharpPcap.PacketArrivalEventHandler(device_OnPacketArrival);
            mainForm.WriteLine(string.Format("No longer Listening to {0}", Device.Description), Color.Brown);
        }
        #endregion
        #region ToolStips and Buttons
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtfOutput.Clear();
            }
            catch { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveRtfFile.ShowDialog();
            saveRtfFile.DefaultExt = "*.rtf";
            //saveRtfFile.Filter = "RichText Document|*.rtf";
            saveRtfFile.Title = "Save PacketMonitor output as a rtf document.";
            saveRtfFile.OverwritePrompt = true;
            try
            {
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.rtfOutput.SaveFile(saveRtfFile.FileName);
                }
            }
            catch { }
        }

        private void btn_StopSniffing_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Device != null)
                {
                    this.Device.StopCapture();
                    mainForm.WriteLine("Capture stopped.", Color.Red);
                }
            }
            catch { mainForm.WriteLine("Unable to stop capture!", Color.Red); }
        }

        private void btn_StartSniffing_Click(object sender, EventArgs e)
        {
            if(listViewDevices.SelectedItems.Count !=0)
            this.listViewDevices_DoubleClick(this, new EventArgs());
        }
        #endregion

        private void btn_ConvertToInt_Click(object sender, EventArgs e)
        {
            mainForm.WriteLine(TcpHelper.PrintOutTcpConnections());
            int test = 0x7FFFFFFF;
            mainForm.WriteLine(test.ToString());
           
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtfOutput.SelectedRtf))
                Clipboard.SetText(rtfOutput.SelectedRtf);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rtfOutput.AppendText(Clipboard.GetText());
            rtfOutput.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtfOutput.SelectedRtf))
            {
                Clipboard.SetText(rtfOutput.SelectedRtf, TextDataFormat.Rtf);
                rtfOutput.SelectedRtf = "";
            }
        }

    }
}
