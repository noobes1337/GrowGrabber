namespace GrowGrabber
{
	// Token: 0x02000005 RID: 5
	public partial class Form3 : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00006C50 File Offset: 0x00004E50
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006C70 File Offset: 0x00004E70
		private void InitializeComponent()
		{
			this.textEdit1 = new global::DevExpress.XtraEditors.TextEdit();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new global::DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).BeginInit();
			base.SuspendLayout();
			this.textEdit1.Location = new global::System.Drawing.Point(12, 33);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new global::System.Drawing.Size(396, 20);
			this.textEdit1.TabIndex = 0;
			this.textEdit1.EditValueChanged += new global::System.EventHandler(this.textEdit1_EditValueChanged);
			this.simpleButton1.Enabled = false;
			this.simpleButton1.Location = new global::System.Drawing.Point(13, 59);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new global::System.Drawing.Size(108, 33);
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "Add";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			this.simpleButton2.Location = new global::System.Drawing.Point(300, 59);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new global::System.Drawing.Size(108, 33);
			this.simpleButton2.TabIndex = 2;
			this.simpleButton2.Text = "Purchase";
			this.simpleButton2.Click += new global::System.EventHandler(this.simpleButton2_Click);
			this.labelControl1.Location = new global::System.Drawing.Point(13, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(63, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "License Code";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(420, 110);
			base.Controls.Add(this.labelControl1);
			base.Controls.Add(this.simpleButton2);
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.textEdit1);
			base.IconOptions.Image = global::GrowGrabber.Properties.Resources.snowflake_52_32;
			base.Name = "Form3";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GrowGrabber";
			base.Load += new global::System.EventHandler(this.Form3_Load);
			((global::System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000051 RID: 81
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000052 RID: 82
		private global::DevExpress.XtraEditors.TextEdit textEdit1;

		// Token: 0x04000053 RID: 83
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x04000054 RID: 84
		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		// Token: 0x04000055 RID: 85
		private global::DevExpress.XtraEditors.LabelControl labelControl1;
	}
}
