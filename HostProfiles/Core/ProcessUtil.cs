using System;
using System.Diagnostics;
using System.IO;

namespace HostProfiles
{
	public class ProcessUtil
	{
		public static String Execute(String process, String args)
		{
			String rtrn = String.Empty;
			using (Process p = new Process())
			{
				p.StartInfo = new ProcessStartInfo();
				p.StartInfo.FileName = process;
				p.StartInfo.Arguments = args;
				p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.UseShellExecute = false;
				//p.StartInfo.CreateNoWindow = true;
				p.Start();
				rtrn = p.StandardOutput.ReadToEnd();
			}
			return rtrn;
		}
	}
}
