namespace GrowGrabber
{
	// Token: 0x02000008 RID: 8
	public partial class Form6 : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00007792 File Offset: 0x00005992
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000077B4 File Offset: 0x000059B4
		private void InitializeComponent()
		{
			this.memoEdit1 = new global::DevExpress.XtraEditors.MemoEdit();
			((global::System.ComponentModel.ISupportInitialize)this.memoEdit1.Properties).BeginInit();
			base.SuspendLayout();
			this.memoEdit1.Location = new global::System.Drawing.Point(0, 1);
			this.memoEdit1.Name = "memoEdit1";
			this.memoEdit1.Size = new global::System.Drawing.Size(638, 385);
			this.memoEdit1.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(636, 387);
			base.Controls.Add(this.memoEdit1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.IconOptions.Image = global::GrowGrabber.Properties.Resources.snowflake_52_128;
			base.MaximizeBox = false;
			base.Name = "Form6";
			this.Text = "GrowGrabber - End User License";
			base.Load += new global::System.EventHandler(this.Form6_Load);
			((global::System.ComponentModel.ISupportInitialize)this.memoEdit1.Properties).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000063 RID: 99
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000064 RID: 100
		private global::DevExpress.XtraEditors.MemoEdit memoEdit1;
	}
}
