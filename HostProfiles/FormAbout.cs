using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HostProfiles
{
	public partial class FormAbout : Form
	{
		public FormAbout()
		{
			InitializeComponent();
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LinkLabel l = sender as LinkLabel;
			if (l != null)
			{
				Process.Start(l.Text);
			}
		}
	}
}
