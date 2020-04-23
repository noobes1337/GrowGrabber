using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrowGrabber.Properties;
using Microsoft.Win32;

namespace GrowGrabber
{
	// Token: 0x02000006 RID: 6
	public partial class Form4 : XtraForm
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00006F24 File Offset: 0x00005124
		public Form4()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006F34 File Offset: 0x00005134
		private void Form4_Load(object sender, EventArgs e)
		{
			RegistryKey seria = Registry.CurrentUser.OpenSubKey("GFD", true);
			this.labelControl3.Text = "License Type:" + new WebClient().DownloadString("http://growgrabber.atwebpages.com/SFW/" + seria.GetValue("user").ToString() + "/type.txt");
		}
	}
}
