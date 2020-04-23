namespace GrowGrabber
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000040B5 File Offset: 0x000022B5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000040D4 File Offset: 0x000022D4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::GrowGrabber.Form1));
			this.listBoxControl1 = new global::DevExpress.XtraEditors.ListBoxControl();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new global::DevExpress.XtraEditors.LabelControl();
			this.barManager1 = new global::DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new global::DevExpress.XtraBars.Bar();
			this.bar2 = new global::DevExpress.XtraBars.Bar();
			this.barSubItem2 = new global::DevExpress.XtraBars.BarSubItem();
			this.barButtonItem4 = new global::DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new global::DevExpress.XtraBars.BarButtonItem();
			this.sks = new global::DevExpress.XtraBars.BarSubItem();
			this.barSubItem3 = new global::DevExpress.XtraBars.BarSubItem();
			this.barButtonItem6 = new global::DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem7 = new global::DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem8 = new global::DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new global::DevExpress.XtraBars.Bar();
			this.barDockControlTop = new global::DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new global::DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new global::DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new global::DevExpress.XtraBars.BarDockControl();
			this.barSubItem1 = new global::DevExpress.XtraBars.BarSubItem();
			this.barButtonItem1 = new global::DevExpress.XtraBars.BarButtonItem();
			this.barToolbarsListItem1 = new global::DevExpress.XtraBars.BarToolbarsListItem();
			this.skinDropDownButtonItem1 = new global::DevExpress.XtraBars.SkinDropDownButtonItem();
			this.barButtonItem2 = new global::DevExpress.XtraBars.BarButtonItem();
			this.popupMenu1 = new global::DevExpress.XtraBars.PopupMenu(this.components);
			this.SkinsLink = new global::DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new global::DevExpress.XtraBars.BarButtonItem();
			this.listBoxControl2 = new global::DevExpress.XtraEditors.ListBoxControl();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.labelControl4 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new global::DevExpress.XtraEditors.LabelControl();
			this.backgroundWorker2 = new global::System.ComponentModel.BackgroundWorker();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.exporToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ddToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.savedatToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.removeFromServerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aAPBypassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new global::System.Windows.Forms.Label();
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.barButtonItem9 = new global::DevExpress.XtraBars.BarButtonItem();
			((global::System.ComponentModel.ISupportInitialize)this.listBoxControl1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.barManager1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.popupMenu1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.listBoxControl2).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.listBoxControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.listBoxControl1.Appearance.Options.UseFont = true;
			this.listBoxControl1.BorderStyle = global::DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.listBoxControl1.Location = new global::System.Drawing.Point(2, 26);
			this.listBoxControl1.Name = "listBoxControl1";
			this.listBoxControl1.Size = new global::System.Drawing.Size(515, 252);
			this.listBoxControl1.TabIndex = 0;
			this.listBoxControl1.SelectedIndexChanged += new global::System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
			this.listBoxControl1.SelectedValueChanged += new global::System.EventHandler(this.listBoxControl1_SelectedValueChanged);
			this.listBoxControl1.Click += new global::System.EventHandler(this.listBoxControl1_Click);
			this.listBoxControl1.MouseCaptureChanged += new global::System.EventHandler(this.listBoxControl1_MouseCaptureChanged);
			this.listBoxControl1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.listBoxControl1_MouseDown);
			this.listBoxControl1.MouseHover += new global::System.EventHandler(this.listBoxControl1_MouseHover);
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new global::System.Drawing.Point(525, 101);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(60, 16);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Password:";
			this.labelControl2.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new global::System.Drawing.Point(526, 26);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new global::System.Drawing.Size(47, 16);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "GrowID:";
			this.labelControl3.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new global::System.Drawing.Point(526, 45);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new global::System.Drawing.Size(60, 16);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Lastworld:";
			this.barManager1.Bars.AddRange(new global::DevExpress.XtraBars.Bar[]
			{
				this.bar1,
				this.bar2,
				this.bar3
			});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new global::DevExpress.XtraBars.BarItem[]
			{
				this.barSubItem1,
				this.barButtonItem1,
				this.barToolbarsListItem1,
				this.skinDropDownButtonItem1,
				this.barButtonItem2,
				this.barButtonItem3,
				this.SkinsLink,
				this.sks,
				this.barSubItem2,
				this.barButtonItem4,
				this.barButtonItem5,
				this.barSubItem3,
				this.barButtonItem6,
				this.barButtonItem7,
				this.barButtonItem8,
				this.barButtonItem9
			});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 16;
			this.barManager1.StatusBar = this.bar1;
			this.bar1.BarName = "Tools";
			this.bar1.CanDockStyle = global::DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 1;
			this.bar1.DockStyle = global::DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar1.OptionsBar.AllowQuickCustomization = false;
			this.bar1.OptionsBar.DrawDragBorder = false;
			this.bar1.OptionsBar.UseWholeRow = true;
			this.bar1.Text = "Tools";
			this.bar1.Visible = false;
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = global::DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new global::DevExpress.XtraBars.LinkPersistInfo[]
			{
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
				new global::DevExpress.XtraBars.LinkPersistInfo(this.sks),
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9)
			});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			this.barSubItem2.Caption = "Socket";
			this.barSubItem2.Id = 8;
			this.barSubItem2.LinksPersistInfo.AddRange(new global::DevExpress.XtraBars.LinkPersistInfo[]
			{
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)
			});
			this.barSubItem2.Name = "barSubItem2";
			this.barButtonItem4.Caption = "Request Data";
			this.barButtonItem4.Id = 9;
			this.barButtonItem4.Name = "barButtonItem4";
			this.barButtonItem4.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
			this.barButtonItem3.Caption = "Builder";
			this.barButtonItem3.Id = 5;
			this.barButtonItem3.Name = "barButtonItem3";
			this.barButtonItem3.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
			this.sks.Caption = "Styles";
			this.sks.Id = 7;
			this.sks.Name = "sks";
			this.sks.GetItemData += new global::System.EventHandler(this.sks_GetItemData);
			this.sks.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.sks_ItemClick);
			this.barSubItem3.Caption = "About";
			this.barSubItem3.Id = 11;
			this.barSubItem3.LinksPersistInfo.AddRange(new global::DevExpress.XtraBars.LinkPersistInfo[]
			{
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)
			});
			this.barSubItem3.Name = "barSubItem3";
			this.barButtonItem6.Caption = "EULA";
			this.barButtonItem6.Id = 12;
			this.barButtonItem6.Name = "barButtonItem6";
			this.barButtonItem6.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
			this.barButtonItem7.Caption = "Changelogs";
			this.barButtonItem7.Id = 13;
			this.barButtonItem7.Name = "barButtonItem7";
			this.barButtonItem8.Caption = "License";
			this.barButtonItem8.Id = 14;
			this.barButtonItem8.Name = "barButtonItem8";
			this.barButtonItem8.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = global::DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = global::DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			this.bar3.Visible = false;
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new global::System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new global::System.Drawing.Size(691, 20);
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new global::System.Drawing.Point(0, 262);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new global::System.Drawing.Size(691, 52);
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new global::System.Drawing.Point(0, 20);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new global::System.Drawing.Size(0, 242);
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new global::System.Drawing.Point(691, 20);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new global::System.Drawing.Size(0, 242);
			this.barSubItem1.Caption = "Settings";
			this.barSubItem1.Id = 0;
			this.barSubItem1.Name = "barSubItem1";
			this.barButtonItem1.Caption = "Settings";
			this.barButtonItem1.Id = 1;
			this.barButtonItem1.Name = "barButtonItem1";
			this.barToolbarsListItem1.Caption = "dd";
			this.barToolbarsListItem1.Id = 2;
			this.barToolbarsListItem1.Name = "barToolbarsListItem1";
			this.skinDropDownButtonItem1.Hint = "Styles";
			this.skinDropDownButtonItem1.Id = 3;
			this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
			this.skinDropDownButtonItem1.PaintStyle = global::DevExpress.XtraBars.BarItemPaintStyle.Caption;
			this.skinDropDownButtonItem1.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.skinDropDownButtonItem1_ItemClick);
			this.barButtonItem2.ActAsDropDown = true;
			this.barButtonItem2.ButtonStyle = global::DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.barButtonItem2.Caption = "Settings";
			this.barButtonItem2.DropDownControl = this.popupMenu1;
			this.barButtonItem2.Id = 4;
			this.barButtonItem2.Name = "barButtonItem2";
			this.popupMenu1.Manager = this.barManager1;
			this.popupMenu1.Name = "popupMenu1";
			this.SkinsLink.Caption = "Styles";
			this.SkinsLink.Id = 6;
			this.SkinsLink.Name = "SkinsLink";
			this.barButtonItem5.Caption = "Add ID";
			this.barButtonItem5.Id = 10;
			this.barButtonItem5.Name = "barButtonItem5";
			this.barButtonItem5.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
			this.listBoxControl2.BorderStyle = global::DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.listBoxControl2.Location = new global::System.Drawing.Point(522, 122);
			this.listBoxControl2.Name = "listBoxControl2";
			this.listBoxControl2.Size = new global::System.Drawing.Size(167, 156);
			this.listBoxControl2.TabIndex = 22;
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.labelControl4.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new global::System.Drawing.Point(526, 64);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new global::System.Drawing.Size(37, 16);
			this.labelControl4.TabIndex = 27;
			this.labelControl4.Text = "Guest:";
			this.labelControl5.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new global::System.Drawing.Point(525, 82);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new global::System.Drawing.Size(45, 16);
			this.labelControl5.TabIndex = 28;
			this.labelControl5.Text = "Playing:";
			this.backgroundWorker2.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.contextMenuStrip1.BackColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.exporToolStripMenuItem,
				this.refreshToolStripMenuItem,
				this.removeFromServerToolStripMenuItem,
				this.aAPBypassToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(137, 92);
			this.exporToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ddToolStripMenuItem,
				this.savedatToolStripMenuItem
			});
			this.exporToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.exporToolStripMenuItem.Image = global::GrowGrabber.Properties.Resources.unnamed;
			this.exporToolStripMenuItem.Name = "exporToolStripMenuItem";
			this.exporToolStripMenuItem.Size = new global::System.Drawing.Size(136, 22);
			this.exporToolStripMenuItem.Text = "Export";
			this.exporToolStripMenuItem.Click += new global::System.EventHandler(this.exporToolStripMenuItem_Click);
			this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
			this.ddToolStripMenuItem.Size = new global::System.Drawing.Size(119, 22);
			this.ddToolStripMenuItem.Text = "Account";
			this.ddToolStripMenuItem.Click += new global::System.EventHandler(this.ddToolStripMenuItem_Click);
			this.savedatToolStripMenuItem.Name = "savedatToolStripMenuItem";
			this.savedatToolStripMenuItem.Size = new global::System.Drawing.Size(119, 22);
			this.savedatToolStripMenuItem.Text = "Save.dat";
			this.savedatToolStripMenuItem.Click += new global::System.EventHandler(this.savedatToolStripMenuItem_Click);
			this.refreshToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.refreshToolStripMenuItem.Image = global::GrowGrabber.Properties.Resources.arrow_sync_synchronize_way_direction_reload_refresh_17_32383;
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new global::System.Drawing.Size(136, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new global::System.EventHandler(this.refreshToolStripMenuItem_Click);
			this.removeFromServerToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.removeFromServerToolStripMenuItem.Image = global::GrowGrabber.Properties.Resources.unnameds;
			this.removeFromServerToolStripMenuItem.Name = "removeFromServerToolStripMenuItem";
			this.removeFromServerToolStripMenuItem.Size = new global::System.Drawing.Size(136, 22);
			this.removeFromServerToolStripMenuItem.Text = "Delete";
			this.removeFromServerToolStripMenuItem.Click += new global::System.EventHandler(this.removeFromServerToolStripMenuItem_Click);
			this.aAPBypassToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.aAPBypassToolStripMenuItem.Image = global::GrowGrabber.Properties.Resources._693486632179073084;
			this.aAPBypassToolStripMenuItem.Name = "aAPBypassToolStripMenuItem";
			this.aAPBypassToolStripMenuItem.Size = new global::System.Drawing.Size(136, 22);
			this.aAPBypassToolStripMenuItem.Text = "AAP Bypass";
			this.aAPBypassToolStripMenuItem.Click += new global::System.EventHandler(this.aAPBypassToolStripMenuItem_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.Location = new global::System.Drawing.Point(6, 286);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(146, 19);
			this.label1.TabIndex = 33;
			this.label1.Text = "Selected Item (0/0)";
			this.notifyIcon1.Icon = (global::System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
			this.notifyIcon1.Text = "notifyIcon1";
			this.barButtonItem9.Caption = "Save Theme";
			this.barButtonItem9.Id = 15;
			this.barButtonItem9.Name = "barButtonItem9";
			this.barButtonItem9.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(691, 314);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.labelControl5);
			base.Controls.Add(this.labelControl4);
			base.Controls.Add(this.listBoxControl2);
			base.Controls.Add(this.labelControl3);
			base.Controls.Add(this.labelControl2);
			base.Controls.Add(this.labelControl1);
			base.Controls.Add(this.listBoxControl1);
			base.Controls.Add(this.barDockControlLeft);
			base.Controls.Add(this.barDockControlRight);
			base.Controls.Add(this.barDockControlBottom);
			base.Controls.Add(this.barDockControlTop);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.IconOptions.Icon = (global::System.Drawing.Icon)resources.GetObject("Form1.IconOptions.Icon");
			base.IconOptions.Image = global::GrowGrabber.Properties.Resources.snowflake_52_32;
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GrowGrabber v0.13 - Made by Hirako";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.listBoxControl1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.barManager1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.popupMenu1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.listBoxControl2).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000C RID: 12
		private global::DevExpress.XtraEditors.ListBoxControl listBoxControl1;

		// Token: 0x0400000D RID: 13
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x0400000E RID: 14
		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		// Token: 0x0400000F RID: 15
		private global::DevExpress.XtraEditors.LabelControl labelControl3;

		// Token: 0x04000010 RID: 16
		private global::DevExpress.XtraBars.BarManager barManager1;

		// Token: 0x04000011 RID: 17
		private global::DevExpress.XtraBars.Bar bar1;

		// Token: 0x04000012 RID: 18
		private global::DevExpress.XtraBars.Bar bar2;

		// Token: 0x04000013 RID: 19
		private global::DevExpress.XtraBars.BarSubItem barSubItem1;

		// Token: 0x04000014 RID: 20
		private global::DevExpress.XtraBars.Bar bar3;

		// Token: 0x04000015 RID: 21
		private global::DevExpress.XtraBars.BarDockControl barDockControlTop;

		// Token: 0x04000016 RID: 22
		private global::DevExpress.XtraBars.BarDockControl barDockControlBottom;

		// Token: 0x04000017 RID: 23
		private global::DevExpress.XtraBars.BarDockControl barDockControlLeft;

		// Token: 0x04000018 RID: 24
		private global::DevExpress.XtraBars.BarDockControl barDockControlRight;

		// Token: 0x04000019 RID: 25
		private global::DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;

		// Token: 0x0400001A RID: 26
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem1;

		// Token: 0x0400001B RID: 27
		private global::DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;

		// Token: 0x0400001C RID: 28
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem2;

		// Token: 0x0400001D RID: 29
		private global::DevExpress.XtraBars.PopupMenu popupMenu1;

		// Token: 0x0400001E RID: 30
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem3;

		// Token: 0x0400001F RID: 31
		private global::DevExpress.XtraBars.BarButtonItem SkinsLink;

		// Token: 0x04000020 RID: 32
		private global::DevExpress.XtraBars.BarSubItem sks;

		// Token: 0x04000021 RID: 33
		private global::DevExpress.XtraBars.BarSubItem barSubItem2;

		// Token: 0x04000022 RID: 34
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem4;

		// Token: 0x04000023 RID: 35
		private global::DevExpress.XtraEditors.ListBoxControl listBoxControl2;

		// Token: 0x04000024 RID: 36
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000025 RID: 37
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem5;

		// Token: 0x04000026 RID: 38
		private global::DevExpress.XtraEditors.LabelControl labelControl4;

		// Token: 0x04000027 RID: 39
		private global::DevExpress.XtraEditors.LabelControl labelControl5;

		// Token: 0x04000028 RID: 40
		private global::DevExpress.XtraBars.BarSubItem barSubItem3;

		// Token: 0x04000029 RID: 41
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem6;

		// Token: 0x0400002A RID: 42
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem7;

		// Token: 0x0400002B RID: 43
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem8;

		// Token: 0x0400002C RID: 44
		private global::System.ComponentModel.BackgroundWorker backgroundWorker2;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripMenuItem exporToolStripMenuItem;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripMenuItem ddToolStripMenuItem;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStripMenuItem savedatToolStripMenuItem;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripMenuItem removeFromServerToolStripMenuItem;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem aAPBypassToolStripMenuItem;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000038 RID: 56
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem9;
	}
}
