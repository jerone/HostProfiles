using System;

namespace HostProfiles
{
	public class Globals
	{
		public static String HostPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";

		public static String Flush = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\ipconfig.exe";
		public static String FlushArgs = "/flushdns";

		public static String IISReset = "cmd";
		public static String IISResetArgs = "/C iisreset /restart";
	}
}
