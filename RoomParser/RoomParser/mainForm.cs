using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace RoomParser
{
    public partial class mainForm : Form
    {
        public static mainForm Instance;
        public mainForm()
        {
            InitializeComponent();
            Instance = this;
            this.comboRooms.SelectedValueChanged += new EventHandler(comboRooms_SelectedValueChanged);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Windows.Forms.RichTextBox r = new System.Windows.Forms.RichTextBox();
            string contents = e.Argument as string;
            r.Rtf = contents;
            string text = r.Text;
            List<byte[]> rooms = new List<byte[]>();
            List<Room> Rooms = new List<Room>();
            string needle = "Packet ID: 33";
            int count = 0;
            int total = Regex.Matches(text, needle).Count;
            int position = -2;
            string work = text;
            while ((position = work.IndexOf(needle)) != -1)
            {
                work = work.Substring(position + (needle.Length)).Trim();
                int end = 0;
                end = work.IndexOf('}');
                string pak = work.Substring(0, end + 1);
                work = work.Substring(pak.Length);
                Room a = new Room();
                try
                {
                    Room b = a.FromBytes(RealmInfo.GetByteArrayFromString(pak));
                    Rooms.Add(b);
                }
                catch { }
                count++;
                backgroundWorker1.ReportProgress(count * 100 / total);
                
            }
            Parser_RoomsCompleted(Rooms);
        }
        private void backgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs e)
        {
        }
        void comboRooms_SelectedValueChanged(object sender, EventArgs e)
        {
            this.rtfOutput.Clear();
            Room r = this.comboRooms.SelectedItem as Room;
            this.txt_RoomName.Text = r.RoomName;
            txt_Background.Text = r.Background.ToString();
            txt_BlockedExits.Text = r.Blocked.ToString();
            lbl_CastingAllowed.Text = r.CastingAllowed.ToString();
            lbl_RoomDecTotal.Text = r.Decorations.Count.ToString();
            WriteLine(ConvertToScript(r));
        }
        public static void InternalWrite(string message)
        {
            if (Instance.rtfOutput.InvokeRequired)
            {
                Instance.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        Instance.rtfOutput.AppendText(message + "\n");
                    });
            }
            else Instance.rtfOutput.AppendText(message + "\n");
        }
        public static void WriteLine(string message)
        {
            InternalWrite(message);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.Filter = "Decoded Realm Logs|*.rtf";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Extract decoded rooms from real logs.";
            DialogResult r = openFileDialog1.ShowDialog();

            if (r == System.Windows.Forms.DialogResult.OK)
            {
                string contents = File.ReadAllText(openFileDialog1.FileName);
                backgroundWorker1.RunWorkerAsync(contents);
            }
        }
        void Parser_RoomsCompleted(List<Room> rooms)
        {
            this.Reset();
            //Populate our shiz
            foreach (Room r in rooms)
            {
                if (this.comboRooms.InvokeRequired)
                {
                    this.comboRooms.Invoke((MethodInvoker)
                        delegate
                        {
                            this.comboRooms.Items.Add(r);
                        });
                }
                else this.comboRooms.Items.Add(r);
            }
            if (this.comboRooms.InvokeRequired)
            {
                this.comboRooms.Invoke((MethodInvoker)
                    delegate
                    {
                        try { this.comboRooms.SelectedIndex = 0; }
                        catch { }
                    });
            }
            else this.comboRooms.SelectedIndex = 0;
            
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveScript(this.rtfOutput.Text);
        }
        void Reset()
        {
            if (this.rtfOutput.InvokeRequired)
            {
                this.rtfOutput.Invoke((MethodInvoker)
                    delegate
                    {
                        this.rtfOutput.Clear();
                    });
            }
            else this.rtfOutput.Clear();
            if (this.comboRooms.InvokeRequired)
            {
                this.comboRooms.Invoke((MethodInvoker)delegate { this.comboRooms.Items.Clear(); });
            }
            else this.comboRooms.Items.Clear();

            if (this.txt_Background.InvokeRequired)
            {
                this.txt_Background.Invoke((MethodInvoker)delegate
                { this.txt_Background.Text = ""; });
            }
            else txt_Background.Text = "";

            if (this.txt_BlockedExits.InvokeRequired)
            {
                this.txt_BlockedExits.Invoke((MethodInvoker)delegate
                { this.txt_BlockedExits.Text = ""; });
            }
            else txt_BlockedExits.Text = "";

            if (this.txt_RoomName.InvokeRequired)
            {
                this.txt_RoomName.Invoke((MethodInvoker)delegate
                { this.txt_RoomName.Text = ""; });
            }
            else txt_RoomName.Text = "";

            if (this.lbl_CastingAllowed.InvokeRequired)
            {
                this.lbl_CastingAllowed.Invoke((MethodInvoker)delegate
                { this.lbl_CastingAllowed.Text = "Unknown"; });
            }
            else lbl_CastingAllowed.Text = "Unknown";

            if (this.lbl_RoomDecTotal.InvokeRequired)
            {
                this.lbl_RoomDecTotal.Invoke((MethodInvoker)delegate
                { this.lbl_RoomDecTotal.Text = "0"; });
            }
            else lbl_RoomDecTotal.Text = "0";
        }
        string ConvertToScript(Room r)
        {
            StringBuilder b = new StringBuilder();
            b.AppendLine("using System;");
            b.AppendLine("using System.Collections.Generic;");
            b.AppendLine("using System.Linq;");
            b.AppendLine("using System.Text;");
            b.AppendLine("using RealmOffline.Core.Rooms;");
            b.AppendLine(" ");
            b.AppendLine("namespace Scripts.Rooms");
            b.AppendLine("{");
            b.AppendLine(string.Format("  public class Room{0} : Room", r.RoomID));
            b.AppendLine("  {");
            b.AppendLine(string.Format("        public Room{0}()", r.RoomID));
            b.AppendLine(string.Format("            : base({0}, \"{1}\")", r.RoomID, r.RoomName));
            b.AppendLine("      { }");

            b.AppendLine("      public override void ApplyRoomLayout()");
            b.AppendLine("      {");
            b.AppendLine(string.Format("          this.Background = RoomBackground.{0};", r.Background.ToString()));
            b.AppendLine(string.Format("          this.BlockedRoomExits = BlockedExits.{0};", r.Blocked.ToString()));
            foreach (RoomDecoration d in r.Decorations)
            {
                b.AppendLine(string.Format("          this.AddRoomDecoration(RoomDecoration.FromCode({0}, {1}, {2}, {3}, {4}));", 
                    d.GraphicID, d.LocationX, d.LocationY, d.LocationZ, d.RoomID));
            }
            b.AppendLine(string.Format("          this.AllowCasting = {0};", r.CastingAllowed));
            b.AppendLine("          base.ApplyRoomLayout();");
            b.AppendLine("      }");
            b.AppendLine("// We do not know these values yet");

            b.AppendLine("      public override uint GetNextRoomByExit(RoomExit exit)");
            b.AppendLine("      {");
            b.AppendLine("          switch (exit)");
            b.AppendLine("          {");
            b.AppendLine("              case RoomExit.North: return 5043;");
            b.AppendLine("              case RoomExit.South: return 5043;");
            b.AppendLine("              case RoomExit.East: return 5043;");
            b.AppendLine("              case RoomExit.West: return 5043;");
            b.AppendLine("              default: return 5043;");
            b.AppendLine("           }");
            b.AppendLine("          }");
            b.AppendLine("      }");
            b.AppendLine("  }");
            return b.ToString();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.rtfOutput.ReadOnly = false;
            this.rtfOutput.SelectAll();
           // this.rtfOutput.ReadOnly = true;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtfOutput.Copy();
        }

        private void saveScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveScript(this.rtfOutput.Text);
        }
        private void SaveScript(string script)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "cs";
            saveFileDialog1.Filter = "Realm Emu Room Script|*.cs";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Title = "Save room as realm emu script.";
            DialogResult r = saveFileDialog1.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                string val = rtfOutput.Text;
                try
                {
                    File.WriteAllLines(saveFileDialog1.FileName, val.Split('\n'));
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, ex.StackTrace); }
            }
        }

        private void saveAllAcriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAllScripts();
        }
        void SaveAllScripts()
        {
            folderBrowserDialog1.Description = "Choose a folder to save all room scripts to.";
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult r = folderBrowserDialog1.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (!Directory.Exists(folderBrowserDialog1.SelectedPath)) Directory.CreateDirectory(folderBrowserDialog1.SelectedPath);
                }
                catch { MessageBox.Show(string.Format("Unable to access folder {0}!", folderBrowserDialog1.SelectedPath), "Error saving scripts!", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

                foreach (object o in this.comboRooms.Items)
                {
                    Room room = o as Room;
                    string cscript = ConvertToScript(room);
                    string filename = string.Format("Room{0}.cs", room.RoomID);
                    try
                    {
                        File.WriteAllLines(Path.Combine(folderBrowserDialog1.SelectedPath, filename), cscript.Split('\n'));
                    }
                    catch { MessageBox.Show(string.Format("Unable to save room {0}!", room.RoomID), "Error saving scripts!", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                }
                MessageBox.Show("Rooms Saved.");
            }
        }

        private void saveAllRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveAllScripts();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox a = new AboutBox())
            {
                a.Init();
                a.ShowDialog();
            }
        }
    }
}
