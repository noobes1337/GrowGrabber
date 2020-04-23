namespace GrowGrabber
{
	// Token: 0x02000007 RID: 7
	public partial class Form5 : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x06000048 RID: 72 RVA: 0x000073BB File Offset: 0x000055BB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000073DC File Offset: 0x000055DC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.eulacnt = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.memoEdit1 = new global::DevExpress.XtraEditors.MemoEdit();
			((global::System.ComponentModel.ISupportInitialize)this.memoEdit1.Properties).BeginInit();
			base.SuspendLayout();
			this.progressBar1.Location = new global::System.Drawing.Point(491, 403);
			this.progressBar1.Maximum = 30;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(100, 23);
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Visible = false;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new global::System.Drawing.Point(9, 356);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(124, 17);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "I Agree all the terms";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.simpleButton1.Enabled = false;
			this.simpleButton1.Location = new global::System.Drawing.Point(530, 353);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new global::System.Drawing.Size(108, 33);
			this.simpleButton1.TabIndex = 3;
			this.simpleButton1.Text = "Ok";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			this.eulacnt.Enabled = true;
			this.eulacnt.Interval = 1000;
			this.eulacnt.Tick += new global::System.EventHandler(this.eulacnt_Tick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(7, 375);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 13);
			this.label1.TabIndex = 4;
			this.memoEdit1.Location = new global::System.Drawing.Point(0, -1);
			this.memoEdit1.Name = "memoEdit1";
			this.memoEdit1.Size = new global::System.Drawing.Size(649, 348);
			this.memoEdit1.TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(642, 394);
			base.Controls.Add(this.memoEdit1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.progressBar1);
			base.IconOptions.Image = global::GrowGrabber.Properties.Resources.snowflake_52_32;
			base.Name = "Form5";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GrowGrabber - End User License";
			base.Load += new global::System.EventHandler(this.Form5_Load);
			((global::System.ComponentModel.ISupportInitialize)this.memoEdit1.Properties).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005C RID: 92
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400005F RID: 95
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Timer eulacnt;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000062 RID: 98
		private global::DevExpress.XtraEditors.MemoEdit memoEdit1;
	}
}
