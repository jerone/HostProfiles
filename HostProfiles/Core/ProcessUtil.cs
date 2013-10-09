using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace HostProfiles
{
	public class ProcessUtil
	{
		public String FileName { get; set; }
		public String Arguments { get; set; }
		public String ActionName { get; set; }

		public static void Execute(String process, String args, String actionName)
		{
			BackgroundWorker bgWorker = new BackgroundWorker();
			bgWorker.DoWork += bgWorker_DoWork;
			bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
			bgWorker.RunWorkerAsync(new ProcessUtil { FileName = process, Arguments = args, ActionName = actionName });
		}

		static void bgWorker_DoWork(Object sender, DoWorkEventArgs e)
		{
			try
			{
				ProcessUtil pu = e.Argument as ProcessUtil;
				e.Result = pu.ActionName;

				using (Process p = new Process())
				{
					p.StartInfo = new ProcessStartInfo();
					p.StartInfo.FileName = pu.FileName;
					p.StartInfo.Arguments = pu.Arguments;
					p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					p.StartInfo.RedirectStandardOutput = true;
					p.StartInfo.UseShellExecute = false;
					p.StartInfo.CreateNoWindow = true;
					p.Start();
				}
			}
			catch (Exception)
			{
				e.Cancel = true;
			}
		}

		static void bgWorker_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null || e.Cancelled)
			{
				MessageBox.Show(String.Format("Running '{0}' did NOT complete!", e.Result));
			}
			else
			{
				MessageBox.Show(String.Format("Completed running '{0}'.", e.Result));
			}
		}
	}
}
