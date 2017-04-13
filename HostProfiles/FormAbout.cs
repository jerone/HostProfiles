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

		private void ButtonOK_Click(Object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void linkLabel_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
		{
			LinkLabel link = sender as LinkLabel;
			if (link != null)
			{
				Process.Start(link.Text);
			}
		}
	}
}
