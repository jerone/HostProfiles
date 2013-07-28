using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HostProfiles.Core
{
	public class IniEntity
	{
		private Dictionary<string, string> dictIni;

		public IniEntity(string path)
		{
			dictIni = Read(path);
		}

		public IniEntity(string path, Encoding encoding)
		{
			dictIni = Read(path, encoding);
		}

		public string this[string key, string subkey]
		{
			get
			{
				return Get(dictIni, key, subkey);
			}
		}


		public const string SPLIT = "_";

		public static Dictionary<string, string> Read(string path, Encoding encoding)
		{
			Dictionary<string, string> dict = new Dictionary<string, string>();

			if (File.Exists(path))
			{
				using (StreamReader sr = new StreamReader(path, encoding))
				{
					string line = sr.ReadLine();
					string key = string.Empty;
					while (line != null)
					{
						line = line.Trim();
						if (!line.StartsWith("#"))
						{
							if (line.StartsWith("["))
							{
								key = line.Substring(1, line.Length - 2).Trim().ToLower();
							}
							else
							{
								#region Read the subkey and value
								int p = line.IndexOf("=");
								if (p > 0)
								{
									string subkey = key + SPLIT + line.Substring(0, p).Trim().ToLower();
									if (p == line.Length - 1)
									{
										dict[subkey] = string.Empty;
									}
									else
									{
										dict[subkey] = line.Substring(p + 1).Trim();
									}
								}
								#endregion
							}
						}

						line = sr.ReadLine();
					}
				}
			}
			return dict;
		}

		public static Dictionary<string, string> Read(string path)
		{
			return Read(path, Encoding.UTF8);
		}

		public static string Get(Dictionary<string, string> ini, string key, string subkey)
		{
			string val = string.Empty;
			if (ini != null && key != null && subkey != null)
			{
				key = key.ToLower() + SPLIT + subkey.ToLower();
				if (!ini.TryGetValue(key, out val))
				{
					val = string.Empty;
				}
			}
			return val;

		}
	}
}
