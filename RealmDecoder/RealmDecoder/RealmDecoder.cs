using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmDecoder.Encryption;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
/*
* 
* 
* Need to rewrite from scratch again so sloppy
* 
*/
namespace RealmDecoder
{
    public enum PacketOrigin
    {
        None,
        Server,
        Client
    }
    public class RealmDecoder
    {
        public string Original { get; private set; }
        private int ServerPacketsParsed = 0;
        private int ClientPacketsParsed = 0;
        private PacketOrigin Origin { get; set; }
        public XoRKey ServerKey { get; private set; }
        public XoRKey ClientKey { get; private set; }
        cryption uc;
        byte[] bx = null;
        private Dictionary<int, byte[]> ServerConversation { get; set; }
        private Dictionary<int, byte[]> ClientConversation { get; set; }
        private int TotalPackets = 0;
        private Dictionary<int, byte[]> Decrypted { get; set; }
        private Dictionary<int, byte[]> ServerConversationDecrypted { get; set; }
        private Dictionary<int, byte[]> ClientConversationDecrypted { get; set; }
        BackgroundWorker fileWorker;
        private string FromIp = string.Empty;
        private string FromPort = string.Empty;

        public RealmDecoder(string text, string fromIP, string fromPort)
        {
            this.Original = text;
            this.FromIp = fromIP;
            this.FromPort = fromPort;
            Origin = PacketOrigin.None;
            this.ServerConversation = new Dictionary<int, byte[]>();
            this.ServerConversationDecrypted = new Dictionary<int, byte[]>();
            this.ClientConversation = new Dictionary<int, byte[]>();
            this.ClientConversationDecrypted = new Dictionary<int, byte[]>();
            this.Decrypted = new Dictionary<int, byte[]>();
            //watch = new Stopwatch();
        }
        private void fileWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Tell main form we are calculating
            Form1.UpdateLabel("Worker is parsing information, please wait");
            Form1.UpdateBlinkingText("Stage Three");
            TotalPackets = GetTotalServerPackets();
            if(TotalPackets != 0)
            Form1.UpdateLabel(string.Format("Total Packets found {0}", TotalPackets));
            else Form1.UpdateLabel(string.Format("We cant find any packets!")); return;
        }
        private void fileWorker_DoWork2(object sender, DoWorkEventArgs e)
        {
            int totalServer = 0;
            int totalClient = 0;
            int total = TotalPackets;
            TotalPackets = 0;
            //Form1.SetProgressBarMinMax(0, TotalPackets);
            //Form1.UpdateProgressbarValue(0);
            Form1.SetProgressBarMinMax(0, total);
            Form1.UpdateBlinkingText("Stage Four");
            // We start by getting server packets, they begin with From Ip
            string from = string.Format("From Ip {0} port {1}",this.FromIp, this.FromPort);//"From";
            string work = this.Original;//.Trim();
            while (work != string.Empty)
            {
                //Form1.UpdateLabel(string.Format("Loading {0} packets.", totalPasses));
                //totalPasses++;
                // Goto the first occurance of this
                int fromIndex = -1;
                fromIndex = work.IndexOf(from);
                if (fromIndex < 0)
                    break;
                // For now cut all off up to this
                work = work.Remove(0, fromIndex);
                // If we are a server packet, the first port will be 8001, if not its a client packet
                int fromPort = work.IndexOf("port");
                if (fromPort <= 0)
                    break;
                work = work.Remove(0, fromPort + 5); // gets us to our first port
                string firstPort = work.Split(' ').First();

                // Here is where we begin the parse
                if (firstPort == "8000" || firstPort == "8001")
                {
                    // server packet
                    // So we goto the first { and grab the string until the next }
                    int start = work.IndexOf("{");
                    int stop = 0;
                    string begin = string.Empty;
                    string end = string.Empty;

                    if (start <= 0)
                    {
                        Form1.WriteLine("Error Parsing Server Packet", System.Drawing.Color.Red);
                        break;
                    }
                    else
                    {

                        work = work.Remove(0, start);
                        stop = work.IndexOf(";");
                        begin = work.Remove(stop);
                        byte[] test = Tools.GlobalFunctions.ParseFullHexStringToArray(begin);

                        this.ServerConversation.Add(TotalPackets, test);
                        TotalPackets++;
                        totalServer++;
                        Form1.UpdateProgressbarValue(totalServer);
                    }
                }
                else
                {
                    int start = work.IndexOf("{");
                    int stop = 0;
                    string begin = string.Empty;
                    string end = string.Empty;

                    work = work.Remove(0, start);
                    stop = work.IndexOf(";");
                    begin = work.Remove(stop);
                    byte[] test = Tools.GlobalFunctions.ParseFullHexStringToArray(begin);
                    this.ClientPacketsParsed++;
                    DecodePacket(test, PacketOrigin.Client);
                    this.ClientConversation.Add(TotalPackets, test);
                    // its a client packet
                    TotalPackets++;
                    totalClient++;
                }
            }
            string reply = string.Empty;
            if (this.ServerConversation.Count == 0)
            {
                reply += string.Format("Server Packets failed to parse !  ");
            }
            if (this.ClientConversation.Count == 0)
            {
                reply += string.Format("Client Packets failed to parse !  ");
            }
            if (reply == string.Empty)
                reply = string.Format("Loading done, {0} server packets {1} client packets ({2}) Packets Total", this.ServerConversation.Count, this.ClientConversation.Count, TotalPackets);

            Form1.WriteLine(reply);
            DecryptClient();

            try
            {
                DecryptServer();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void fileWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage != 1)
            Form1.UpdateProgressbarValue(e.ProgressPercentage);
        }
        private void fileWorker_RunWorkerCompleted2(object sender, RunWorkerCompletedEventArgs e)
        {
        }
        private void fileWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // start another worker
            fileWorker = new BackgroundWorker();
            fileWorker.WorkerReportsProgress = true;
            fileWorker.WorkerSupportsCancellation = true;
            fileWorker.DoWork += new DoWorkEventHandler(fileWorker_DoWork2);
            fileWorker.ProgressChanged += new ProgressChangedEventHandler(fileWorker_ProgressChanged);
            fileWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(fileWorker_RunWorkerCompleted2);
            fileWorker.RunWorkerAsync();
           
        }
        public void Decode()
        {
            fileWorker = new BackgroundWorker();
            fileWorker.WorkerReportsProgress = true;
            fileWorker.WorkerSupportsCancellation = true;
            fileWorker.DoWork += new DoWorkEventHandler(fileWorker_DoWork);
            fileWorker.ProgressChanged += new ProgressChangedEventHandler(fileWorker_ProgressChanged);
            fileWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(fileWorker_RunWorkerCompleted);
            fileWorker.RunWorkerAsync();
        }
        public void DecryptClient()
        {
            List<byte> builder = new List<byte>();
            if (this.ClientConversation.Count == 0) { return; }
            // First packet contains our key
            byte[] keypacket = this.ClientConversation.First().Value;
            int key = this.ClientConversation.Keys.First();
            this.ClientKey = Tools.GlobalFunctions.GetKeyFromKnownPacketID(keypacket, 14);
            int length = 0;
            int crc = 0;
            byte[] toUnXor = Tools.GlobalFunctions.GetPortionsToXOR(keypacket, out length, out crc, true);
            byte[] xor = Xor.decrypt(toUnXor, this.ClientKey);
            builder.AddRange(BitConverter.GetBytes(length));
            builder.AddRange(BitConverter.GetBytes(14));
            builder.AddRange(xor);
            builder.AddRange(new byte[4]);
            this.ClientConversationDecrypted.Add(key, builder.ToArray());
            // First Client packets Added
            for (int i = 1; i < this.ClientConversation.Count; i++)
            {
                builder.Clear();
                toUnXor = Tools.GlobalFunctions.GetPortionsToXOR(this.ClientConversation.Values.ElementAt(i), out length, out crc);
                xor = Xor.decrypt(toUnXor, this.ClientKey);
                builder.AddRange(BitConverter.GetBytes(length));
                builder.AddRange(xor);
                builder.AddRange(new byte[4]);
                this.ClientConversationDecrypted.Add(this.ClientConversation.Keys.ElementAt(i), builder.ToArray());
            }
            foreach (KeyValuePair<int, byte[]> values in this.ClientConversationDecrypted)
            {
                WritePaket(values.Value, PacketOrigin.Client);
            }
        }
        public void DecryptServer()
        {
            Form1.UpdateBlinkingText("Stage Five Decoding");
            List<byte[]> packets = new List<byte[]>();
            int k = 0;
            int t = 0;
            int lnk = 0;
            byte[] d1 = ConvertDictionary(this.ServerConversation);
            while (t < d1.Length)
            {
                //Form1.WriteLine(string.Format("DEBUG: t = {0} and D1.Length = {1}.", t, d1.Length));
                lnk = BitConverter.ToInt32(d1, t);
                lnk += 4;
                byte[] bx = new byte[lnk];
                Array.Copy(d1, t + 4, bx, 0, lnk);
                t += lnk + 4;
                if (k == 0)
                {
                    uc = new cryption(bx);
                    uc.decript(bx, 0x19);
                }
                else
                {
                    uc.data = bx;
                    uc.decript();
                }
                // Get the length -4
                Int32 length = uc.data.Length - 4;
                byte[] p_len = BitConverter.GetBytes(length);
                byte[] fullPacket = new byte[p_len.Length + uc.data.Length];
                Array.Copy(p_len, fullPacket, p_len.Length);
                Array.Copy(uc.data, 0, fullPacket, 4, uc.data.Length);

                // We have the decoded packets now, so we need to put them back in order
                // that way i can see how the client answers.
                packets.Add(fullPacket);
                WritePaket(fullPacket, PacketOrigin.Server);
                //rt_op.AppendText(FormatBytes(fullPacket));//.Text += FormatBytes(fullPacket);//(uc.data) + "\n";//ByteArrayToHexString(uc.data) + "\n";
                //rt_op.SelectionColor = Color.Red;
                //rt_op.AppendText(NiceHexOutput(fullPacket));
                k++;
            }
            //BuildServerDecodeDic(packets);
            Form1.UpdateBlinkingText("Completed");
            Form1.BlinkLabel(false);
        }
        public void BuildServerDecodeDic(List<byte[]> serverPackets)
        {
            // So we need to filter through our undecoded server list
            // and try to realign these packets
            // The first packet here is packet 0
            //this.ServerConversationDecrypted.Add(0, serverPackets[0]);
            for (int i = 0; i < this.ServerConversation.Count; i++)
            {
                var item = this.ServerConversation.ElementAt(i);
                this.ServerConversationDecrypted.Add(item.Key, serverPackets[i]);
            }
        }
        public byte[] ConvertDictionary(Dictionary<int, byte[]> dic)
        {
            // we need to remove some of these bytes to work right
            List<byte> builder = new List<byte>();
            foreach (KeyValuePair<int, byte[]> values in dic)
            {
                if (values.Key == 1)
                {
                    // Get the last 32 byte
                    byte[] last = new byte[32];
                    Array.Copy(values.Value, (values.Value.Length - 32), last, 0, last.Length);
                    builder.AddRange(last);
                }
                else if(values.Key !=0)
                builder.AddRange(values.Value);
            }
            return builder.ToArray();
        }
        public byte[] GetPacketByOrder(int order, out PacketOrigin origin)
        {
            origin = PacketOrigin.None;
            if (this.ClientConversation.ContainsKey(order))
            {
                origin = PacketOrigin.Client;
                return this.ClientConversation[order];//.ElementAt(order).Value;
            }
            else if (this.ServerConversation.ContainsKey(order))
            {
                origin = PacketOrigin.Server;
                return this.ServerConversation[order];//.ElementAt(order).Value;
            }
            return null;
        }
        public void DecodePacket(byte[] packet, PacketOrigin origin)
        {
            
            int p_len = 0;
            int crc = 0;

            if (origin == PacketOrigin.Client)
            {
                if (this.ClientPacketsParsed == 0)
                {
                    this.ClientKey = Tools.GlobalFunctions.GetKeyFromKnownPacketID(packet, 14);

                    byte[] toXor = Tools.GlobalFunctions.GetPortionsToXOR(packet, out p_len, out crc, true);
                    byte[] xored = Xor.decrypt(toXor, this.ClientKey);
                    byte[] len = BitConverter.GetBytes(p_len);
                    byte[] full = new byte[len.Length + toXor.Length+8];
                    Array.Copy(len, full, len.Length);
                    Array.Copy(BitConverter.GetBytes(14), 0, full, 4, BitConverter.GetBytes(14).Length);
                    Array.Copy(xored, 0, full, 8, xored.Length);
                    WritePaket(full, PacketOrigin.Client);
                    
                }
                else if (this.ClientKey != null)
                {
                    byte[] toXor = Tools.GlobalFunctions.GetPortionsToXOR(packet, out p_len, out crc);
                    byte[] len = BitConverter.GetBytes(p_len);
                    byte[] xor = Xor.decrypt(toXor, this.ClientKey);
                    byte[] full = new byte[len.Length + toXor.Length + 4];
                    Array.Copy(len, full, len.Length);
                    Array.Copy(xor, 0, full, 4, xor.Length);
                    WritePaket(full, PacketOrigin.Client);
                    //WritePaket(packet, origin);
                }
                this.ClientPacketsParsed++;
            }
            else if (origin == PacketOrigin.Server)
            {

                if (this.ServerPacketsParsed == 1)
                {
                    byte[] p1 = new byte[32];
                    // Get the last 32 bytes
                    Array.Copy(packet, (packet.Length - 32), p1, 0, p1.Length);
                    // This is our server decode packet
                    //int k = 0;
                    int t = 0;
                    int lnk = 0;
                    #region While
                    while (t < p1.Length)
                    {
                        lnk = BitConverter.ToInt32(p1, t);
                        lnk += 4;
                        bx = new byte[lnk];
                        Array.Copy(p1, t + 4, bx, 0, lnk);
                        t += lnk + 4;
                        //if (k == 0)
                        //{
                        this.uc = new cryption(bx);
                        uc.decript(bx, 0x19);
                        //}
                        //else
                        // {

                        // }
                        // Get the length -4
                        Int32 length = uc.data.Length - 4;
                        byte[] p_len2 = BitConverter.GetBytes(length);
                        byte[] fullPacket = new byte[p_len2.Length + uc.data.Length];
                        Array.Copy(p_len2, fullPacket, p_len2.Length);
                        Array.Copy(uc.data, 0, fullPacket, 4, uc.data.Length);
                        WritePaket(fullPacket, PacketOrigin.Server);
                        
                        //rt_op.AppendText(FormatBytes(fullPacket));//.Text += FormatBytes(fullPacket);//(uc.data) + "\n";//ByteArrayToHexString(uc.data) + "\n";
                        //rt_op.SelectionColor = Color.Red;
                        //rt_op.AppendText(NiceHexOutput(fullPacket));

                    }
                    #endregion
                }
                else if(this.ServerPacketsParsed >= 2)
                {
                    //this.uc.data = packet;
                    // remove first 4 
                    byte[] data = new byte[packet.Length - 4];
                    Array.Copy(packet, 4, data, 0, data.Length);
                    //int pos = this.uc.data.Length;
                    //Array.Resize(ref this.uc.data, this.uc.data.Length + packet.Length);
                    //Array.Copy(packet, 0, this.uc.data, pos, packet.Length);
                    //this.uc.data = packet;
                    this.uc.decript(data);
                    //Form1.WriteLine(string.Format("Length of this packet divisible by 4 ? {0}", packet.Length % 4 == 0));
                    WritePaket(this.uc.data, PacketOrigin.Server);
                }
                this.ServerPacketsParsed++;
            }
        }
        public void WritePaket(byte[] packet, PacketOrigin origin)
        {
            switch (origin)
            {
                case PacketOrigin.Server:
                    {
                        Form1.WriteLine(string.Format("Server Packet {0} Packet ID: {1}\n{2}\n",this.ServerPacketsParsed, BitConverter.ToInt32(packet, 4), Tools.GlobalFunctions.FormatBytes(packet)), System.Drawing.Color.Red);
                        Form1.WriteLine(Tools.GlobalFunctions.NiceHexOutput(packet), System.Drawing.Color.Red);
                        Form1.WriteLine("-----------------------------------------------------------------------------------------------------------------------------", System.Drawing.Color.Red);
                    }
                    break;
                case PacketOrigin.Client:
                    {
                        Form1.WriteLine(string.Format("Client Packet {0} Packet ID: {1}\n{2}\n", this.ClientPacketsParsed, BitConverter.ToInt32(packet, 4), Tools.GlobalFunctions.FormatBytes(packet)), System.Drawing.Color.Green);
                        Form1.WriteLine(Tools.GlobalFunctions.NiceHexOutput(packet), System.Drawing.Color.Green);
                        Form1.WriteLine("-----------------------------------------------------------------------------------------------------------------------------", System.Drawing.Color.Green);
                    }
                    break;
            }
        }
        public int GetTotalServerPackets()
        {
            string source = this.Original;
            string searchPattern = string.Format("From Ip {0} port {1}", this.FromIp, this.FromPort);//"From Ip";
            return Regex.Matches(source, searchPattern).Count;
        }
    }
}
