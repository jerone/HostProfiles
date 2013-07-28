using HostProfiles.Core;
using System;
using System.IO;

namespace HostProfiles
{
	public class Env
	{
		public const string CONFIG = "Config.ini";
		//Default to Win32NT
		public static string Info = "{0}\\ipconfig.exe";
		public static string InfoArg = "/all";
		public static string Flush = "{0}\\ipconfig.exe";
		public static string FlushArg = "/flushdns";
		public static string HostPath = "{0}\\drivers\\etc\\hosts";
		public static string Help = "http://hostprofiles.codeplex.com";

#if LINUX
		/// <summary>
		/// Store Unix sudo password
		/// </summary>
		public static string Password = string.Empty;	
#endif

		public static void Load()
		{
			string platform = Environment.OSVersion.Platform.ToString();
			//Console.WriteLine(Environment.OSVersion);
			//Console.WriteLine(platform);
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CONFIG);
			IniEntity ini = new IniEntity(path);
			Info = ini[platform, "Info"];
			InfoArg = ini[platform, "InfoArg"];
			Flush = ini[platform, "Flush"];
			FlushArg = ini[platform, "FlushArg"];
			HostPath = ini[platform, "HostPath"];
			Help = ini[platform, "Help"];
		}
	}
}
