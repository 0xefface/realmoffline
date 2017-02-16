namespace PacketMonitor
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.rtfOutput = new System.Windows.Forms.RichTextBox();
            this.RtfMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewDevices = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveRtfFile = new System.Windows.Forms.SaveFileDialog();
            this.btn_StopSniffing = new System.Windows.Forms.Button();
            this.btn_StartSniffing = new System.Windows.Forms.Button();
            this.btn_ConvertToInt = new System.Windows.Forms.Button();
            this.RtfMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfOutput
            // 
            this.rtfOutput.ContextMenuStrip = this.RtfMenu;
            this.rtfOutput.HideSelection = false;
            this.rtfOutput.Location = new System.Drawing.Point(478, 13);
            this.rtfOutput.Margin = new System.Windows.Forms.Padding(2);
            this.rtfOutput.Name = "rtfOutput";
            this.rtfOutput.Size = new System.Drawing.Size(384, 184);
            this.rtfOutput.TabIndex = 0;
            this.rtfOutput.Text = "";
            // 
            // RtfMenu
            // 
            this.RtfMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.RtfMenu.Name = "RtfMenu";
            this.RtfMenu.Size = new System.Drawing.Size(103, 114);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // listViewDevices
            // 
            this.listViewDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewDevices.FullRowSelect = true;
            this.listViewDevices.GridLines = true;
            this.listViewDevices.Location = new System.Drawing.Point(174, 13);
            this.listViewDevices.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDevices.MultiSelect = false;
            this.listViewDevices.Name = "listViewDevices";
            this.listViewDevices.Size = new System.Drawing.Size(280, 136);
            this.listViewDevices.TabIndex = 1;
            this.listViewDevices.UseCompatibleStateImageBehavior = false;
            this.listViewDevices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Devices";
            this.columnHeader2.Width = 368;
            // 
            // txt_Ip
            // 
            this.txt_Ip.Location = new System.Drawing.Point(11, 38);
            this.txt_Ip.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(145, 20);
            this.txt_Ip.TabIndex = 2;
            this.txt_Ip.Text = "50.247.16.101";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remote Ip Address to Monitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Can monitor more than 1 ip \r\nby adding comma\'s.\r\nEX: 121.34.56.43, 121.35.57.44\r\n" +
    "(Needs Tested)";
            // 
            // saveRtfFile
            // 
            this.saveRtfFile.Filter = "RichText Document|*.rtf";
            // 
            // btn_StopSniffing
            // 
            this.btn_StopSniffing.Location = new System.Drawing.Point(356, 164);
            this.btn_StopSniffing.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StopSniffing.Name = "btn_StopSniffing";
            this.btn_StopSniffing.Size = new System.Drawing.Size(81, 20);
            this.btn_StopSniffing.TabIndex = 5;
            this.btn_StopSniffing.Text = "Stop Sniffing";
            this.btn_StopSniffing.UseVisualStyleBackColor = true;
            this.btn_StopSniffing.Click += new System.EventHandler(this.btn_StopSniffing_Click);
            // 
            // btn_StartSniffing
            // 
            this.btn_StartSniffing.Location = new System.Drawing.Point(188, 164);
            this.btn_StartSniffing.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StartSniffing.Name = "btn_StartSniffing";
            this.btn_StartSniffing.Size = new System.Drawing.Size(81, 20);
            this.btn_StartSniffing.TabIndex = 6;
            this.btn_StartSniffing.Text = "Start Sniffing";
            this.btn_StartSniffing.UseVisualStyleBackColor = true;
            this.btn_StartSniffing.Click += new System.EventHandler(this.btn_StartSniffing_Click);
            // 
            // btn_ConvertToInt
            // 
            this.btn_ConvertToInt.Location = new System.Drawing.Point(25, 164);
            this.btn_ConvertToInt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConvertToInt.Name = "btn_ConvertToInt";
            this.btn_ConvertToInt.Size = new System.Drawing.Size(88, 23);
            this.btn_ConvertToInt.TabIndex = 7;
            this.btn_ConvertToInt.Text = "NetStats";
            this.btn_ConvertToInt.UseVisualStyleBackColor = true;
            this.btn_ConvertToInt.Click += new System.EventHandler(this.btn_ConvertToInt_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 206);
            this.Controls.Add(this.btn_ConvertToInt);
            this.Controls.Add(this.btn_StartSniffing);
            this.Controls.Add(this.btn_StopSniffing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ip);
            this.Controls.Add(this.listViewDevices);
            this.Controls.Add(this.rtfOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packet Monitor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.RtfMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfOutput;
        private System.Windows.Forms.ListView listViewDevices;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip RtfMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveRtfFile;
        private System.Windows.Forms.Button btn_StopSniffing;
        private System.Windows.Forms.Button btn_StartSniffing;
        private System.Windows.Forms.Button btn_ConvertToInt;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

