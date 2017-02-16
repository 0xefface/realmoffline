using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using RealmDecoder.Encryption;
using System.IO;
using System.Net;

namespace RealmDecoder
{
    public partial class Form1 : Form
    {
        private static Form1 This { get; set; }
        private RealmDecoder Decoder { get; set; }
        private bool Decode { get; set; }
        private string RtfText { get; set; }

        public Form1()
        {
            This = this;
            InitializeComponent();
        }
        #region WriteLines
        public static void WriteLine(string message)
        {
            WriteLine(message, Color.Black);
        }
        public static void WriteLine(string message, Color color)
        {
            if (This.rtfOutput.InvokeRequired)
                This.rtfOutput.Invoke((MethodInvoker)delegate { InternalWrite(message, color); });
            else
            InternalWrite(message, color);
        }
        private static void InternalWrite(string message, Color color)
        {
            try
            {
                This.rtfOutput.SelectionColor = color;
                This.rtfOutput.AppendText(message + "\n");
            }
            catch { }
        }
        #endregion
        #region MainToolstrip
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txt_Ip.Text) || string.IsNullOrEmpty(this.txt_Port.Text)) { MessageBox.Show("You must supply a valid IP and Port!", "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            //workerA.DoWork += new DoWorkEventHandler(workerA_OpenRtfFile);
            IPAddress ip = null;
            if (!IPAddress.TryParse(this.txt_Ip.Text, out ip)) { MessageBox.Show(string.Format("Invalid Ip Address of {0}", this.txt_Ip.Text), "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            openFileDialog.DefaultExt = "*.rtf";
            openFileDialog.Filter = "RichText Document|*.rtf";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open a PacketMonitor realm log, and try to decode the packets.";
            
            DialogResult result = openFileDialog.ShowDialog();
            try
            {
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    UpdateWorkingFileLabel(string.Format("Loading file {0}.", openFileDialog.FileName));
                    UpdateLabel("Loading file, this will take a long while with large files please wait ..");
                    BlinkLabel(true);
                    UpdateBlinkingText("Stage One");

                    Task t2 = Task.Factory.StartNew(() =>
                        {
                            this.workerA.DoWork += (sender1, args) => workerA_OpenRtfFile(sender1, args, openFileDialog.FileName);
                            this.workerA.ProgressChanged += new ProgressChangedEventHandler(workerA_ProgressChanged);
                            this.workerA.RunWorkerCompleted += new RunWorkerCompletedEventHandler(workerA_RunWorkerCompleted);
                            this.workerA.RunWorkerAsync();
                        });
                }
            }
            catch (Exception ex) { Form1.WriteLine(ex.Message, Color.Red); }
        }
        private void workerA_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Label label = GetUpdateLabel();
            //label.StopBlinking();
             //UpdateLabel("Done, begining to parse.");
            UpdateBlinkingText("Stage Two");
            Decoder = new RealmDecoder(this.RtfText, this.txt_Ip.Text, this.txt_Port.Text);
            Decoder.Decode();
        }
        private void workerA_OpenRtfFile(object sender, DoWorkEventArgs e, string fileName)
        {
            //UpdateProgressbarValue(0);
            string str = ReadFile(fileName);
            using (RichTextBox rtb = new RichTextBox())
            {
                rtb.Rtf = str;
                str = rtb.Text;
            }
            this.RtfText = str;
        }
        #region Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RichText Document|*.rtf";
            saveFileDialog.Title = "Save Decoded PacketMonitor output as a rtf document.";
            saveFileDialog.OverwritePrompt = true;
            DialogResult result = saveFileDialog.ShowDialog();

            try
            {
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.rtfOutput.SaveFile(saveFileDialog.FileName);
                }
            }
            catch (Exception ex) { Form1.WriteLine(ex.Message, Color.Red); }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Decode = false;
        }
        #endregion
        #region Save and CLear
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.rtf";
            save.Filter = "RichText Document|*.rtf";
            save.Title = "Save RealmDecoder output as a rtf document.";
            save.OverwritePrompt = true;
            DialogResult result = save.ShowDialog();
            try
            {
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.rtfOutput.SaveFile(save.FileName);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtfOutput.Clear();
        }
        #endregion
        #region LoadTest
        private void loadTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.DefaultExt = "*.rtf";
            openFileDialog.Filter = "RichText Document|*.rtf";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open a PacketMonitor realm log, and try to decode the packets.";
            DialogResult result = openFileDialog.ShowDialog();
            try
            {
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    rtfOutput.LoadFile(openFileDialog.FileName);
                    //Decoder = new RealmDecoder(this.rtfOutput.Text);
                    string text = this.rtfOutput.Text;
                    this.rtfOutput.Clear();
                    string f = "From";
                    int first = text.IndexOf(f);
                    this.rtfOutput.AppendText(string.Format("Location of first from {0}", first));
                    //this.rtfOutput.AppendText(text);
                    //Decoder.Decode();
                }
            }
            catch (Exception ex) { Form1.WriteLine(ex.Message, Color.Red); }
        }
        #endregion
        public static void UpdateLabel(string text)
        {
            if (This.lblResult.InvokeRequired)
            {
                This.lblResult.Invoke((MethodInvoker)
                    delegate
                    {
                        This.lblResult.Text = text;
                    });
            }
            else
            {
                This.lblResult.Text = text;
            }
        }
        public static void UpdateWorkingFileLabel(string text)
        {
            if (This.workingFileLabel.InvokeRequired)
            {
                This.workingFileLabel.Invoke((MethodInvoker)
                    delegate
                    {
                        This.workingFileLabel.Text = text;
                    });
            }
            else
            {
                This.workingFileLabel.Text = text;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void workerA_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //UpdateProgressbarValue(e.ProgressPercentage);
            //UpdateLabel(string.Format("{0}", e.ProgressPercentage));
        }

        public static void SetProgressbarColor(Color color)
        {
            if (This.progressBar.InvokeRequired)
            {
                This.progressBar.Invoke((MethodInvoker)
                    delegate
                    {
                        This.progressBar.ForeColor = color;
                    });
            }
            else
            {
                This.progressBar.ForeColor = color;
            }
        }
        public static void UpdateProgressbarValue(int value)
        {
            if (This.progressBar.InvokeRequired)
            {
                This.progressBar.Invoke((MethodInvoker)
                    delegate
                    {
                        if(This.progressBar.Maximum !=0)
                        This.progressBar.Value = value;

                    });
            }
            else
            {
                This.progressBar.Value = value;
            }
        }
        public static void SetProgressBarMinMax(int min, int max)
        {
            if (This.progressBar.InvokeRequired)
            {
                This.progressBar.Invoke((MethodInvoker)
                    delegate
                    {
                        This.progressBar.Minimum = min;
                        This.progressBar.Maximum = max;
                    });
            }
            else
            {
                This.progressBar.Minimum = min;
                This.progressBar.Maximum = max;
            }
        }
        public static Label GetUpdateLabel()
        {
            Label result = null;
            if (This.lblResult.InvokeRequired)
            {
                This.lblResult.Invoke((MethodInvoker)
                    delegate
                    {
                        result = This.lblResult;
                    });
            }
            else
                result = This.lblResult;
            return result;
        }
        private int _bufferSize = 16384;

        private string ReadFile(string filename)
        {
            StringBuilder stringBuilder = new StringBuilder();
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int bytesCompleted = 0;
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                int totalLength = (int)streamReader.BaseStream.Length;
                SetProgressBarMinMax(bytesCompleted, totalLength);
                char[] fileContents = new char[_bufferSize];
                int charsRead = streamReader.Read(fileContents, 0, _bufferSize);

                // Can't do much with 0 bytes        
                if (charsRead == 0)
                    throw new Exception("File is 0 bytes");

                while (charsRead > 0)
                {
                    bytesCompleted += charsRead;
                    UpdateProgressbarValue(bytesCompleted);
                    stringBuilder.Append(fileContents);
                    charsRead = streamReader.Read(fileContents, 0, _bufferSize);
                }
            }
            return stringBuilder.ToString();
        }
        public static void UpdateBlinkingText(string text)
        {
            if (This.blinkingLabel.InvokeRequired)
            {
                This.blinkingLabel.Invoke((MethodInvoker)
                    delegate
                    {
                        This.blinkingLabel.Text = text;
                    });
            }
            else
            {
                This.blinkingLabel.Text = text;
            }
        }
        public static void BlinkLabel(bool blink)
        {
            if (This.blinkingLabel.InvokeRequired)
            {
                This.blinkingLabel.Invoke((MethodInvoker)
                    delegate
                    {
                        if (blink)
                            This.blinkingLabel.BeginBlinking(400);
                        else This.blinkingLabel.StopBlinking();
                    });
            }
            else
            {
                if (blink)
                    This.blinkingLabel.BeginBlinking(400);
                else This.blinkingLabel.StopBlinking();
            }
        }
    }
}
