namespace GrowGrabber
{
	// Token: 0x0200000A RID: 10
	public partial class msgbox : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00007E1F File Offset: 0x0000601F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007E40 File Offset: 0x00006040
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.Location = new global::System.Drawing.Point(79, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(197, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Message content will showup here";
			this.pictureBox1.Image = global::GrowGrabber.Properties.Resources.shell32_16710;
			this.pictureBox1.Location = new global::System.Drawing.Point(23, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(50, 48);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.simpleButton1.Location = new global::System.Drawing.Point(344, 94);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new global::System.Drawing.Size(108, 27);
			this.simpleButton1.TabIndex = 4;
			this.simpleButton1.Text = "Ok";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label2.Location = new global::System.Drawing.Point(79, 36);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(171, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Message content will showup here";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(464, 137);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.IconOptions.Image = global::GrowGrabber.Properties.Resources.snowflake_52_128;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "msgbox";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GrowGrabber v0.13 - Alert";
			base.Load += new global::System.EventHandler(this.msgbox_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000070 RID: 112
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000073 RID: 115
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label2;
	}
}
