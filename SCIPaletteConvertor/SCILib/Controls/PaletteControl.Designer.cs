namespace SCILib.Controls
{
    partial class PaletteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paletteBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.paletteBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paletteBox
            // 
            this.paletteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paletteBox.ContextMenuStrip = this.contextMenuStrip1;
            this.paletteBox.Location = new System.Drawing.Point(0, 12);
            this.paletteBox.Name = "paletteBox";
            this.paletteBox.Size = new System.Drawing.Size(321, 279);
            this.paletteBox.TabIndex = 0;
            this.paletteBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPaletteToolStripMenuItem,
            this.exportPaletteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 52);
            // 
            // importPaletteToolStripMenuItem
            // 
            this.importPaletteToolStripMenuItem.Name = "importPaletteToolStripMenuItem";
            this.importPaletteToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.importPaletteToolStripMenuItem.Text = "Import Palette";
            this.importPaletteToolStripMenuItem.Click += new System.EventHandler(this.importPaletteToolStripMenuItem_Click);
            // 
            // exportPaletteToolStripMenuItem
            // 
            this.exportPaletteToolStripMenuItem.Name = "exportPaletteToolStripMenuItem";
            this.exportPaletteToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.exportPaletteToolStripMenuItem.Text = "Export Palette";
            this.exportPaletteToolStripMenuItem.Click += new System.EventHandler(this.exportPaletteToolStripMenuItem_Click);
            // 
            // PaletteControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.paletteBox);
            this.Name = "PaletteControl";
            this.Size = new System.Drawing.Size(459, 361);
            ((System.ComponentModel.ISupportInitialize)(this.paletteBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox paletteBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importPaletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPaletteToolStripMenuItem;
    }
}
