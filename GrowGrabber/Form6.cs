using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GrowGrabber.Properties;

namespace GrowGrabber
{
	// Token: 0x02000008 RID: 8
	public partial class Form6 : XtraForm
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00007772 File Offset: 0x00005972
		public Form6()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00007780 File Offset: 0x00005980
		private void Form6_Load(object sender, EventArgs e)
		{
			this.memoEdit1.EditValue = Resources.eula;
		}
	}
}
