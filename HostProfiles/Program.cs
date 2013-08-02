using HostProfiles.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HostProfiles
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			String[] args = Environment.GetCommandLineArgs();
			SingleInstanceController controller = new SingleInstanceController();
			controller.Run(args);
		}
	}


	public class SingleInstanceController : WindowsFormsApplicationBase
	{
		public SingleInstanceController()
		{
			// Set whether the application is single instance
			this.IsSingleInstance = true;

			this.StartupNextInstance += new StartupNextInstanceEventHandler(this_StartupNextInstance);
		}

		void this_StartupNextInstance(Object sender, StartupNextInstanceEventArgs e)
		{
			// Here you get the control when any other instance is
			// invoked apart from the first one.
			// You have args here in e.CommandLine.

			// You custom code which should be run on other instances
			this.MainForm.Show();
		}

		protected override void OnCreateMainForm()
		{
			// Instantiate your main application form
			Env.Load();
			this.MainForm = new FormMain();
		}
	}
}
