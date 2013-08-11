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
			this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.profilesImageList = new System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
			this.minimizeAtStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.flushDnsMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iisresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.profilesOffContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.profilesRealHostsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newProfile2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ListViewProfiles = new System.Windows.Forms.ListView();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TextBoxProfile = new System.Windows.Forms.TextBox();
			this.profilesContextMenuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.systrayContextMenuStrip.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.profilesOffContextMenuStrip.SuspendLayout();
			this.profilesRealHostsContextMenuStrip.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// profilesContextMenuStrip
			// 
			this.profilesContextMenuStrip.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.profilesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem,
            this.toolStripSeparator3,
            this.duplicateToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.profilesContextMenuStrip.Name = "contextMenuStrip1";
			this.profilesContextMenuStrip.Size = new System.Drawing.Size(221, 98);
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
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
			// 
			// duplicateToolStripMenuItem
			// 
			this.duplicateToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Instance_5746;
			this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
			this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.duplicateToolStripMenuItem.Text = "D&uplicate";
			this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Rename_6779_32;
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.renameToolStripMenuItem.Text = "&Rename";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem1_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.File_exclude_5820;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// newProfileToolStripMenuItem
			// 
			this.newProfileToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.NewFile_6276_24;
			this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
			this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.newProfileToolStripMenuItem.Text = "&New Profile...";
			this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.newProfileToolStripMenuItem_Click);
			// 
			// profilesImageList
			// 
			this.profilesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("profilesImageList.ImageStream")));
			this.profilesImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.profilesImageList.Images.SetKeyName(0, "flag_16xSM.png");
			this.profilesImageList.Images.SetKeyName(1, "flag_16xLG.png");
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar});
			this.statusStrip1.Location = new System.Drawing.Point(660, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(118, 26);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ProgressBar
			// 
			this.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ProgressBar.Margin = new System.Windows.Forms.Padding(1, 3, 0, 3);
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
			this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(0);
			this.mainMenuStrip.Size = new System.Drawing.Size(660, 26);
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
			this.fileMainToolStripMenuItem.Size = new System.Drawing.Size(37, 26);
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
            this.minimizeAtStartupToolStripMenuItem,
            this.toolStripSeparator1,
            this.flushDnsMainToolStripMenuItem,
            this.iisresetToolStripMenuItem});
			this.toolsMainToolStripMenuItem.Name = "toolsMainToolStripMenuItem";
			this.toolsMainToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
			this.toolsMainToolStripMenuItem.Text = "&Tools";
			// 
			// autoStartMainToolStripMenuItem
			// 
			this.autoStartMainToolStripMenuItem.Name = "autoStartMainToolStripMenuItem";
			this.autoStartMainToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.autoStartMainToolStripMenuItem.Text = "&Auto Startup";
			this.autoStartMainToolStripMenuItem.Click += new System.EventHandler(this.autoStartMainToolStripMenuItem_Click);
			// 
			// minimizeAtStartupToolStripMenuItem
			// 
			this.minimizeAtStartupToolStripMenuItem.Name = "minimizeAtStartupToolStripMenuItem";
			this.minimizeAtStartupToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.minimizeAtStartupToolStripMenuItem.Text = "Minimize at Startup";
			this.minimizeAtStartupToolStripMenuItem.Click += new System.EventHandler(this.minimizeAtStartupToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
			// 
			// flushDnsMainToolStripMenuItem
			// 
			this.flushDnsMainToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Event_594_exp;
			this.flushDnsMainToolStripMenuItem.Name = "flushDnsMainToolStripMenuItem";
			this.flushDnsMainToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.flushDnsMainToolStripMenuItem.Text = "&Flush DNS";
			this.flushDnsMainToolStripMenuItem.Click += new System.EventHandler(this.flushDnsMainToolStripMenuItem_Click);
			// 
			// iisresetToolStripMenuItem
			// 
			this.iisresetToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.WebForm_ASPX__815_16x;
			this.iisresetToolStripMenuItem.Name = "iisresetToolStripMenuItem";
			this.iisresetToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.iisresetToolStripMenuItem.Text = "IIS Reset";
			this.iisresetToolStripMenuItem.Click += new System.EventHandler(this.iisresetToolStripMenuItem_Click);
			// 
			// helpMainToolStripMenuItem
			// 
			this.helpMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMainToolStripMenuItem});
			this.helpMainToolStripMenuItem.Name = "helpMainToolStripMenuItem";
			this.helpMainToolStripMenuItem.Size = new System.Drawing.Size(44, 26);
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
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 26);
			this.tableLayoutPanel2.TabIndex = 11;
			// 
			// profilesOffContextMenuStrip
			// 
			this.profilesOffContextMenuStrip.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.profilesOffContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem});
			this.profilesOffContextMenuStrip.Name = "contextMenuStrip1";
			this.profilesOffContextMenuStrip.Size = new System.Drawing.Size(168, 26);
			// 
			// profilesRealHostsContextMenuStrip
			// 
			this.profilesRealHostsContextMenuStrip.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.profilesRealHostsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfile2ToolStripMenuItem});
			this.profilesRealHostsContextMenuStrip.Name = "contextMenuStrip1";
			this.profilesRealHostsContextMenuStrip.Size = new System.Drawing.Size(259, 26);
			// 
			// newProfile2ToolStripMenuItem
			// 
			this.newProfile2ToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Instance_5746;
			this.newProfile2ToolStripMenuItem.Name = "newProfile2ToolStripMenuItem";
			this.newProfile2ToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
			this.newProfile2ToolStripMenuItem.Text = "&Create Profile form here...";
			this.newProfile2ToolStripMenuItem.Click += new System.EventHandler(this.newProfile2ToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(4, 36);
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
			this.splitContainer1.Size = new System.Drawing.Size(776, 322);
			this.splitContainer1.SplitterDistance = 181;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 12;
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
			this.ListViewProfiles.Size = new System.Drawing.Size(181, 322);
			this.ListViewProfiles.SmallImageList = this.profilesImageList;
			this.ListViewProfiles.TabIndex = 0;
			this.ListViewProfiles.UseCompatibleStateImageBehavior = false;
			this.ListViewProfiles.View = System.Windows.Forms.View.Details;
			this.ListViewProfiles.SelectedIndexChanged += new System.EventHandler(this.ListViewProfiles_SelectedIndexChanged);
			this.ListViewProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewProfiles_MouseDoubleClick);
			this.ListViewProfiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListViewProfiles_MouseDown);
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
			this.TextBoxProfile.Size = new System.Drawing.Size(589, 322);
			this.TextBoxProfile.TabIndex = 0;
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
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.profilesContextMenuStrip.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.systrayContextMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.profilesOffContextMenuStrip.ResumeLayout(false);
			this.profilesRealHostsContextMenuStrip.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip profilesContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
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
		private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iisresetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minimizeAtStartupToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip profilesOffContextMenuStrip;
		private System.Windows.Forms.ContextMenuStrip profilesRealHostsContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem newProfile2ToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView ListViewProfiles;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.TextBox TextBoxProfile;
	}
}

