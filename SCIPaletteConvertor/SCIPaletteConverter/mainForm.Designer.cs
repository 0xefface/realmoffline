namespace SCIPaletteConverter
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
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveAsMicrosoftPalBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsSCIPalBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutBtn = new System.Windows.Forms.ToolStripButton();
            this.copyBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteBtn = new System.Windows.Forms.ToolStripButton();
            this.helpBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.palInfoLbl = new System.Windows.Forms.ToolStripLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.palCntxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyColorValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMicrosoftPalFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsSCIPalFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuZoom1x = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuZoom2x = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.indexHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteControl1 = new SCILib.Controls.PaletteControl();
            this.statusbar.SuspendLayout();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.palCntxtMenu.SuspendLayout();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage});
            this.statusbar.Location = new System.Drawing.Point(0, 448);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(564, 22);
            this.statusbar.TabIndex = 2;
            this.statusbar.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(39, 17);
            this.statusMessage.Text = "Ready";
            // 
            // toolbar
            // 
            this.toolbar.BackgroundImage = global::SCIPaletteConverter.Properties.Resources.TB_BG;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.newBtn,
            this.saveBtn,
            this.saveAsBtn,
            this.printBtn,
            this.toolStripSeparator,
            this.cutBtn,
            this.copyBtn,
            this.pasteBtn,
            this.helpBtn,
            this.toolStripSeparator1,
            this.palInfoLbl});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(564, 25);
            this.toolbar.TabIndex = 3;
            this.toolbar.Text = "toolStrip1";
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(23, 22);
            this.openBtn.Text = "&Open";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newBtn.Enabled = false;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(23, 22);
            this.newBtn.Text = "&New";
            this.newBtn.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(23, 22);
            this.saveBtn.Text = "&Save";
            this.saveBtn.Visible = false;
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsMicrosoftPalBtn,
            this.saveAsSCIPalBtn});
            this.saveAsBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveAsBtn.Image")));
            this.saveAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(29, 22);
            this.saveAsBtn.Text = "Save As...";
            this.saveAsBtn.ToolTipText = "Save current project as...";
            // 
            // saveAsMicrosoftPalBtn
            // 
            this.saveAsMicrosoftPalBtn.Name = "saveAsMicrosoftPalBtn";
            this.saveAsMicrosoftPalBtn.Size = new System.Drawing.Size(152, 22);
            this.saveAsMicrosoftPalBtn.Text = "Microsoft *.pal";
            this.saveAsMicrosoftPalBtn.Click += new System.EventHandler(this.saveAsMicrosoftPalBtn_Click);
            // 
            // saveAsSCIPalBtn
            // 
            this.saveAsSCIPalBtn.Name = "saveAsSCIPalBtn";
            this.saveAsSCIPalBtn.Size = new System.Drawing.Size(152, 22);
            this.saveAsSCIPalBtn.Text = "SCI *.pal";
            this.saveAsSCIPalBtn.Click += new System.EventHandler(this.saveAsSCIPalBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printBtn.Enabled = false;
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(23, 22);
            this.printBtn.Text = "&Print";
            this.printBtn.Visible = false;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator.Visible = false;
            // 
            // cutBtn
            // 
            this.cutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutBtn.Enabled = false;
            this.cutBtn.Image = ((System.Drawing.Image)(resources.GetObject("cutBtn.Image")));
            this.cutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.Size = new System.Drawing.Size(23, 22);
            this.cutBtn.Text = "C&ut";
            this.cutBtn.Visible = false;
            // 
            // copyBtn
            // 
            this.copyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyBtn.Enabled = false;
            this.copyBtn.Image = ((System.Drawing.Image)(resources.GetObject("copyBtn.Image")));
            this.copyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(23, 22);
            this.copyBtn.Text = "&Copy";
            this.copyBtn.Visible = false;
            // 
            // pasteBtn
            // 
            this.pasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteBtn.Enabled = false;
            this.pasteBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteBtn.Image")));
            this.pasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(23, 22);
            this.pasteBtn.Text = "&Paste";
            this.pasteBtn.Visible = false;
            // 
            // helpBtn
            // 
            this.helpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpBtn.Enabled = false;
            this.helpBtn.Image = ((System.Drawing.Image)(resources.GetObject("helpBtn.Image")));
            this.helpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(23, 22);
            this.helpBtn.Text = "He&lp";
            this.helpBtn.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // palInfoLbl
            // 
            this.palInfoLbl.Name = "palInfoLbl";
            this.palInfoLbl.Size = new System.Drawing.Size(67, 22);
            this.palInfoLbl.Text = "Palette Info";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(241, 51);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(320, 313);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.palBox_MouseClick);
            // 
            // palCntxtMenu
            // 
            this.palCntxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyColorValueToolStripMenuItem});
            this.palCntxtMenu.Name = "palCntxtMenu";
            this.palCntxtMenu.Size = new System.Drawing.Size(166, 26);
            // 
            // copyColorValueToolStripMenuItem
            // 
            this.copyColorValueToolStripMenuItem.Name = "copyColorValueToolStripMenuItem";
            this.copyColorValueToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.copyColorValueToolStripMenuItem.Text = "Copy Color Value";
            this.copyColorValueToolStripMenuItem.Click += new System.EventHandler(this.copyColorValueCntxMenu_Click);
            // 
            // menubar
            // 
            this.menubar.BackgroundImage = global::SCIPaletteConverter.Properties.Resources.MenuBG;
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menubar.Size = new System.Drawing.Size(564, 24);
            this.menubar.TabIndex = 1;
            this.menubar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.openFileMenu,
            this.toolStripSeparator2,
            this.saveFileMenu,
            this.toolStripSaveImage,
            this.saveAsFileMenu,
            this.toolStripSeparator3,
            this.printFileMenu,
            this.printPreviewFileMenu,
            this.toolStripSeparator4,
            this.exitFileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newFileMenu
            // 
            this.newFileMenu.Enabled = false;
            this.newFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("newFileMenu.Image")));
            this.newFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileMenu.Name = "newFileMenu";
            this.newFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenu.Size = new System.Drawing.Size(156, 22);
            this.newFileMenu.Text = "&New";
            // 
            // openFileMenu
            // 
            this.openFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("openFileMenu.Image")));
            this.openFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(156, 22);
            this.openFileMenu.Text = "&Open";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Enabled = false;
            this.saveFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("saveFileMenu.Image")));
            this.saveFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(156, 22);
            this.saveFileMenu.Text = "&Save";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenu_Click);
            // 
            // toolStripSaveImage
            // 
            this.toolStripSaveImage.Name = "toolStripSaveImage";
            this.toolStripSaveImage.Size = new System.Drawing.Size(156, 22);
            this.toolStripSaveImage.Text = "Save &Image";
            this.toolStripSaveImage.Click += new System.EventHandler(this.toolStripSaveImage_Click);
            // 
            // saveAsFileMenu
            // 
            this.saveAsFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsMicrosoftPalFileMenu,
            this.saveAsSCIPalFileMenu});
            this.saveAsFileMenu.Name = "saveAsFileMenu";
            this.saveAsFileMenu.Size = new System.Drawing.Size(156, 22);
            this.saveAsFileMenu.Text = "Save &Pallette As";
            // 
            // saveAsMicrosoftPalFileMenu
            // 
            this.saveAsMicrosoftPalFileMenu.Name = "saveAsMicrosoftPalFileMenu";
            this.saveAsMicrosoftPalFileMenu.Size = new System.Drawing.Size(152, 22);
            this.saveAsMicrosoftPalFileMenu.Text = "Microsoft *.pal";
            this.saveAsMicrosoftPalFileMenu.Click += new System.EventHandler(this.saveAsMicrosoftPalFileMenu_Click);
            // 
            // saveAsSCIPalFileMenu
            // 
            this.saveAsSCIPalFileMenu.Name = "saveAsSCIPalFileMenu";
            this.saveAsSCIPalFileMenu.Size = new System.Drawing.Size(152, 22);
            this.saveAsSCIPalFileMenu.Text = "SCI *.pal";
            this.saveAsSCIPalFileMenu.Click += new System.EventHandler(this.saveAsSCIPalFileMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // printFileMenu
            // 
            this.printFileMenu.Enabled = false;
            this.printFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("printFileMenu.Image")));
            this.printFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printFileMenu.Name = "printFileMenu";
            this.printFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printFileMenu.Size = new System.Drawing.Size(156, 22);
            this.printFileMenu.Text = "&Print";
            // 
            // printPreviewFileMenu
            // 
            this.printPreviewFileMenu.Enabled = false;
            this.printPreviewFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewFileMenu.Image")));
            this.printPreviewFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewFileMenu.Name = "printPreviewFileMenu";
            this.printPreviewFileMenu.Size = new System.Drawing.Size(156, 22);
            this.printPreviewFileMenu.Text = "Print Pre&view";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(153, 6);
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(156, 22);
            this.exitFileMenu.Text = "E&xit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoEditMenu,
            this.redoEditMenu,
            this.toolStripSeparator5,
            this.cutEditMenu,
            this.copyEditMenu,
            this.pasteEditMenu,
            this.toolStripSeparator6,
            this.selectAllEditMenu});
            this.editMenu.Enabled = false;
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // undoEditMenu
            // 
            this.undoEditMenu.Enabled = false;
            this.undoEditMenu.Name = "undoEditMenu";
            this.undoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoEditMenu.Size = new System.Drawing.Size(144, 22);
            this.undoEditMenu.Text = "&Undo";
            // 
            // redoEditMenu
            // 
            this.redoEditMenu.Enabled = false;
            this.redoEditMenu.Name = "redoEditMenu";
            this.redoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoEditMenu.Size = new System.Drawing.Size(144, 22);
            this.redoEditMenu.Text = "&Redo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // cutEditMenu
            // 
            this.cutEditMenu.Enabled = false;
            this.cutEditMenu.Image = ((System.Drawing.Image)(resources.GetObject("cutEditMenu.Image")));
            this.cutEditMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutEditMenu.Name = "cutEditMenu";
            this.cutEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutEditMenu.Size = new System.Drawing.Size(144, 22);
            this.cutEditMenu.Text = "Cu&t";
            // 
            // copyEditMenu
            // 
            this.copyEditMenu.Enabled = false;
            this.copyEditMenu.Image = ((System.Drawing.Image)(resources.GetObject("copyEditMenu.Image")));
            this.copyEditMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyEditMenu.Name = "copyEditMenu";
            this.copyEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyEditMenu.Size = new System.Drawing.Size(144, 22);
            this.copyEditMenu.Text = "&Copy";
            // 
            // pasteEditMenu
            // 
            this.pasteEditMenu.Enabled = false;
            this.pasteEditMenu.Image = ((System.Drawing.Image)(resources.GetObject("pasteEditMenu.Image")));
            this.pasteEditMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteEditMenu.Name = "pasteEditMenu";
            this.pasteEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteEditMenu.Size = new System.Drawing.Size(144, 22);
            this.pasteEditMenu.Text = "&Paste";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllEditMenu
            // 
            this.selectAllEditMenu.Enabled = false;
            this.selectAllEditMenu.Name = "selectAllEditMenu";
            this.selectAllEditMenu.Size = new System.Drawing.Size(144, 22);
            this.selectAllEditMenu.Text = "Select &All";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuZoom1x,
            this.viewMenuZoom2x});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // viewMenuZoom1x
            // 
            this.viewMenuZoom1x.CheckOnClick = true;
            this.viewMenuZoom1x.Name = "viewMenuZoom1x";
            this.viewMenuZoom1x.Size = new System.Drawing.Size(120, 22);
            this.viewMenuZoom1x.Text = "Zoom 1x";
            this.viewMenuZoom1x.CheckStateChanged += new System.EventHandler(this.viewMenuZoom1x_CheckStateChanged);
            this.viewMenuZoom1x.Click += new System.EventHandler(this.viewMenuZoom1x_Click);
            // 
            // viewMenuZoom2x
            // 
            this.viewMenuZoom2x.Checked = true;
            this.viewMenuZoom2x.CheckOnClick = true;
            this.viewMenuZoom2x.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewMenuZoom2x.Name = "viewMenuZoom2x";
            this.viewMenuZoom2x.Size = new System.Drawing.Size(120, 22);
            this.viewMenuZoom2x.Text = "Zoom 2x";
            this.viewMenuZoom2x.CheckStateChanged += new System.EventHandler(this.viewMenuZoom2x_CheckStateChanged);
            this.viewMenuZoom2x.Click += new System.EventHandler(this.viewMenuZoom2x_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolsMenu,
            this.optionsToolsMenu});
            this.toolsMenu.Enabled = false;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(47, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // customizeToolsMenu
            // 
            this.customizeToolsMenu.Enabled = false;
            this.customizeToolsMenu.Name = "customizeToolsMenu";
            this.customizeToolsMenu.Size = new System.Drawing.Size(130, 22);
            this.customizeToolsMenu.Text = "&Customize";
            // 
            // optionsToolsMenu
            // 
            this.optionsToolsMenu.Enabled = false;
            this.optionsToolsMenu.Name = "optionsToolsMenu";
            this.optionsToolsMenu.Size = new System.Drawing.Size(130, 22);
            this.optionsToolsMenu.Text = "&Options";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsHelpMenu,
            this.indexHelpMenu,
            this.searchHelpMenu,
            this.toolStripSeparator7,
            this.aboutHelpMenu});
            this.helpMenu.Enabled = false;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsHelpMenu
            // 
            this.contentsHelpMenu.Enabled = false;
            this.contentsHelpMenu.Name = "contentsHelpMenu";
            this.contentsHelpMenu.Size = new System.Drawing.Size(122, 22);
            this.contentsHelpMenu.Text = "&Contents";
            // 
            // indexHelpMenu
            // 
            this.indexHelpMenu.Enabled = false;
            this.indexHelpMenu.Name = "indexHelpMenu";
            this.indexHelpMenu.Size = new System.Drawing.Size(122, 22);
            this.indexHelpMenu.Text = "&Index";
            // 
            // searchHelpMenu
            // 
            this.searchHelpMenu.Enabled = false;
            this.searchHelpMenu.Name = "searchHelpMenu";
            this.searchHelpMenu.Size = new System.Drawing.Size(122, 22);
            this.searchHelpMenu.Text = "&Search";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutHelpMenu
            // 
            this.aboutHelpMenu.Enabled = false;
            this.aboutHelpMenu.Name = "aboutHelpMenu";
            this.aboutHelpMenu.Size = new System.Drawing.Size(122, 22);
            this.aboutHelpMenu.Text = "&About...";
            // 
            // paletteControl1
            // 
            this.paletteControl1.AllowDrop = true;
            this.paletteControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paletteControl1.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Bold);
            this.paletteControl1.CellHeight = 15;
            this.paletteControl1.CellWidth = 15;
            this.paletteControl1.CurrentLoadedType = SCILib.Palettes.PalType.Unknown;
            this.paletteControl1.FontSize = 2F;
            this.paletteControl1.Location = new System.Drawing.Point(0, 51);
            this.paletteControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paletteControl1.Name = "paletteControl1";
            this.paletteControl1.PaletteHeight = 236;
            this.paletteControl1.PaletteRects = ((System.Collections.Generic.Dictionary<System.Drawing.Rectangle, System.Drawing.Color>)(resources.GetObject("paletteControl1.PaletteRects")));
            this.paletteControl1.PaletteWidth = 236;
            this.paletteControl1.Size = new System.Drawing.Size(236, 236);
            this.paletteControl1.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(564, 470);
            this.Controls.Add(this.paletteControl1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.menubar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menubar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(414, 508);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCIPalette Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.palCntxtMenu.ResumeLayout(false);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton newBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton printBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutBtn;
        private System.Windows.Forms.ToolStripButton copyBtn;
        private System.Windows.Forms.ToolStripButton pasteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpBtn;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printFileMenu;
        private System.Windows.Forms.ToolStripMenuItem printPreviewFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoEditMenu;
        private System.Windows.Forms.ToolStripMenuItem redoEditMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutEditMenu;
        private System.Windows.Forms.ToolStripMenuItem copyEditMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteEditMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selectAllEditMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem customizeToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem indexHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem searchHelpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMicrosoftPalFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsSCIPalFileMenu;
        private System.Windows.Forms.ToolStripDropDownButton saveAsBtn;
        private System.Windows.Forms.ToolStripMenuItem saveAsMicrosoftPalBtn;
        private System.Windows.Forms.ToolStripMenuItem saveAsSCIPalBtn;
        private System.Windows.Forms.ToolStripLabel palInfoLbl;
        private System.Windows.Forms.ContextMenuStrip palCntxtMenu;
        private System.Windows.Forms.ToolStripMenuItem copyColorValueToolStripMenuItem;
        private SCILib.Controls.PaletteControl paletteControl1;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenuZoom1x;
        private System.Windows.Forms.ToolStripMenuItem viewMenuZoom2x;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveImage;
    }
}

