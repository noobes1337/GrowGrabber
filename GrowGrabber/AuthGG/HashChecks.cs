using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace AuthGG
{
	// Token: 0x02000002 RID: 2
	internal class HashChecks
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void CheckHashes()
		{
			if (HashChecks.GetHash("AUTHGG.dll") != "6F51148DF4AAA7AADC7BEF07F518157E" || HashChecks.GetHash("Outbuilt.dll") != "4DF6C8781E70C3A4912B5BE796E6D337" || HashChecks.GetHash("Newtonsoft.Json.dll") != "4DF6C8781E70C3A4912B5BE796E6D337")
			{
				Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"ECHO AUTHGG.dll and / or Newtonsoft.Json.dll have tampered with! Application closed. && PAUSE\" ")
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
				Process.GetCurrentProcess().Kill();
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020CC File Offset: 0x000002CC
		public static string GetHash(string file)
		{
			string result;
			using (MD5 md5 = MD5.Create())
			{
				using (FileStream stream = File.OpenRead(file))
				{
					byte[] value = md5.ComputeHash(stream);
					BitConverter.ToString(value).Replace("-", "").ToUpperInvariant();
					result = BitConverter.ToString(value).Replace("-", "").ToUpperInvariant();
				}
			}
			return result;
		}
	}
}
