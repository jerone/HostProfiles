namespace HostProfiles
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.profilesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.profilesImageList = new System.Windows.Forms.ImageList(this.components);
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.NotifyIconProfiles = new System.Windows.Forms.NotifyIcon(this.components);
			this.systrayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flushDNSToolStripMenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
			this.switchProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoStartMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.flushDnsMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iisresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ListViewProfiles = new System.Windows.Forms.ListView();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TextBoxProfile = new System.Windows.Forms.TextBox();
			this.tabPageCurrent = new System.Windows.Forms.TabPage();
			this.TextBoxHost = new System.Windows.Forms.TextBox();
			this.tabPageIP = new System.Windows.Forms.TabPage();
			this.TextBoxIPs = new System.Windows.Forms.TextBox();
			this.tabPageLastMessage = new System.Windows.Forms.TabPage();
			this.TextBoxMessage = new System.Windows.Forms.TextBox();
			this.profilesContextMenuStrip.SuspendLayout();
			this.systrayContextMenuStrip.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabPageCurrent.SuspendLayout();
			this.tabPageIP.SuspendLayout();
			this.tabPageLastMessage.SuspendLayout();
			this.SuspendLayout();
			// 
			// profilesContextMenuStrip
			// 
			this.profilesContextMenuStrip.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.profilesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.toolStripSeparator3,
            this.applyToolStripMenuItem,
            this.renameToolStripMenuItem1,
            this.deleteToolStripMenuItem});
			this.profilesContextMenuStrip.Name = "contextMenuStrip1";
			this.profilesContextMenuStrip.Size = new System.Drawing.Size(221, 98);
			// 
			// newProfileToolStripMenuItem
			// 
			this.newProfileToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.NewFile_6276_24;
			this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
			this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.newProfileToolStripMenuItem.Text = "&New Profile...";
			this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
			// 
			// applyToolStripMenuItem
			// 
			this.applyToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applyToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Event_594_exp;
			this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
			this.applyToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.applyToolStripMenuItem.Text = "&Apply && Flush DNS";
			this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
			// 
			// renameToolStripMenuItem1
			// 
			this.renameToolStripMenuItem1.Image = global::HostProfiles.Properties.Resources.Rename_6779_32;
			this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
			this.renameToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
			this.renameToolStripMenuItem1.Text = "&Rename";
			this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameToolStripMenuItem1_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.File_exclude_5820;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// profilesImageList
			// 
			this.profilesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("profilesImageList.ImageStream")));
			this.profilesImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.profilesImageList.Images.SetKeyName(0, "flag_16xSM.png");
			this.profilesImageList.Images.SetKeyName(1, "flag_16xLG.png");
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.statusStrip1.Location = new System.Drawing.Point(576, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(202, 26);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// LabelStatus
			// 
			this.LabelStatus.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelStatus.Name = "LabelStatus";
			this.LabelStatus.Size = new System.Drawing.Size(0, 21);
			// 
			// ProgressBar
			// 
			this.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(100, 20);
			// 
			// NotifyIconProfiles
			// 
			this.NotifyIconProfiles.ContextMenuStrip = this.systrayContextMenuStrip;
			this.NotifyIconProfiles.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIconProfiles.Icon")));
			this.NotifyIconProfiles.Text = "Host Profiles";
			this.NotifyIconProfiles.Visible = true;
			this.NotifyIconProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconProfiles_MouseDoubleClick);
			// 
			// systrayContextMenuStrip
			// 
			this.systrayContextMenuStrip.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.systrayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.flushDNSToolStripMenuItemSystem,
            this.switchProfilesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.systrayContextMenuStrip.Name = "contextMenuStripSystem";
			this.systrayContextMenuStrip.Size = new System.Drawing.Size(178, 120);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.showToolStripMenuItem.Text = "&Hide";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// flushDNSToolStripMenuItemSystem
			// 
			this.flushDNSToolStripMenuItemSystem.Name = "flushDNSToolStripMenuItemSystem";
			this.flushDNSToolStripMenuItemSystem.Size = new System.Drawing.Size(177, 22);
			this.flushDNSToolStripMenuItemSystem.Text = "Flush DNS";
			this.flushDNSToolStripMenuItemSystem.Click += new System.EventHandler(this.flushDNSToolStripMenuItemSystem_Click);
			// 
			// switchProfilesToolStripMenuItem
			// 
			this.switchProfilesToolStripMenuItem.Name = "switchProfilesToolStripMenuItem";
			this.switchProfilesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.switchProfilesToolStripMenuItem.Text = "Switch Profiles";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.StatusAnnotations_Help_and_inconclusive_16xMD;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Close_16xLG;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
			this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMainToolStripMenuItem,
            this.toolsMainToolStripMenuItem,
            this.helpMainToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(576, 26);
			this.mainMenuStrip.TabIndex = 9;
			this.mainMenuStrip.Text = "mainMenuStrip";
			// 
			// fileMainToolStripMenuItem
			// 
			this.fileMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProfileToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitMainToolStripMenuItem});
			this.fileMainToolStripMenuItem.Name = "fileMainToolStripMenuItem";
			this.fileMainToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
			this.fileMainToolStripMenuItem.Text = "&File";
			// 
			// addProfileToolStripMenuItem
			// 
			this.addProfileToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.NewFile_6276_24;
			this.addProfileToolStripMenuItem.Name = "addProfileToolStripMenuItem";
			this.addProfileToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.addProfileToolStripMenuItem.Text = "&Add profile...";
			this.addProfileToolStripMenuItem.Click += new System.EventHandler(this.addProfileToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
			// 
			// exitMainToolStripMenuItem
			// 
			this.exitMainToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Close_16xLG;
			this.exitMainToolStripMenuItem.Name = "exitMainToolStripMenuItem";
			this.exitMainToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.exitMainToolStripMenuItem.Text = "&Exit";
			this.exitMainToolStripMenuItem.Click += new System.EventHandler(this.exitMainToolStripMenuItem_Click);
			// 
			// toolsMainToolStripMenuItem
			// 
			this.toolsMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoStartMainToolStripMenuItem,
            this.toolStripSeparator1,
            this.flushDnsMainToolStripMenuItem,
            this.iisresetToolStripMenuItem});
			this.toolsMainToolStripMenuItem.Name = "toolsMainToolStripMenuItem";
			this.toolsMainToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
			this.toolsMainToolStripMenuItem.Text = "&Tools";
			// 
			// autoStartMainToolStripMenuItem
			// 
			this.autoStartMainToolStripMenuItem.Name = "autoStartMainToolStripMenuItem";
			this.autoStartMainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.autoStartMainToolStripMenuItem.Text = "&Auto Startup";
			this.autoStartMainToolStripMenuItem.Click += new System.EventHandler(this.autoStartMainToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// flushDnsMainToolStripMenuItem
			// 
			this.flushDnsMainToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Event_594_exp;
			this.flushDnsMainToolStripMenuItem.Name = "flushDnsMainToolStripMenuItem";
			this.flushDnsMainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.flushDnsMainToolStripMenuItem.Text = "&Flush DNS";
			this.flushDnsMainToolStripMenuItem.Click += new System.EventHandler(this.flushDnsMainToolStripMenuItem_Click);
			// 
			// iisresetToolStripMenuItem
			// 
			this.iisresetToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.WebForm_ASPX__815_16x;
			this.iisresetToolStripMenuItem.Name = "iisresetToolStripMenuItem";
			this.iisresetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.iisresetToolStripMenuItem.Text = "IIS Reset";
			this.iisresetToolStripMenuItem.Click += new System.EventHandler(this.iisresetToolStripMenuItem_Click);
			// 
			// helpMainToolStripMenuItem
			// 
			this.helpMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMainToolStripMenuItem});
			this.helpMainToolStripMenuItem.Name = "helpMainToolStripMenuItem";
			this.helpMainToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
			this.helpMainToolStripMenuItem.Text = "&Help";
			// 
			// aboutMainToolStripMenuItem
			// 
			this.aboutMainToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.StatusAnnotations_Help_and_inconclusive_16xMD;
			this.aboutMainToolStripMenuItem.Name = "aboutMainToolStripMenuItem";
			this.aboutMainToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutMainToolStripMenuItem.Text = "&About";
			this.aboutMainToolStripMenuItem.Click += new System.EventHandler(this.aboutMainToolStripMenuItem_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tabControlMain, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 362);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.mainMenuStrip);
			this.tableLayoutPanel2.Controls.Add(this.statusStrip1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 26);
			this.tableLayoutPanel2.TabIndex = 11;
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPage1);
			this.tabControlMain.Controls.Add(this.tabPageCurrent);
			this.tabControlMain.Controls.Add(this.tabPageIP);
			this.tabControlMain.Controls.Add(this.tabPageLastMessage);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(4, 36);
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(776, 322);
			this.tabControlMain.TabIndex = 1;
			this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(768, 292);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Host Profiles";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(4, 4);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ListViewProfiles);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.TextBoxProfile);
			this.splitContainer1.Size = new System.Drawing.Size(760, 284);
			this.splitContainer1.SplitterDistance = 178;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 1;
			// 
			// ListViewProfiles
			// 
			this.ListViewProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
			this.ListViewProfiles.ContextMenuStrip = this.profilesContextMenuStrip;
			this.ListViewProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListViewProfiles.FullRowSelect = true;
			this.ListViewProfiles.GridLines = true;
			this.ListViewProfiles.HideSelection = false;
			this.ListViewProfiles.Location = new System.Drawing.Point(0, 0);
			this.ListViewProfiles.Margin = new System.Windows.Forms.Padding(4);
			this.ListViewProfiles.MultiSelect = false;
			this.ListViewProfiles.Name = "ListViewProfiles";
			this.ListViewProfiles.Size = new System.Drawing.Size(178, 284);
			this.ListViewProfiles.SmallImageList = this.profilesImageList;
			this.ListViewProfiles.TabIndex = 0;
			this.ListViewProfiles.UseCompatibleStateImageBehavior = false;
			this.ListViewProfiles.View = System.Windows.Forms.View.Details;
			this.ListViewProfiles.SelectedIndexChanged += new System.EventHandler(this.ListViewProfiles_SelectedIndexChanged);
			this.ListViewProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewProfiles_MouseDoubleClick);
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Name";
			this.columnHeaderName.Width = 150;
			// 
			// TextBoxProfile
			// 
			this.TextBoxProfile.AcceptsReturn = true;
			this.TextBoxProfile.AcceptsTab = true;
			this.TextBoxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxProfile.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.TextBoxProfile.Location = new System.Drawing.Point(0, 0);
			this.TextBoxProfile.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxProfile.Multiline = true;
			this.TextBoxProfile.Name = "TextBoxProfile";
			this.TextBoxProfile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxProfile.Size = new System.Drawing.Size(576, 284);
			this.TextBoxProfile.TabIndex = 0;
			this.TextBoxProfile.TextChanged += new System.EventHandler(this.TextBoxProfile_TextChanged);
			// 
			// tabPageCurrent
			// 
			this.tabPageCurrent.Controls.Add(this.TextBoxHost);
			this.tabPageCurrent.Location = new System.Drawing.Point(4, 26);
			this.tabPageCurrent.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageCurrent.Name = "tabPageCurrent";
			this.tabPageCurrent.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageCurrent.Size = new System.Drawing.Size(768, 292);
			this.tabPageCurrent.TabIndex = 1;
			this.tabPageCurrent.Text = "View Current Host";
			this.tabPageCurrent.UseVisualStyleBackColor = true;
			// 
			// TextBoxHost
			// 
			this.TextBoxHost.BackColor = System.Drawing.SystemColors.Window;
			this.TextBoxHost.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxHost.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.TextBoxHost.Location = new System.Drawing.Point(4, 4);
			this.TextBoxHost.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxHost.Multiline = true;
			this.TextBoxHost.Name = "TextBoxHost";
			this.TextBoxHost.ReadOnly = true;
			this.TextBoxHost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxHost.Size = new System.Drawing.Size(760, 284);
			this.TextBoxHost.TabIndex = 1;
			// 
			// tabPageIP
			// 
			this.tabPageIP.Controls.Add(this.TextBoxIPs);
			this.tabPageIP.Location = new System.Drawing.Point(4, 26);
			this.tabPageIP.Name = "tabPageIP";
			this.tabPageIP.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageIP.Size = new System.Drawing.Size(768, 292);
			this.tabPageIP.TabIndex = 2;
			this.tabPageIP.Text = "Network Info";
			this.tabPageIP.UseVisualStyleBackColor = true;
			// 
			// TextBoxIPs
			// 
			this.TextBoxIPs.BackColor = System.Drawing.SystemColors.Window;
			this.TextBoxIPs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxIPs.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.TextBoxIPs.Location = new System.Drawing.Point(3, 3);
			this.TextBoxIPs.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxIPs.Multiline = true;
			this.TextBoxIPs.Name = "TextBoxIPs";
			this.TextBoxIPs.ReadOnly = true;
			this.TextBoxIPs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxIPs.Size = new System.Drawing.Size(762, 286);
			this.TextBoxIPs.TabIndex = 2;
			// 
			// tabPageLastMessage
			// 
			this.tabPageLastMessage.Controls.Add(this.TextBoxMessage);
			this.tabPageLastMessage.Location = new System.Drawing.Point(4, 26);
			this.tabPageLastMessage.Name = "tabPageLastMessage";
			this.tabPageLastMessage.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLastMessage.Size = new System.Drawing.Size(768, 292);
			this.tabPageLastMessage.TabIndex = 3;
			this.tabPageLastMessage.Text = "Messages";
			this.tabPageLastMessage.UseVisualStyleBackColor = true;
			// 
			// TextBoxMessage
			// 
			this.TextBoxMessage.BackColor = System.Drawing.SystemColors.Window;
			this.TextBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxMessage.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.TextBoxMessage.Location = new System.Drawing.Point(3, 3);
			this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxMessage.Multiline = true;
			this.TextBoxMessage.Name = "TextBoxMessage";
			this.TextBoxMessage.ReadOnly = true;
			this.TextBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBoxMessage.Size = new System.Drawing.Size(762, 286);
			this.TextBoxMessage.TabIndex = 2;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 362);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(500, 350);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Host Profiles Management";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.profilesContextMenuStrip.ResumeLayout(false);
			this.systrayContextMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tabPageCurrent.ResumeLayout(false);
			this.tabPageCurrent.PerformLayout();
			this.tabPageIP.ResumeLayout(false);
			this.tabPageIP.PerformLayout();
			this.tabPageLastMessage.ResumeLayout(false);
			this.tabPageLastMessage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip profilesContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel LabelStatus;
		private System.Windows.Forms.ToolStripProgressBar ProgressBar;
		private System.Windows.Forms.NotifyIcon NotifyIconProfiles;
		private System.Windows.Forms.ContextMenuStrip systrayContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem switchProfilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ImageList profilesImageList;
		private System.Windows.Forms.ToolStripMenuItem flushDNSToolStripMenuItemSystem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutMainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsMainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileMainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flushDnsMainToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem addProfileToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem autoStartMainToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView ListViewProfiles;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.TextBox TextBoxProfile;
		private System.Windows.Forms.TabPage tabPageCurrent;
		private System.Windows.Forms.TextBox TextBoxHost;
		private System.Windows.Forms.TabPage tabPageIP;
		private System.Windows.Forms.TextBox TextBoxIPs;
		private System.Windows.Forms.TabPage tabPageLastMessage;
		private System.Windows.Forms.TextBox TextBoxMessage;
		private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem iisresetToolStripMenuItem;
	}
}

