using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrowGrabber.Properties;
using Microsoft.Win32;

namespace GrowGrabber
{
	// Token: 0x02000005 RID: 5
	public partial class Form3 : XtraForm
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00006854 File Offset: 0x00004A54
		public Form3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006870 File Offset: 0x00004A70
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			Form5 eula = new Form5();
			if (this.loggedin)
			{
				string cpuInfo = "";
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						cpuInfo = ((ManagementObject)enumerator.Current).Properties["processorID"].Value.ToString();
					}
				}
				bool bye = false;
				if (Registry.GetValue("HKEY_CURRENT_USER\\GFD", "devid", null) == null)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\GFD", "devid", cpuInfo);
					File.AppendAllText("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\id.txt", cpuInfo);
					new WebClient().UploadFile("http://growgrabber.atwebpages.com/SFW/" + this.textEdit1.Text + "/", "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\id.txt");
					File.Delete("id.txt");
					if (!(new WebClient().DownloadString("http://growgrabber.atwebpages.com/SFW/" + this.textEdit1.Text + "/id.txt") == cpuInfo))
					{
						new msgbox
						{
							str1 = "Device ID Error.",
							str2 = "Your device id was blacklisted from our servers please contact\nDevelopers: Hirako#6670 sadMotion#1337"
						}.Show();
						eula.Hide();
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("GFD", true);
						bye = true;
						registryKey.DeleteValue("devid");
						using (RegistryKey regkey = Registry.CurrentUser.OpenSubKey("GFD", true))
						{
							if (regkey.OpenSubKey("GFD") != null)
							{
								regkey.DeleteSubKeyTree("GFD");
							}
						}
					}
				}
				if (!bye)
				{
					string keyName = "HKEY_CURRENT_USER\\GFD";
					string valueName = "eula";
					if (Registry.GetValue(keyName, valueName, null) == null)
					{
						eula.Show();
						Registry.CurrentUser.OpenSubKey("GFD", true).SetValue("eula", "true");
						base.Hide();
					}
					else
					{
						new Form1().Show();
						RegistryKey seria = Registry.CurrentUser.OpenSubKey("GFD", true);
						this.serial = seria.GetValue("user").ToString();
						string key = Encoding.BigEndianUnicode.GetString(Encoding.ASCII.GetBytes(new Random().Next(39999, 99999).ToString()));
						File.WriteAllText(key + ".ini", "true");
						new WebClient().UploadFile("http://growgrabber.atwebpages.com/SFW/" + this.serial + "/", key + ".ini");
						Registry.CurrentUser.OpenSubKey("GFD", true).SetValue("fname", key + ".ini");
						base.Hide();
					}
				}
				base.Hide();
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006B54 File Offset: 0x00004D54
		private void textEdit1_EditValueChanged(object sender, EventArgs e)
		{
			new Form1();
			try
			{
				if (new WebClient().DownloadString(string.Concat(new string[]
				{
					"http://growgrabber.atwebpages.com/SFW/",
					this.textEdit1.Text,
					"/",
					this.textEdit1.Text,
					".txt"
				})) == null)
				{
					this.simpleButton1.Enabled = false;
				}
				else
				{
					this.simpleButton1.Enabled = true;
					Registry.CurrentUser.CreateSubKey("GFD", true);
					Registry.CurrentUser.OpenSubKey("GFD", true).SetValue("user", this.textEdit1.Text);
					this.loggedin = true;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006C20 File Offset: 0x00004E20
		private void Form3_Load(object sender, EventArgs e)
		{
			if (File.Exists("skin.json"))
			{
				base.LookAndFeel.SetSkinStyle(File.ReadAllText("skin.json"));
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006C43 File Offset: 0x00004E43
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/VcPRbfu");
		}

		// Token: 0x0400004F RID: 79
		private bool loggedin;

		// Token: 0x04000050 RID: 80
		private string serial = "";
	}
}
