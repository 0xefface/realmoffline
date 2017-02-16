using SCI32;
using SCI32ResourceEditor.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCI32.Collections;
using System.IO;
using System.Collections;
using SharpLZW;

namespace SCI32ResourceEditor
{
    public partial class Form1 : Form
    {
        static Form1 This { get; set; }
        private SCI32ResourceDirectoryCollection ResourceDirectories { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.resourceView.NodeMouseClick += resourceView_NodeMouseClick;
            this.resourceView.KeyDown += resourceView_KeyDown;
            this.resourceView.KeyUp += resourceView_KeyUp;
            this.resourceView.AfterExpand += resourceView_AfterExpand;
            this.resourceView.AfterCollapse+= resourceView_AfterCollapse;
            SCI32Tools.Messageproxy.MessageRelay += new SCI32.SCI32Tools.Messageproxy.MessageEventHandler(Messageproxy_MessageRelay);
            This = this;
        }
        private void Messageproxy_MessageRelay(object sender, SCI32.SCI32Tools.MessageEventArgs e)
        {
            WriteLine(e.Message);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openResourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // for now we want the resmap.*
            openFileDialog1.Filter = "Resmap Files|Resmap.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "View Resources packed in SCI32 format.";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.ResourceDirectories = new SCI32ResourceDirectoryCollection();
                    this.ResourceDirectories.ProcessResmap(openFileDialog1.FileName);
                    PopulateTreeView(this.ResourceDirectories);
                }
                catch (IOException io) { MessageBox.Show(io.Message, "Error Loading Resource!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
        }
        #region Tree
        private void SetTreeNodeIconSelected(int index, int iconID)
        {
            this.resourceView.Nodes[index].SelectedImageIndex = iconID;
        }
        private void SetTreeNodeIconNormal(int index, int iconID)
        {
            this.resourceView.Nodes[index].ImageIndex = iconID;
        }
        private void PopulateTreeView(SCI32ResourceDirectoryCollection resourceCollection)
        {
            this.resourceView.Nodes.Clear();
            for (int i = 0; i < resourceCollection.Count; i++)
            {
                SCI32ResourceDirectory dir = resourceCollection[i];
                // these are our directories
                TreeNode dirNode = new TreeNode(dir.GetDirectoryNameByType(dir.Type), Icons.GetIconIndex(Helpers.Icon.ClosedFolder), Icons.GetIconIndex(Helpers.Icon.ClosedFolder));
                dirNode.Name = dir.GetDirectoryNameByType(dir.Type);
                dirNode.Tag = "Directory";
                for (int j = 0; j < dir.Resources.Count;j++ )
                {
                    SCI32Resource res = dir.Resources[j];
                    // We want a filename

                    TreeNode childNode = new TreeNode(res.FileName, Icons.GetIconIndexByType(res.ResourceType), Icons.GetIconIndexByType(res.ResourceType));
                    childNode.Name = res.FileName;
                    childNode.Tag = "File";
                    // check here for duplicates
                    dirNode.Nodes.Add(childNode);
                }
                dirNode.SortAllChildNodes();
                this.resourceView.Nodes.Add(dirNode);
                
            }
        }
        private bool TryGetTreeNode(string nodeName, out TreeNode node)
        {
            node = null;
            try
            {
                foreach (TreeNode tnode in this.resourceView.Nodes)
                {
                    string name = tnode.ToString().Split(' ').Last();
                    if (name.ToLower() == nodeName.ToLower()) { node = tnode; }
                    return node != null;
                }
            }
            catch {  }
            return node !=null;
        }
        private bool NodeContains(TreeNode node, string fileName)
        {
            foreach (TreeNode tn in node.Nodes)
            {
                //string name = tn.ToString().Split(' ').Last();
                if (tn.ToString().ToLower() == fileName.ToLower()) { return true; }
            }
            return false;
        }
        private int GetNodeIndex(TreeNode node, out TreeNode foundNode)
        {
            int index = -1;
            foundNode = null;
            for (int i = 0; i < this.resourceView.Nodes.Count; i++)
            {
                TreeNode parent = this.resourceView.Nodes[i];
                if (parent.ToString() == node.ToString()) { index = i; foundNode = parent; }
                for (int j = 0; j < parent.Nodes.Count; j++)
                {
                    TreeNode childNode = parent.Nodes[j];
                    if (childNode.ToString() == node.ToString()) { index = j; foundNode = childNode; }
                }
            }
            return index;
        }
        private void Sort()
        {
            for (int i = 0; i < this.resourceView.Nodes.Count; i++)
            {
                this.resourceView.Nodes[i].SortAllChildNodes();
            }
        }
        
        private void resourceView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.resourceView.SelectedNode = e.Node;
                this.nodeMenu.Items[0].Text = string.Format("Extract {0}.", e.Node.Name);
                this.nodeMenu.Show(System.Windows.Forms.Cursor.Position);
            }
                // Stop the icon change of a directory.
                int currentIndex = -1;
                if (e.Node.Tag.ToString() == "Directory") { currentIndex = e.Node.ImageIndex; this.nodeOutput.Text = string.Format("Directory {0} contains {1} entries.", e.Node.Name, e.Node.Nodes.Count); }
                if (currentIndex != -1) { e.Node.SelectedImageIndex = currentIndex; }
                // Get the resource this node represents
                SCI32Resource res = null;
                if (this.ResourceDirectories.TryGetResourceByFilename(e.Node.Name, out res))
                {
                    string fileInfo = string.Format("ID: {0}, at Offset {1} Compressed Length {2}, Uncompressed length {3}, Length {4}, is Compressed ? {5}, Filename: {6}",
                        res.ID, res.Offset, res.CompressedLength, res.UnCompressedLength, res.FileData.Length, res.CompressedLength == res.UnCompressedLength ? "No" : "Yes", res.FileName);
                    this.nodeOutput.Text = fileInfo;
                    this.rtfOutput.Clear();
                    this.rtfOutput.AppendText(Globals.NiceHexOutput(res.FileData));
                    // Show bytes if button selected
                 //   if (toolStripViewHex.Checked)
                   // {
                   //     this.rtfOutput.Clear();
                    //    this.rtfOutput.AppendText(Globals.NiceHexOutput(res.FileData));
                    //}
                }
            
        }
        private void resourceView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = Icons.GetIconIndex(Helpers.Icon.OpenFolder);
        }
        private void resourceView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = Icons.GetIconIndex(Helpers.Icon.ClosedFolder);
        }
        private void resourceView_KeyDown(object sender, KeyEventArgs e)
        {
            TreeNode node = this.resourceView.SelectedNode;
            TreeNodeMouseClickEventArgs args = new TreeNodeMouseClickEventArgs(node, System.Windows.Forms.MouseButtons.Left, 1, 0, 0);
            this.resourceView_NodeMouseClick(node, args);
            
        }
        private void resourceView_KeyUp(object sender, KeyEventArgs e)
        {
            TreeNode node = this.resourceView.SelectedNode;
            TreeNodeMouseClickEventArgs args = new TreeNodeMouseClickEventArgs(node, System.Windows.Forms.MouseButtons.Left, 1, 0, 0);
            this.resourceView_NodeMouseClick(node, args);
        }

        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = this.resourceView.SelectedNode;
            SCI32Resource res = null;
            try
            {
                if (this.ResourceDirectories.TryGetResourceByFilename(node.Name, out res))
                {
                    string ext = SCI32Resource.ExtentionFromResourceType(res.ResourceType);
                    saveFileDialog1.Filter = string.Format("SCI32 {0}|{1}", res.ResourceType, ext);
                    saveFileDialog1.FileName = res.FileName;
                    DialogResult result = saveFileDialog1.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        byte[] file = new byte[res.FileData.Length - 8];
                        Array.Copy(res.FileData, 8, file, 0, file.Length);
                        string _file = Encoding.Default.GetString(file);
                        try
                        {
                            bool compresed = res.CompressedLength != res.UnCompressedLength;
                            if (compresed)
                            {
                                LZWDecoder decoder = new LZWDecoder();
                                string sfile = decoder.Decode(_file);
                                //file = Encoding.ASCII.GetBytes(sfile);
                            }
                            File.WriteAllBytes(saveFileDialog1.FileName, file);
                        }
                        catch (Exception ex) { MessageBox.Show(string.Format("Unable to save file {0}, Error was {1}", res.FileName, ex.Message)); }
                    }
                }
            }
            catch { }
        }
        #endregion
        #region Rtf WriteLines
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
        public static void WriteLine(string message)
        {
            WriteLine(message, Color.Black);
        }
        #endregion

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // test for now
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.Title = "Converting byte arrays to bit arrays.";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                byte[] file = null;
                try { file = File.ReadAllBytes(openFileDialog1.FileName); }
                catch { }
                if (file != null)
                {

                }
            }
             
        }
    }
}
