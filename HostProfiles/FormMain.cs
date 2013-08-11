using HostProfiles.Properties;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HostProfiles
{
	public partial class FormMain : Form
	{

		#region Properties/Fields;

		String basePath = String.Empty;
		Font baseFont;
		Font boldFont;
		Font italicFont;
		Boolean goodbye = false;

		String RealHosts = "Current Hosts";

		private const String path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";  // HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run
		private const String programName = "HostProfiles";

		private String hosts = ReadHost();

		#endregion Properties/Fields;

		public FormMain()
		{
			InitializeComponent();

			basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar, "Profiles" + Path.DirectorySeparatorChar);
			baseFont = this.Font;
			boldFont = new Font(baseFont, FontStyle.Bold);
			italicFont = new Font(baseFont, FontStyle.Italic);

			fileMainToolStripMenuItem.Text = fileMainToolStripMenuItem.Text.ToUpper();
			toolsMainToolStripMenuItem.Text = toolsMainToolStripMenuItem.Text.ToUpper();
			helpMainToolStripMenuItem.Text = helpMainToolStripMenuItem.Text.ToUpper();

#if LINUX
			autoStartMainToolStripMenuItem.Enabled = false;
#endif
		}

		#region Form;

		private void FormMain_Load(Object sender, EventArgs e)
		{
			if (!Directory.Exists(basePath))
			{
				Directory.CreateDirectory(basePath);
			}

			LoadProfiles();

			RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
			autoStartMainToolStripMenuItem.Checked = key.GetValue(programName) != null;

			minimizeAtStartupToolStripMenuItem.Checked = Settings.Default.minimizeAtStatup;
		}

		private void FormMain_Shown(Object sender, EventArgs e)
		{
			if (Settings.Default.minimizeAtStatup)
			{
				HideShow();
			}
		}

		private void FormMain_FormClosing(Object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = !goodbye;
				HideShow();
			}
			else
			{
				Properties.Settings.Default.Save();
			}
		}

		#endregion Form;

		#region Main ToolStrip;

		private void addProfileToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			String profileName = String.Empty;
			if (ShowInputDialog(Resources.AddProfile_Title, ref profileName) == System.Windows.Forms.DialogResult.OK)
			{
				AddProfile(profileName);
			}
		}

		private void exitMainToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ExitApplication();
		}

		private void autoStartMainToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
			if (!autoStartMainToolStripMenuItem.Checked)
			{
				key.SetValue(programName, "\"" + Application.ExecutablePath.ToString() + "\"");
			}
			else
			{
				key.DeleteValue(programName, false);
			}
			autoStartMainToolStripMenuItem.Checked = !autoStartMainToolStripMenuItem.Checked;
		}

		private void minimizeAtStartupToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			Settings.Default.minimizeAtStatup = minimizeAtStartupToolStripMenuItem.Checked = !minimizeAtStartupToolStripMenuItem.Checked;
		}

		private void flushDnsMainToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ExecuteFlush();
		}

		private void iisresetToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ProcessUtil.Execute(Globals.IISReset, Globals.IISResetArgs);
		}

		private void aboutMainToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ShowAbout();
		}

		#endregion Main ToolStrip;

		#region TreeView;

		private void TreeViewProfiles_AfterSelect(Object sender, TreeViewEventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			String selectedProfile = TreeViewProfiles.SelectedNode.Name;

			if (selectedProfile == RealHosts)
			{
				hosts = ReadHost();
				TextBoxProfile.Text = hosts;
				TextBoxProfile.ReadOnly = true;
			}
			else
			{
				TextBoxProfile.Text = TreeViewProfiles.SelectedNode.Tag.ToString();
				TextBoxProfile.ReadOnly = false;
			}
		}

		private void TreeViewProfiles_MouseDoubleClick(Object sender, MouseEventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			String selectedProfile = TreeViewProfiles.SelectedNode.Name;

			if (selectedProfile == RealHosts) return;

			ApplyProfile(selectedProfile);
		}

		private void TreeViewProfiles_MouseDown(Object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hitTest = TreeViewProfiles.HitTest(e.Location);
				if (hitTest != null && hitTest.Node != null)
				{
					if (hitTest.Node.Name == RealHosts)
					{
						TreeViewProfiles.ContextMenuStrip = profilesRealHostsContextMenuStrip;
					}
					else
					{
						TreeViewProfiles.ContextMenuStrip = profilesContextMenuStrip;
					}
					TreeViewProfiles.SelectedNode = hitTest.Node;
				}
				else
				{
					TreeViewProfiles.ContextMenuStrip = profilesOffContextMenuStrip;
				}
			}
		}

		#endregion TreeView;

		private void TextBoxProfile_TextChanged(Object sender, EventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			TreeNode selectedProfile = TreeViewProfiles.SelectedNode;

			if (selectedProfile.Name == RealHosts) return;

			if (selectedProfile.Tag.ToString() != TextBoxProfile.Text)
			{
				if (selectedProfile.NodeFont == boldFont)
				{
					selectedProfile.Text = selectedProfile.Text.Replace(" *", "") + " *";
				}

				selectedProfile.Tag = TextBoxProfile.Text;
				File.WriteAllText(GetFullPath(selectedProfile.Name), selectedProfile.Tag.ToString());
			}
		}

		#region Systray Menu;

		private void NotifyIconProfiles_MouseDoubleClick(Object sender, MouseEventArgs e)
		{
			HideShow();
		}

		private void showToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			HideShow();
		}

		private void aboutToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ShowAbout();
		}

		private void exitToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ExitApplication();
		}

		private void flushDNSToolStripMenuItemSystem_Click(Object sender, EventArgs e)
		{
			ExecuteFlush();
		}

		private void profileSelectSystrayToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ToolStripMenuItem menu = sender as ToolStripMenuItem;

			TreeViewProfiles.SelectedNode = TreeViewProfiles.Nodes[menu.Name];

			ApplyProfile(menu.Name);
		}

		#endregion Systray Menu;

		#region Context Menu;

		private void newProfileToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			String profileName = String.Empty;
			if (ShowInputDialog(Resources.AddProfile_Title, ref profileName) == System.Windows.Forms.DialogResult.OK)
			{
				AddProfile(profileName);
			}
		}

		private void newProfile2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			String selectedProfile = TreeViewProfiles.SelectedNode.Name;

			if (selectedProfile != RealHosts) return;

			String profileName = "_DEFAULT";
			if (ShowInputDialog(Resources.AddProfile_Title, ref profileName) == System.Windows.Forms.DialogResult.OK)
			{
				hosts = ReadHost();
				AddProfile(profileName, hosts);
			}
		}

		private void applyToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			String selectedProfile = TreeViewProfiles.SelectedNode.Name;

			ApplyProfile(selectedProfile);
		}

		private void duplicateToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			String selectedProfile = TreeViewProfiles.SelectedNode.Name;

			DuplicateProfile(selectedProfile);
		}

		private void renameToolStripMenuItem1_Click(Object sender, EventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			String selectedProfile = TreeViewProfiles.SelectedNode.Name;

			String profileNewName = selectedProfile;
			if (ShowInputDialog(Resources.EditProfile_Title, ref profileNewName) == DialogResult.OK)
			{
				RenameProfile(selectedProfile, profileNewName);
			}
		}

		private void removeToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			if (TreeViewProfiles.SelectedNode == null) return;

			String selectedProfile = TreeViewProfiles.SelectedNode.Name;

			if (MessageBox.Show(String.Format(Resources.DeleteProfile, selectedProfile), Resources.DeletePofile_Title, MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				RemoveProfile(selectedProfile);
			}
		}

		#endregion Context Menu;

		#region Private Methods;

		private String GetFullPath(String name)
		{
			return basePath + name + ".txt";
		}

		private void LoadProfiles()
		{
			TreeViewProfiles.Nodes.Clear();
			switchProfilesToolStripMenuItem.DropDownItems.Clear();

			LoadRealProfile();

			String[] files = Directory.GetFiles(basePath, "*.txt");
			if (files.Length > 0)
			{
				foreach (var file in files)
				{
					LoadProfile(file);
				}
			}
			else
			{
				LoadProfile(DefaultProfile());
			}
		}

		private String DefaultProfile()
		{
			hosts = ReadHost();
			String current = GetFullPath("Current");
			File.WriteAllText(current, hosts);
			return current;
		}

		private void LoadProfile(String file, Boolean clean = false)
		{
			// TreeNode:
			//	Text = file name
			//	Name = file name
			//	Tag = hosts

			// ToolStripMenuItem:
			//	Text = file name
			//	Name = file name

			String profileName = Path.GetFileNameWithoutExtension(file);

			String profileHosts = File.ReadAllText(file);

			Boolean hostProfileFound = !clean && profileHosts == hosts;

			TreeNode profileTreeNode = new TreeNode();
			profileTreeNode.Name = profileName;
			profileTreeNode.Text = profileName;
			profileTreeNode.Tag = profileHosts;

			ToolStripMenuItem profileToolStripItem = new ToolStripMenuItem();
			profileToolStripItem.Name = profileName;
			profileToolStripItem.Text = profileName;
			profileToolStripItem.Click += new EventHandler(profileSelectSystrayToolStripMenuItem_Click);

			if (hostProfileFound)
			{
				profileTreeNode.NodeFont = boldFont;
				profileTreeNode.ImageIndex = profileTreeNode.SelectedImageIndex = 1;
				profileToolStripItem.Font = boldFont;
				profileToolStripItem.Image = profilesImageList.Images[1];

				TextBoxProfile.Text = hosts;
			}
			else
			{
				profileTreeNode.NodeFont = baseFont;
				profileTreeNode.ImageIndex = profileTreeNode.SelectedImageIndex = 0;
				profileToolStripItem.Font = baseFont;
				profileToolStripItem.Image = profilesImageList.Images[0];
			}

			TreeViewProfiles.Nodes.Add(profileTreeNode);

			switchProfilesToolStripMenuItem.DropDownItems.Add(profileToolStripItem);
		}

		private void LoadRealProfile()
		{
			hosts = ReadHost();

			TreeNode profileTreeNode = new TreeNode();
			profileTreeNode.Name = RealHosts;
			profileTreeNode.Text = RealHosts;
			profileTreeNode.Tag = hosts;

			profileTreeNode.NodeFont = italicFont;
			profileTreeNode.ImageIndex = profileTreeNode.SelectedImageIndex = 2;

			TreeViewProfiles.Nodes.Add(profileTreeNode);
		}

		private void AddProfile(String profile, String hosts = "")
		{
			if (String.IsNullOrEmpty(profile)) return;

			try
			{
				String file = GetFullPath(profile);
				if (File.Exists(file))
				{
					MessageBox.Show(Resources.ProfileExists);

					if (ShowInputDialog(Resources.AddProfile_Title, ref profile) == System.Windows.Forms.DialogResult.OK)
					{
						AddProfile(profile, hosts);
					}

					return;
				}
				else
				{
					File.WriteAllText(file, hosts);

					LoadProfile(file, true);

					TreeViewProfiles.SelectedNode = TreeViewProfiles.Nodes[profile];
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		private void ApplyProfile(String profile)
		{
			TreeNode selectedProfile = TreeViewProfiles.Nodes[profile];

			if (selectedProfile.Name == RealHosts) return;

			selectedProfile.Text = selectedProfile.Text.Replace(" *", "");

			foreach (TreeNode profileTreeNode in TreeViewProfiles.Nodes)
			{
				if (profileTreeNode.Name == RealHosts) continue;

				ToolStripItem profileToolStripItem = switchProfilesToolStripMenuItem.DropDownItems[profileTreeNode.Name];
				if (profileTreeNode == selectedProfile)
				{
					profileTreeNode.NodeFont = boldFont;
					profileTreeNode.ImageIndex = profileTreeNode.SelectedImageIndex = 1;
					profileToolStripItem.Font = boldFont;
					profileToolStripItem.Image = profilesImageList.Images[1];
				}
				else
				{
					profileTreeNode.NodeFont = baseFont;
					profileTreeNode.ImageIndex = profileTreeNode.SelectedImageIndex = 0;
					profileToolStripItem.Font = baseFont;
					profileToolStripItem.Image = profilesImageList.Images[0];
				}
			}

			OverrideHostFile(selectedProfile.Tag.ToString());

			ExecuteFlush();
		}

		private void RenameProfile(String profileOld, String profileNew)
		{
			if (String.IsNullOrEmpty(profileNew)) return;

			try
			{
				String fileOld = GetFullPath(profileOld);
				if (File.Exists(fileOld))
				{
					String fileNew = GetFullPath(profileNew);
					if (File.Exists(fileNew))
					{
						MessageBox.Show(Resources.ProfileExists);

						if (ShowInputDialog(Resources.EditProfile_Title, ref profileNew) == DialogResult.OK)
						{
							RenameProfile(profileOld, profileNew);
						}

						return;
					}
					else
					{
						File.Move(fileOld, fileNew);
						File.Delete(fileOld);

						TreeNode profileTreeNode = TreeViewProfiles.Nodes[profileOld];
						profileTreeNode.Text = profileNew;
						profileTreeNode.Name = profileNew;
						TreeViewProfiles.SelectedNode = profileTreeNode;

						ToolStripItem profileToolStripItem = switchProfilesToolStripMenuItem.DropDownItems[profileOld];
						profileToolStripItem.Text = profileNew;
						profileToolStripItem.Name = profileNew;
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		private void RemoveProfile(String profile)
		{
			try
			{
				File.Delete(GetFullPath(profile));

				TreeViewProfiles.Nodes.RemoveByKey(profile);

				switchProfilesToolStripMenuItem.DropDownItems.RemoveByKey(profile);

				if (TreeViewProfiles.Nodes.Count > 0)
				{
					TreeViewProfiles.SelectedNode = TreeViewProfiles.Nodes[TreeViewProfiles.Nodes.Count - 1];
				}
				else
				{
					if (MessageBox.Show(Resources.LoadDefaultProfile, Resources.LoadDefaultProfile_Title, MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						LoadProfile(DefaultProfile());
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		private void DuplicateProfile(String profile)
		{
			if (String.IsNullOrEmpty(profile)) return;

			String profileOld = profile;
			String profileNew = profile;

			try
			{
				String fileOld = GetFullPath(profileOld);
				if (File.Exists(fileOld))
				{
					String fileNew = GetFullPath(profileNew);
					while (File.Exists(fileNew))
					{
						profileNew += " - Copy";
						fileNew = GetFullPath(profileNew);
					}

					File.Copy(fileOld, fileNew);

					LoadProfile(fileNew, true);

					TreeViewProfiles.SelectedNode = TreeViewProfiles.Nodes[profileNew];
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		private static String ReadHost()
		{
			String path = Globals.HostPath;
			if (File.Exists(path))
			{
				return File.ReadAllText(path);
			}
			return String.Empty;
		}

		private Boolean OverrideHostFile(String content)
		{
			String path = Globals.HostPath;
			try
			{
				if (File.Exists(path))
				{
					File.WriteAllText(path, content);
					return true;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			return false;
		}

		private void ExecuteFlush()
		{
			ProgressBar.Value = 0;

			String path = Globals.Flush;
			if (File.Exists(path))
			{
				ProcessUtil.Execute(path, Globals.FlushArgs);
			}

			ProgressBar.Value = 100;
		}

		private void ShowAbout()
		{
			using (FormAbout aboutForm = new FormAbout())
				aboutForm.ShowDialog();
		}

		private void HideShow()
		{
			if (this.Visible)
			{
				this.Hide();
				showToolStripMenuItem.Text = "&Show";
			}
			else
			{
				this.Show();
				showToolStripMenuItem.Text = "&Hide";
			}
		}

		private void ExitApplication()
		{
			goodbye = true;
			Application.Exit();
		}

		private static DialogResult ShowInputDialog(String title, ref String input)
		{
			System.Drawing.Size size = new System.Drawing.Size(200, 70);
			Form inputBoxForm = new Form();

			inputBoxForm.FormBorderStyle = FormBorderStyle.FixedDialog;
			inputBoxForm.ClientSize = size;
			inputBoxForm.Text = title;

			TextBox textBox = new TextBox();
			textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
			textBox.Location = new System.Drawing.Point(5, 5);
			textBox.Text = input;
			inputBoxForm.Controls.Add(textBox);

			Button okButton = new Button();
			okButton.DialogResult = DialogResult.OK;
			okButton.Name = "okButton";
			okButton.Size = new System.Drawing.Size(75, 23);
			okButton.Text = Resources.Ok;
			okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
			okButton.Enabled = textBox.Text.Length > 0;
			inputBoxForm.Controls.Add(okButton);
			inputBoxForm.AcceptButton = okButton;
			textBox.TextChanged += delegate(Object sender, EventArgs e)
			{
				okButton.Enabled = textBox.Text.Length > 0;
			};

			Button cancelButton = new Button();
			cancelButton.DialogResult = DialogResult.Cancel;
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new System.Drawing.Size(75, 23);
			cancelButton.Text = Resources.Cancel;
			cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
			inputBoxForm.Controls.Add(cancelButton);
			inputBoxForm.CancelButton = cancelButton;

			DialogResult result = inputBoxForm.ShowDialog();
			input = textBox.Text;
			return result;
		}

		#endregion Private Methods;

	}
}
