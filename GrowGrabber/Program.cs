using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GrowGrabber
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00008150 File Offset: 0x00006350
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			RegistryKey keys = Registry.CurrentUser.OpenSubKey("GFD", true);
			try
			{
				string keyName = "HKEY_CURRENT_USER\\GFD";
				string valueName = "fname";
				if (Registry.GetValue(keyName, valueName, null) == null)
				{
					Application.Run(new Form3());
				}
				else
				{
					string serial = Registry.CurrentUser.OpenSubKey("GFD", true).GetValue("user").ToString();
					if (new WebClient().DownloadString("http://growgrabber.atwebpages.com/SFW/" + serial + "/" + keys.GetValue("fname").ToString()).Contains("true"))
					{
						new Form1().StartPosition = FormStartPosition.CenterScreen;
						Application.Run(new Form1());
					}
					else
					{
						keys.SetValue("fname", "");
					}
				}
			}
			catch
			{
				Application.Run(new Form3());
			}
		}

		// Token: 0x04000075 RID: 117
		public static string kesy = "";
	}
}
