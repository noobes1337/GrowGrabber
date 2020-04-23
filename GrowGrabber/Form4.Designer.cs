namespace GrowGrabber
{
	// Token: 0x02000006 RID: 6
	public partial class Form4 : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00006F90 File Offset: 0x00005190
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006FB0 File Offset: 0x000051B0
		private void InitializeComponent()
		{
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new global::DevExpress.XtraEditors.LabelControl();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new global::System.Drawing.Point(12, 5);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(128, 18);
			this.labelControl1.TabIndex = 4;
			this.labelControl1.Text = "About GrowGrabber";
			this.pictureBox1.Image = global::GrowGrabber.Properties.Resources.snowflake_52_128;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(131, 133);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.labelControl2.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new global::System.Drawing.Point(149, 29);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new global::System.Drawing.Size(154, 16);
			this.labelControl2.TabIndex = 6;
			this.labelControl2.Text = "Author: Hirako - sadMotion";
			this.labelControl3.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new global::System.Drawing.Point(149, 51);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new global::System.Drawing.Size(79, 16);
			this.labelControl3.TabIndex = 7;
			this.labelControl3.Text = "License Type:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(482, 249);
			base.Controls.Add(this.labelControl3);
			base.Controls.Add(this.labelControl2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.labelControl1);
			base.IconOptions.Image = global::GrowGrabber.Properties.Resources.snowflake_52_32;
			base.MaximizeBox = false;
			base.Name = "Form4";
			this.Text = "GrowGrabber - License";
			base.Load += new global::System.EventHandler(this.Form4_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000056 RID: 86
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000057 RID: 87
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000059 RID: 89
		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		// Token: 0x0400005A RID: 90
		private global::DevExpress.XtraEditors.LabelControl labelControl3;
	}
}
