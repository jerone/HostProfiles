using System.IO;

namespace HostProfiles
{
	public class ProcessUtil
	{
		public static string Execute(string process, string arges)
		{
			string str = string.Empty;
			using (System.Diagnostics.Process p = new System.Diagnostics.Process())
			{
				p.StartInfo = new System.Diagnostics.ProcessStartInfo();
				p.StartInfo.FileName = process;
				p.StartInfo.Arguments = arges;
				p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.CreateNoWindow = true;//让窗体不显示
				p.Start();
				StreamReader reader = p.StandardOutput;//截取输出流

				str = reader.ReadToEnd();//获得的结果

				//StreamWriter writer = p.StandardInput;
				//writer.Write("asdf");
				//writer.Write(Environment.NewLine);  				
				//Console.WriteLine(p.StandardError.ReadToEnd());
			}
			return str;
		}


	}
}
