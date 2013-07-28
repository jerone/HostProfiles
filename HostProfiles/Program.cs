using HostProfiles.Properties;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HostProfiles
{
	static class Program
	{
#if LINUX
		[DllImport ("libc")]
		public static extern uint getuid ();
#endif

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
#if WIN
			Boolean bMutexCreated = false;
			Mutex mutexMain = new Mutex(true, "my-host-profiles", out bMutexCreated);

			if (!bMutexCreated)
			{
				MessageBox.Show(Resources.AlreadyRunning, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
				return;
			}
#endif

#if LINUX
			if (getuid() != 0) 
			{
				MessageBox.Show("Please launch the program with sudo command!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
				return;
			}
#endif
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Env.Load();
			Application.Run(new FormMain());
		}
	}
}
