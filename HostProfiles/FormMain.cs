using HostProfiles.Core;
using HostProfiles.Properties;
using Microsoft.Win32;
using System;
using System.ComponentModel;
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
		Boolean goodbye = false;

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
		}

		private void FormMain_FormClosing(Object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = !goodbye;
				HideShow();
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

		private void flushDnsMainToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ExecuteAction(Action.FlushDNS);
		}

		private void iisresetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProcessUtil.Execute("cmd", "/C iisreset /restart");
		}

		private void aboutMainToolStripMenuItem_Click(Object sender, EventArgs e)
		{
			ShowAbout();
		}

		#endregion Main ToolStrip;

		private void tabControlMain_SelectedIndexChanged(Object sender, EventArgs e)
		{
			switch (tabControlMain.SelectedIndex)
			{
				case 1:
					TextBoxHost.Text = ReadHost();
					break;
				case 2:
					ExecuteAction(Action.IPConfig);
					break;
			}
		}

		#region ListView;

		private void ListViewProfiles_SelectedIndexChanged(Object sender, EventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			TextBoxProfile.Text = ListViewProfiles.SelectedItems[0].Tag.ToString();
		}

		private void ListViewProfiles_MouseDoubleClick(Object sender, MouseEventArgs e)
		{
			if (ListViewProfiles.SelectedItems.Count == 0) return;

			String selectedProfile = ListViewProfiles.SelectedItems[0].Name;

			ApplyProfile(selectedProfile);
		}

		#endregion ListView;

		private void TextBoxProfile_TextChanged(Object sender, EventArgs e)
		{
			LabelStatus.Text = "";
			ProgressBar.Value = 0;

			if (ListViewProfiles.SelectedItems.Count == 0) return;

			ListViewItem selectedProfile = ListViewProfiles.SelectedItems[0];

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
			ExecuteAction(Action.FlushDNS);
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

		#region BackgroundWorker;

		private void backgroundWorker_DoWork(Object sender, DoWorkEventArgs e)
		{
			if (e.Argument != null)
			{
				Action action = (Action)e.Argument;
				if (action == Action.FlushDNS)
				{
					Worker(TextBoxMessage, Resources.FlushMessage, false, Env.Flush, Env.FlushArg);
					e.Result = Resources.FlushDNSDone;
				}
				else
				{
					Worker(TextBoxIPs, "{2}", true, Env.Info, Env.InfoArg);
				}
			}
		}

		private void backgroundWorker_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Result != null)
			{
				LabelStatus.Text = e.Result.ToString();
			}
			else
			{
				LabelStatus.Text = "Done";
			}
			profilesContextMenuStrip.Enabled = true;
		}

		private void backgroundWorker_ProgressChanged(Object sender, ProgressChangedEventArgs e)
		{
			ProgressBar.Value = e.ProgressPercentage;
			MessageAction msg = e.UserState as MessageAction;
			if (msg != null)
			{
				if (msg.Flushed)
				{
					msg.TextBox.Text = msg.Message.Trim();
				}
				else
				{
					msg.TextBox.AppendText(msg.Message);
				}
			}
		}

		private void Worker(TextBox callBackTextBox, String callbackMessage, Boolean flushed, String process, String args)
		{
			try
			{
				backgroundWorker.ReportProgress(0);
				String path = ParseProcess(process);
				MessageAction msg = new MessageAction() { Flushed = flushed, TextBox = callBackTextBox };
				String result = String.Empty;
				if (File.Exists(path))
				{
					result = ProcessUtil.Execute(path, args);
				}
				else
				{
					result = String.Format(Resources.CommandNotFound, path, Env.Help);
				}
				msg.Message = String.Format(callbackMessage,
											DateTime.Now,
											Environment.NewLine,
											result,
											Environment.NewLine);
				backgroundWorker.ReportProgress(50, msg);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			backgroundWorker.ReportProgress(100);
		}

		private static String ParseProcess(String process)
		{
#if WIN
			DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.System));
			String path = String.Format(process, di.FullName);
			return path;
#endif
#if LINUX
			return process;		
#endif
		}

		#endregion BackgroundWorker;

		#region Private Methods;

		private String GetFullPath(String name)
		{
			return basePath + name + ".txt";
		}

		private void LoadProfiles()
		{
			ListViewProfiles.Items.Clear();
			switchProfilesToolStripMenuItem.DropDownItems.Clear();
			TextBoxHost.Clear();

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

		private void AddProfile(String profile)
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
						AddProfile(profile);
					}

					return;
				}
				else
				{
					File.WriteAllText(file, String.Empty);

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

			foreach (ListViewItem profileListViewItem in ListViewProfiles.Items)
			{
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

			ExecuteAction(Action.FlushDNS);
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

				TextBoxHost.Text = String.Empty;

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
			String path = ParseProcess(Env.HostPath);
			if (File.Exists(path))
			{
				return File.ReadAllText(path);
			}
			return String.Empty;
		}

		private Boolean OverrideHostFile(String content)
		{
			String path = ParseProcess(Env.HostPath);
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

		private void ExecuteAction(Action action)
		{
			LabelStatus.Text = Resources.Waiting;
			profilesContextMenuStrip.Enabled = false;
			backgroundWorker.RunWorkerAsync(action);
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
