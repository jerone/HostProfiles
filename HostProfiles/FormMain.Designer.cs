﻿namespace HostProfiles
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TreeViewProfiles = new System.Windows.Forms.TreeView();
			this.HostsDataGridView = new System.Windows.Forms.DataGridView();
			this.LineIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EnabledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IPAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DomainNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TextBoxProfile = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.HostsViewSubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ApplySubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MessageToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.profilesOffContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.profilesRealHostsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newProfile2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.profilesContextMenuStrip.SuspendLayout();
			this.systrayContextMenuStrip.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HostsDataGridView)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.profilesOffContextMenuStrip.SuspendLayout();
			this.profilesRealHostsContextMenuStrip.SuspendLayout();
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
			this.profilesContextMenuStrip.Size = new System.Drawing.Size(141, 98);
			// 
			// applyToolStripMenuItem
			// 
			this.applyToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applyToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Event_594_exp;
			this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
			this.applyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.applyToolStripMenuItem.Text = "&Apply";
			this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
			// 
			// duplicateToolStripMenuItem
			// 
			this.duplicateToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Instance_5746;
			this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
			this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.duplicateToolStripMenuItem.Text = "D&uplicate";
			this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Rename_6779_32;
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.renameToolStripMenuItem.Text = "&Rename";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem1_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.File_exclude_5820;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
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
			this.profilesImageList.Images.SetKeyName(0, "flag_16xMD.png");
			this.profilesImageList.Images.SetKeyName(1, "flag_16xLG.png");
			this.profilesImageList.Images.SetKeyName(2, "FlagThread-Flagged,NotHot,NotSelected_10392_16x small.png");
			this.profilesImageList.Images.SetKeyName(3, "FlagThread-Flagged,NotHot,NotSelected_10392_16x.png");
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
			this.mainMenuStrip.Size = new System.Drawing.Size(574, 24);
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
			this.fileMainToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
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
			this.toolsMainToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
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
			this.helpMainToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
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
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 32);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.TreeViewProfiles);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.HostsDataGridView);
			this.splitContainer1.Panel2.Controls.Add(this.TextBoxProfile);
			this.splitContainer1.Size = new System.Drawing.Size(778, 327);
			this.splitContainer1.SplitterDistance = 170;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 12;
			// 
			// TreeViewProfiles
			// 
			this.TreeViewProfiles.ContextMenuStrip = this.profilesContextMenuStrip;
			this.TreeViewProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TreeViewProfiles.FullRowSelect = true;
			this.TreeViewProfiles.HideSelection = false;
			this.TreeViewProfiles.ImageIndex = 0;
			this.TreeViewProfiles.ImageList = this.profilesImageList;
			this.TreeViewProfiles.Location = new System.Drawing.Point(0, 0);
			this.TreeViewProfiles.Margin = new System.Windows.Forms.Padding(4);
			this.TreeViewProfiles.Name = "TreeViewProfiles";
			this.TreeViewProfiles.SelectedImageIndex = 0;
			this.TreeViewProfiles.ShowPlusMinus = false;
			this.TreeViewProfiles.Size = new System.Drawing.Size(170, 327);
			this.TreeViewProfiles.TabIndex = 0;
			this.TreeViewProfiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewProfiles_AfterSelect);
			this.TreeViewProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TreeViewProfiles_MouseDoubleClick);
			this.TreeViewProfiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewProfiles_MouseDown);
			// 
			// HostsDataGridView
			// 
			this.HostsDataGridView.AllowUserToAddRows = false;
			this.HostsDataGridView.AllowUserToDeleteRows = false;
			this.HostsDataGridView.AllowUserToOrderColumns = true;
			this.HostsDataGridView.AllowUserToResizeRows = false;
			this.HostsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HostsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.HostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.HostsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineIndexColumn,
            this.EnabledColumn,
            this.IPAddressColumn,
            this.DomainNameColumn,
            this.CommentColumn});
			this.HostsDataGridView.Location = new System.Drawing.Point(4, 224);
			this.HostsDataGridView.MultiSelect = false;
			this.HostsDataGridView.Name = "HostsDataGridView";
			this.HostsDataGridView.ReadOnly = true;
			this.HostsDataGridView.RowHeadersVisible = false;
			this.HostsDataGridView.Size = new System.Drawing.Size(594, 100);
			this.HostsDataGridView.TabIndex = 1;
			// 
			// LineIndexColumn
			// 
			this.LineIndexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.LineIndexColumn.DataPropertyName = "LineIndex";
			this.LineIndexColumn.HeaderText = "No.";
			this.LineIndexColumn.Name = "LineIndexColumn";
			this.LineIndexColumn.ReadOnly = true;
			this.LineIndexColumn.ToolTipText = "Line number";
			this.LineIndexColumn.Width = 57;
			// 
			// EnabledColumn
			// 
			this.EnabledColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.EnabledColumn.DataPropertyName = "Enabled";
			this.EnabledColumn.HeaderText = "";
			this.EnabledColumn.MinimumWidth = 24;
			this.EnabledColumn.Name = "EnabledColumn";
			this.EnabledColumn.ReadOnly = true;
			this.EnabledColumn.ToolTipText = "Active";
			this.EnabledColumn.Width = 24;
			// 
			// IPAddressColumn
			// 
			this.IPAddressColumn.DataPropertyName = "IPAddress";
			this.IPAddressColumn.HeaderText = "IP Address";
			this.IPAddressColumn.Name = "IPAddressColumn";
			this.IPAddressColumn.ReadOnly = true;
			// 
			// DomainNameColumn
			// 
			this.DomainNameColumn.DataPropertyName = "DomainName";
			this.DomainNameColumn.HeaderText = "Domain Name";
			this.DomainNameColumn.Name = "DomainNameColumn";
			this.DomainNameColumn.ReadOnly = true;
			// 
			// CommentColumn
			// 
			this.CommentColumn.DataPropertyName = "Comment";
			this.CommentColumn.HeaderText = "Comment";
			this.CommentColumn.Name = "CommentColumn";
			this.CommentColumn.ReadOnly = true;
			// 
			// TextBoxProfile
			// 
			this.TextBoxProfile.AcceptsReturn = true;
			this.TextBoxProfile.AcceptsTab = true;
			this.TextBoxProfile.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.TextBoxProfile.Location = new System.Drawing.Point(4, 4);
			this.TextBoxProfile.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxProfile.Multiline = true;
			this.TextBoxProfile.Name = "TextBoxProfile";
			this.TextBoxProfile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBoxProfile.Size = new System.Drawing.Size(594, 213);
			this.TextBoxProfile.TabIndex = 0;
			this.TextBoxProfile.WordWrap = false;
			this.TextBoxProfile.TextChanged += new System.EventHandler(this.TextBoxProfile_TextChanged);
			this.TextBoxProfile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxProfile_KeyDown);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.mainMenuStrip);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 26);
			this.tableLayoutPanel2.TabIndex = 11;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HostsViewSubToolStripMenuItem,
            this.ApplySubToolStripMenuItem,
            this.MessageToolStripTextBox});
			this.menuStrip1.Location = new System.Drawing.Point(574, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(204, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// HostsViewSubToolStripMenuItem
			// 
			this.HostsViewSubToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.HostsViewSubToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.table_16xLG;
			this.HostsViewSubToolStripMenuItem.Name = "HostsViewSubToolStripMenuItem";
			this.HostsViewSubToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
			this.HostsViewSubToolStripMenuItem.ToolTipText = "Show as grid";
			this.HostsViewSubToolStripMenuItem.Click += new System.EventHandler(this.HostsViewSubToolStripMenuItem_Click);
			// 
			// ApplySubToolStripMenuItem
			// 
			this.ApplySubToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ApplySubToolStripMenuItem.Enabled = false;
			this.ApplySubToolStripMenuItem.Image = global::HostProfiles.Properties.Resources.Event_594_exp;
			this.ApplySubToolStripMenuItem.Name = "ApplySubToolStripMenuItem";
			this.ApplySubToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.ApplySubToolStripMenuItem.Text = "&Apply";
			this.ApplySubToolStripMenuItem.Click += new System.EventHandler(this.ApplySubToolStripMenuItem_Click);
			// 
			// MessageToolStripTextBox
			// 
			this.MessageToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.MessageToolStripTextBox.BackColor = System.Drawing.SystemColors.Menu;
			this.MessageToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MessageToolStripTextBox.Name = "MessageToolStripTextBox";
			this.MessageToolStripTextBox.Size = new System.Drawing.Size(100, 20);
			this.MessageToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.systrayContextMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.HostsDataGridView)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.profilesOffContextMenuStrip.ResumeLayout(false);
			this.profilesRealHostsContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip profilesContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
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
		private System.Windows.Forms.TreeView TreeViewProfiles;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.TextBox TextBoxProfile;
		private System.Windows.Forms.DataGridView HostsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn LineIndexColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn EnabledColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn IPAddressColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DomainNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem HostsViewSubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ApplySubToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox MessageToolStripTextBox;
	}
}

