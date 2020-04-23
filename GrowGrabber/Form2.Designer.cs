namespace GrowGrabber
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00005D41 File Offset: 0x00003F41
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005D60 File Offset: 0x00003F60
		private void InitializeComponent()
		{
			this.simpleButton2 = new global::DevExpress.XtraEditors.SimpleButton();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.textEdit1 = new global::DevExpress.XtraEditors.TextEdit();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.xtraTabControl1 = new global::DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage1 = new global::DevExpress.XtraTab.XtraTabPage();
			this.groupControl1 = new global::DevExpress.XtraEditors.GroupControl();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.textEdit3 = new global::DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.groupControl3 = new global::DevExpress.XtraEditors.GroupControl();
			this.simpleButton4 = new global::DevExpress.XtraEditors.SimpleButton();
			this.textEdit4 = new global::DevExpress.XtraEditors.TextEdit();
			this.textEdit2 = new global::DevExpress.XtraEditors.TextEdit();
			this.xtraTabPage2 = new global::DevExpress.XtraTab.XtraTabPage();
			this.xtraTabPage3 = new global::DevExpress.XtraTab.XtraTabPage();
			this.memoEdit1 = new global::DevExpress.XtraEditors.MemoEdit();
			this.simpleButton3 = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.xtraTabControl1).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).BeginInit();
			this.groupControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit3.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl3).BeginInit();
			this.groupControl3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit4.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).BeginInit();
			this.xtraTabPage2.SuspendLayout();
			this.xtraTabPage3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.memoEdit1.Properties).BeginInit();
			base.SuspendLayout();
			this.simpleButton2.Location = new global::System.Drawing.Point(570, 72);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new global::System.Drawing.Size(94, 24);
			this.simpleButton2.TabIndex = 2;
			this.simpleButton2.Text = "Generate";
			this.simpleButton2.Click += new global::System.EventHandler(this.simpleButton2_Click);
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(16, 13);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(47, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Icon";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.textEdit1.Location = new global::System.Drawing.Point(16, 36);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new global::System.Drawing.Size(257, 20);
			this.textEdit1.TabIndex = 6;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Enabled = false;
			this.checkBox2.Location = new global::System.Drawing.Point(16, 64);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(62, 17);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "Startup";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			this.xtraTabControl1.Location = new global::System.Drawing.Point(6, -1);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl1.Size = new global::System.Drawing.Size(398, 247);
			this.xtraTabControl1.TabIndex = 11;
			this.xtraTabControl1.TabPages.AddRange(new global::DevExpress.XtraTab.XtraTabPage[]
			{
				this.xtraTabPage1,
				this.xtraTabPage2,
				this.xtraTabPage3
			});
			this.xtraTabPage1.Controls.Add(this.groupControl1);
			this.xtraTabPage1.Controls.Add(this.groupControl3);
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new global::System.Drawing.Size(392, 219);
			this.xtraTabPage1.Text = "Main";
			this.groupControl1.Controls.Add(this.simpleButton1);
			this.groupControl1.Controls.Add(this.textEdit3);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new global::System.Drawing.Point(6, 107);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new global::System.Drawing.Size(380, 101);
			this.groupControl1.TabIndex = 9;
			this.groupControl1.Text = "Signature";
			this.simpleButton1.Location = new global::System.Drawing.Point(281, 53);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new global::System.Drawing.Size(75, 23);
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "Generate";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			this.textEdit3.Location = new global::System.Drawing.Point(65, 27);
			this.textEdit3.Name = "textEdit3";
			this.textEdit3.Size = new global::System.Drawing.Size(291, 20);
			this.textEdit3.TabIndex = 1;
			this.labelControl1.Location = new global::System.Drawing.Point(12, 30);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(50, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Signature:";
			this.groupControl3.Controls.Add(this.simpleButton4);
			this.groupControl3.Controls.Add(this.textEdit4);
			this.groupControl3.Controls.Add(this.textEdit2);
			this.groupControl3.Location = new global::System.Drawing.Point(5, 0);
			this.groupControl3.Name = "groupControl3";
			this.groupControl3.Size = new global::System.Drawing.Size(380, 99);
			this.groupControl3.TabIndex = 8;
			this.groupControl3.Text = "Socket Information";
			this.simpleButton4.Location = new global::System.Drawing.Point(296, 53);
			this.simpleButton4.Name = "simpleButton4";
			this.simpleButton4.Size = new global::System.Drawing.Size(75, 23);
			this.simpleButton4.TabIndex = 4;
			this.simpleButton4.Text = "Bind";
			this.textEdit4.EditValue = "1337";
			this.textEdit4.Location = new global::System.Drawing.Point(12, 54);
			this.textEdit4.Name = "textEdit4";
			this.textEdit4.Size = new global::System.Drawing.Size(278, 20);
			this.textEdit4.TabIndex = 3;
			this.textEdit2.EditValue = "127.0.0.1";
			this.textEdit2.Location = new global::System.Drawing.Point(12, 28);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Size = new global::System.Drawing.Size(359, 20);
			this.textEdit2.TabIndex = 2;
			this.xtraTabPage2.Controls.Add(this.checkBox1);
			this.xtraTabPage2.Controls.Add(this.checkBox2);
			this.xtraTabPage2.Controls.Add(this.textEdit1);
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new global::System.Drawing.Size(392, 219);
			this.xtraTabPage2.Text = "Settings";
			this.xtraTabPage3.Controls.Add(this.memoEdit1);
			this.xtraTabPage3.Name = "xtraTabPage3";
			this.xtraTabPage3.Size = new global::System.Drawing.Size(392, 219);
			this.xtraTabPage3.Text = "Output";
			this.memoEdit1.Location = new global::System.Drawing.Point(-1, 0);
			this.memoEdit1.Name = "memoEdit1";
			this.memoEdit1.Properties.BorderStyle = global::DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.memoEdit1.Size = new global::System.Drawing.Size(397, 202);
			this.memoEdit1.TabIndex = 12;
			this.simpleButton3.Appearance.Font = new global::System.Drawing.Font("Tahoma", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.simpleButton3.Appearance.Options.UseFont = true;
			this.simpleButton3.Location = new global::System.Drawing.Point(7, 251);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new global::System.Drawing.Size(397, 29);
			this.simpleButton3.TabIndex = 14;
			this.simpleButton3.Text = "Build Client";
			this.simpleButton3.Click += new global::System.EventHandler(this.simpleButton3_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(404, 294);
			base.Controls.Add(this.simpleButton3);
			base.Controls.Add(this.xtraTabControl1);
			base.Controls.Add(this.simpleButton2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.IconOptions.Image = global::GrowGrabber.Properties.Resources.snowflake_52_128;
			base.MaximizeBox = false;
			base.Name = "Form2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GrowGrabber v0.13 - Client Builder";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			((global::System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.xtraTabControl1).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit3.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl3).EndInit();
			this.groupControl3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.textEdit4.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).EndInit();
			this.xtraTabPage2.ResumeLayout(false);
			this.xtraTabPage2.PerformLayout();
			this.xtraTabPage3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.memoEdit1.Properties).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400003C RID: 60
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003D RID: 61
		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400003F RID: 63
		private global::DevExpress.XtraEditors.TextEdit textEdit1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x04000041 RID: 65
		private global::DevExpress.XtraTab.XtraTabControl xtraTabControl1;

		// Token: 0x04000042 RID: 66
		private global::DevExpress.XtraTab.XtraTabPage xtraTabPage1;

		// Token: 0x04000043 RID: 67
		private global::DevExpress.XtraEditors.TextEdit textEdit3;

		// Token: 0x04000044 RID: 68
		private global::DevExpress.XtraEditors.GroupControl groupControl3;

		// Token: 0x04000045 RID: 69
		private global::DevExpress.XtraEditors.TextEdit textEdit4;

		// Token: 0x04000046 RID: 70
		private global::DevExpress.XtraEditors.TextEdit textEdit2;

		// Token: 0x04000047 RID: 71
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x04000048 RID: 72
		private global::DevExpress.XtraTab.XtraTabPage xtraTabPage2;

		// Token: 0x04000049 RID: 73
		private global::DevExpress.XtraTab.XtraTabPage xtraTabPage3;

		// Token: 0x0400004A RID: 74
		private global::DevExpress.XtraEditors.MemoEdit memoEdit1;

		// Token: 0x0400004B RID: 75
		private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

		// Token: 0x0400004C RID: 76
		private global::DevExpress.XtraEditors.GroupControl groupControl1;

		// Token: 0x0400004D RID: 77
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x0400004E RID: 78
		private global::DevExpress.XtraEditors.SimpleButton simpleButton4;
	}
}
