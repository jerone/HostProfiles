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

		#region ListView;

		private void ListViewProfiles_SelectedIndexChanged(Object sender, EventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

			if (selectedProfile == RealHosts)
			{
				hosts = ReadHost();
				TextBoxProfile.Text = hosts;
				TextBoxProfile.ReadOnly = true;
			}
			else
			{
				TextBoxProfile.Text = ListViewProfiles.SelectedItems[0].Tag.ToString();
				TextBoxProfile.ReadOnly = false;
			}
		}

		private void ListViewProfiles_MouseDoubleClick(Object sender, MouseEventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

			if (selectedProfile == RealHosts) return;

			ApplyProfile(selectedProfile);
		}

		private void ListViewProfiles_MouseDown(Object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hitTest = ListViewProfiles.HitTest(e.Location);
				if (hitTest != null && hitTest.Item != null)
				{
					if (hitTest.Item.Name == RealHosts)
					{
						ListViewProfiles.ContextMenuStrip = profilesRealHostsContextMenuStrip;
					}
					else
					{
						ListViewProfiles.ContextMenuStrip = profilesContextMenuStrip;
					}
				}
				else
				{
					ListViewProfiles.ContextMenuStrip = profilesOffContextMenuStrip;
				}
			}
		}

		#endregion ListView;

		private void TextBoxProfile_TextChanged(Object sender, EventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			ListViewItem selectedProfile = ListViewProfiles.SelectedItems[0];

			if (selectedProfile.Name == RealHosts) return;

			selectedProfile.Tag = TextBoxProfile.Text;
			File.WriteAllText(GetFullPath(selectedProfile.Name), selectedProfile.Tag.ToString());
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

			ListViewProfiles.Items[menu.Name].Selected = true;

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
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

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
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

			ApplyProfile(selectedProfile);
		}

		private void duplicateToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

			DuplicateProfile(selectedProfile);
		}

		private void renameToolStripMenuItem1_Click(Object sender, EventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

			String profileNewName = selectedProfile;
			if (ShowInputDialog(Resources.EditProfile_Title, ref profileNewName) == DialogResult.OK)
			{
				RenameProfile(selectedProfile, profileNewName);
			}
		}

		private void removeToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

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
			ListViewProfiles.Items.Clear();
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
			// ListViewItem:
			//	Text = file name
			//	Name = file name
			//	Tag = hosts

			// ToolStripMenuItem:
			//	Text = file name
			//	Name = file name

			String profileName = Path.GetFileNameWithoutExtension(file);

			String profileHosts = File.ReadAllText(file);

			Boolean hostProfileFound = !clean && profileHosts == hosts;

			ListViewItem profileListViewItem = new ListViewItem();
			profileListViewItem.Name = profileName;
			profileListViewItem.Text = profileName;
			profileListViewItem.Tag = profileHosts;

			ToolStripMenuItem profileToolStripItem = new ToolStripMenuItem();
			profileToolStripItem.Name = profileName;
			profileToolStripItem.Text = profileName;
			profileToolStripItem.Click += new EventHandler(profileSelectSystrayToolStripMenuItem_Click);

			if (hostProfileFound)
			{
				profileListViewItem.Font = boldFont;
				profileListViewItem.ImageIndex = 1;
				profileToolStripItem.Font = boldFont;
				profileToolStripItem.Image = profilesImageList.Images[1];

				TextBoxProfile.Text = hosts;
			}
			else
			{
				profileListViewItem.Font = baseFont;
				profileListViewItem.ImageIndex = 0;
				profileToolStripItem.Font = baseFont;
				profileToolStripItem.Image = profilesImageList.Images[0];
			}

			ListViewProfiles.Items.Add(profileListViewItem);

			switchProfilesToolStripMenuItem.DropDownItems.Add(profileToolStripItem);
		}

		private void LoadRealProfile()
		{
			hosts = ReadHost();

			ListViewItem profileListViewItem = new ListViewItem();
			profileListViewItem.Name = RealHosts;
			profileListViewItem.Text = RealHosts;
			profileListViewItem.Tag = hosts;

			profileListViewItem.Font = italicFont;
			profileListViewItem.ImageIndex = 0;

			ListViewProfiles.Items.Add(profileListViewItem);
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

					ListViewProfiles.Items[profile].Selected = true;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		private void ApplyProfile(String profile)
		{
			ListViewItem selectedProfile = ListViewProfiles.Items[profile];

			if (selectedProfile.Name == RealHosts) return;

			foreach (ListViewItem profileListViewItem in ListViewProfiles.Items)
			{
				if (profileListViewItem.Name == RealHosts) continue;

				ToolStripItem profileToolStripItem = switchProfilesToolStripMenuItem.DropDownItems[profileListViewItem.Name];
				if (profileListViewItem == selectedProfile)
				{
					profileListViewItem.Font = boldFont;
					profileListViewItem.ImageIndex = 1;
					profileToolStripItem.Font = boldFont;
					profileToolStripItem.Image = profilesImageList.Images[1];
				}
				else
				{
					profileListViewItem.Font = baseFont;
					profileListViewItem.ImageIndex = 0;
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

						ListViewItem profileListViewItem = ListViewProfiles.Items[profileOld];
						profileListViewItem.Text = profileNew;
						profileListViewItem.Name = profileNew;
						profileListViewItem.Selected = true;

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

				ListViewProfiles.Items.RemoveByKey(profile);

				switchProfilesToolStripMenuItem.DropDownItems.RemoveByKey(profile);

				if (ListViewProfiles.Items.Count > 0)
				{
					ListViewProfiles.Items[ListViewProfiles.Items.Count - 1].Selected = true;
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

					ListViewProfiles.Items[profileNew].Selected = true;
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
