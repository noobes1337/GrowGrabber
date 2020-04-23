using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrowGrabber.Properties;

namespace GrowGrabber
{
	// Token: 0x02000007 RID: 7
	public partial class Form5 : XtraForm
	{
		// Token: 0x06000043 RID: 67 RVA: 0x000072E7 File Offset: 0x000054E7
		public Form5()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007300 File Offset: 0x00005500
		private void eulacnt_Tick(object sender, EventArgs e)
		{
			this.sayac -= 1;
			if (this.sayac == 0)
			{
				this.checkBox1.Enabled = true;
				this.eulacnt.Stop();
			}
			this.label1.Text = this.sayac.ToString() + " to unlock you should wait and read eula";
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000735B File Offset: 0x0000555B
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.simpleButton1.Enabled = true;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007376 File Offset: 0x00005576
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			new Form1().Show();
			base.Hide();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007388 File Offset: 0x00005588
		private void Form5_Load(object sender, EventArgs e)
		{
			if (File.Exists("skin.json"))
			{
				base.LookAndFeel.SetSkinStyle(File.ReadAllText("skin.json"));
			}
			this.memoEdit1.EditValue = Resources.eula;
		}

		// Token: 0x0400005B RID: 91
		private byte sayac = 30;
	}
}
