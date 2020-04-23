using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace Outbuilt
{
	// Token: 0x02000012 RID: 18
	public class Protection
	{
		// Token: 0x06000083 RID: 131
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		// Token: 0x06000084 RID: 132
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetCurrentProcessId();

		// Token: 0x06000085 RID: 133
		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr hWnd, ref IntPtr ProcessId);

		// Token: 0x06000086 RID: 134
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000087 RID: 135
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		// Token: 0x06000088 RID: 136
		[DllImport("ntdll.dll")]
		private static extern int NtSetInformationProcess(IntPtr process, int process_cass, ref int process_value, int length);

		// Token: 0x06000089 RID: 137
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		private static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

		// Token: 0x0600008A RID: 138
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x0600008B RID: 139
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x0600008C RID: 140 RVA: 0x00008928 File Offset: 0x00006B28
		public static string GetMD5()
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			FileStream stream = new FileStream(Process.GetCurrentProcess().MainModule.FileName, FileMode.Open, FileAccess.Read);
			md5.ComputeHash(stream);
			stream.Close();
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < md5.Hash.Length; i++)
			{
				sb.Append(md5.Hash[i].ToString("x2"));
			}
			return sb.ToString().ToUpperInvariant();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000089A4 File Offset: 0x00006BA4
		private static void CMD()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			if (!File.Exists(pathRoot + "Windows\\System32\\cmd.exe"))
			{
				Directory.CreateDirectory("C:/ProgramData/Outbuilt");
				File.Create("C:/ProgramData/Outbuilt/CMD missing");
				Protection.Error();
			}
			if (!File.Exists(pathRoot + "Windows\\System32\\taskkill.exe"))
			{
				Directory.CreateDirectory("C:/ProgramData/Outbuilt");
				File.Create("C:/ProgramData/Outbuilt/taskkill missing");
				Protection.Error();
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008A14 File Offset: 0x00006C14
		public static void Start()
		{
			try
			{
				new WebClient().DownloadString("https://google.com");
			}
			catch
			{
				Protection.Error();
			}
			Protection.CMD();
			Protection.Detect();
			Protection.DetectVM();
			Protection.Outbuilt.DefaultDependencyAttribute();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008A60 File Offset: 0x00006C60
		private static bool IsAdministrator()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008A78 File Offset: 0x00006C78
		private static void Detect()
		{
			if (Protection.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
			{
				Directory.CreateDirectory("C:/ProgramData/Outbuilt");
				File.Create("C:/ProgramData/Outbuilt/Sandboxie");
				Protection.Error();
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00008AB4 File Offset: 0x00006CB4
		public static void FreezeMouse()
		{
			Protection._TurnedOn = true;
			Protection._TurnedOff = false;
			Thread thread = new Thread(new ThreadStart(Protection.FreezeWindowsProcess));
			Protection.CheckForIllegalCrossThreadCalls = false;
			thread.Start();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008ADE File Offset: 0x00006CDE
		public static void DeleteFile(string file)
		{
			Protection.Shell("del " + file + " \\q");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008AF5 File Offset: 0x00006CF5
		public static void DeleteDirectory(string file)
		{
			Protection.Shell("rmdir " + file + " \\q");
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00008B0C File Offset: 0x00006D0C
		public static void ShowCMD(string Title, string Text, string Color)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", string.Concat(new string[]
			{
				"/c START CMD /C \"COLOR ",
				Color,
				" && TITLE ",
				Title,
				" && ECHO ",
				Text,
				" && TIMEOUT 10\""
			}))
			{
				CreateNoWindow = true,
				UseShellExecute = false
			});
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008B70 File Offset: 0x00006D70
		private static Dictionary<int, int> GetAllProcessParentPids()
		{
			Dictionary<int, int> childPidToParentPid = new Dictionary<int, int>();
			SortedDictionary<string, PerformanceCounter[]> processCounters = new SortedDictionary<string, PerformanceCounter[]>();
			PerformanceCounterCategory category = new PerformanceCounterCategory("Process");
			foreach (string t in category.GetInstanceNames())
			{
				try
				{
					processCounters[t] = category.GetCounters(t);
				}
				catch (InvalidOperationException)
				{
				}
			}
			foreach (KeyValuePair<string, PerformanceCounter[]> kvp in processCounters)
			{
				int childPid = -1;
				int parentPid = -1;
				foreach (PerformanceCounter counter in kvp.Value)
				{
					if ("ID Process".CompareTo(counter.CounterName) == 0)
					{
						childPid = (int)counter.NextValue();
					}
					else if ("Creating Process ID".CompareTo(counter.CounterName) == 0)
					{
						parentPid = (int)counter.NextValue();
					}
				}
				if (childPid != -1 && parentPid != -1)
				{
					childPidToParentPid[childPid] = parentPid;
				}
			}
			return childPidToParentPid;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008C90 File Offset: 0x00006E90
		private static void DBG()
		{
			if (Directory.Exists("C:/ProgramData/Outbuilt"))
			{
				Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OUTBUILT.OOO Protection && ECHO [OUTBUILT.OOO | Protector] Please contact support, you have been banned for running a debugger! && TIMEOUT 10\"")
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
				Process.GetCurrentProcess().Kill();
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008CCC File Offset: 0x00006ECC
		private static void Misc()
		{
			if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Count<Process>() > 1)
			{
				Directory.CreateDirectory("C:/ProgramData/Outbuilt");
				File.Create("C:/ProgramData/Outbuilt/Already running");
				Protection.Error();
			}
			Process p = Process.GetCurrentProcess();
			int processId = (int)new PerformanceCounter("Process", "Creating Process ID", p.ProcessName).NextValue();
			if (Process.GetProcessById(processId).ProcessName == "cmd")
			{
				Console.Title = "Outbuilt.OOO Protection";
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Application not allowed to run in CMD!");
				Thread.Sleep(2000);
				Process.GetCurrentProcess().Kill();
			}
			if (Process.GetProcessById(processId).ProcessName == "powershell")
			{
				Console.Title = "Outbuilt.OOO Protection";
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Application not allowed to run in powershell!");
				Thread.Sleep(2000);
				Process.GetCurrentProcess().Kill();
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00008DC4 File Offset: 0x00006FC4
		public static void Destruct()
		{
			string app = AppDomain.CurrentDomain.FriendlyName;
			string AppPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).ToString() + "\\" + app;
			Process.Start("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del " + AppPath);
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008E1C File Offset: 0x0000701C
		private static void CheckForAnyProxyConnections()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00008E20 File Offset: 0x00007020
		private static void Shell(object command)
		{
			try
			{
				ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + ((command != null) ? command.ToString() : null));
				procStartInfo.RedirectStandardOutput = true;
				procStartInfo.UseShellExecute = false;
				procStartInfo.CreateNoWindow = true;
				Process process = new Process();
				process.StartInfo = procStartInfo;
				process.Start();
				process.StandardOutput.ReadToEnd();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00008E98 File Offset: 0x00007098
		public static void KillPC()
		{
			Process.Start("C:\\Windows\\System32\\taskkill.exe", "/F /IM explorer.exe");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008EAA File Offset: 0x000070AA
		private static void Admin()
		{
			if (!Protection.IsAdministrator())
			{
				Directory.CreateDirectory("C:/ProgramData/Outbuilt");
				File.Create("C:/ProgramData/Outbuilt/AppNotAdmin");
				Protection.Error();
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008ECE File Offset: 0x000070CE
		public static void RevivePC()
		{
			Process.Start(Path.Combine(Environment.GetEnvironmentVariable("windir"), "explorer.exe"));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008EEA File Offset: 0x000070EA
		public static void ReleaseMouse()
		{
			Protection._TurnedOn = false;
			Protection._TurnedOff = true;
			Protection.BlockInput(false);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008F00 File Offset: 0x00007100
		private static void Error()
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OUTBUILT.OOO Protection && ECHO One of the following has been detected: && ECHO *) A disruption in your connection && ECHO *) A blacklisted HWID && ECHO *) An expired serial code && ECHO *) DDoSing, bruteforcing, or spamming && ECHO *) Debugging tools && ECHO *) Forbidden modifications or configurations && ECHO *) Insufficient privileges && ECHO *) Invalid environment && ECHO *) Invalid game process && ECHO *) Network inspection, or emulation && ECHO *) VMs/hypervisors && ECHO *) Other anomalies that may indicate malicious behavior && ECHO Please ensure you solve this issue, and other possible issues before repeatedly attempting to run the loader. && TIMEOUT 10\"")
			{
				CreateNoWindow = true,
				UseShellExecute = false
			});
			try
			{
				Protection.Destruct();
			}
			catch
			{
				Process.GetCurrentProcess().Kill();
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008F54 File Offset: 0x00007154
		public static void Download(string url, string path)
		{
			new WebClient().DownloadFile(url, path);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008F64 File Offset: 0x00007164
		private static void DetectEmulation()
		{
			long tickCount = (long)Environment.TickCount;
			Thread.Sleep(500);
			if ((long)Environment.TickCount - tickCount < 500L)
			{
				Directory.CreateDirectory("C:/ProgramData/Outbuilt");
				File.Create("C:/ProgramData/Outbuilt/Emulation");
				Protection.Error();
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008FB0 File Offset: 0x000071B0
		private static void DetectVM()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						if ((managementBaseObject["Manufacturer"].ToString().ToLower() == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || managementBaseObject["Manufacturer"].ToString().ToLower().Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
						{
							Directory.CreateDirectory("C:/ProgramData/Outbuilt");
							File.Create("C:/ProgramData/Outbuilt/VM Detected");
							Protection.Error();
						}
					}
				}
			}
			foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
			{
				if (managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VMware") && managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VBox"))
				{
					Directory.CreateDirectory("C:/ProgramData/Outbuilt");
					File.Create("C:/ProgramData/Outbuilt/VM Detected");
					Protection.Error();
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009168 File Offset: 0x00007368
		public static void BSOD()
		{
			Process.EnterDebugMode();
			int status = 1;
			Protection.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref status, 4);
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000919B File Offset: 0x0000739B
		private static void FreezeWindowsProcess()
		{
			while (Protection._TurnedOn)
			{
				Protection.BlockInput(true);
			}
			while (Protection._TurnedOff)
			{
				Protection.BlockInput(false);
			}
			Thread.Sleep(250);
		}

		// Token: 0x0400007D RID: 125
		private static bool isDebuggerPresent;

		// Token: 0x0400007E RID: 126
		private static bool _TurnedOn;

		// Token: 0x0400007F RID: 127
		private static bool _TurnedOff;

		// Token: 0x04000080 RID: 128
		private static bool CheckForIllegalCrossThreadCalls;

		// Token: 0x04000081 RID: 129
		private static string killswitch_status;

		// Token: 0x0200001B RID: 27
		internal class Outbuilt
		{
			// Token: 0x060000B6 RID: 182 RVA: 0x0000967C File Offset: 0x0000787C
			internal static void FileDebug()
			{
				string userName = Environment.UserName;
				Protection.Outbuilt.Search("C:\\Program Files", "Wireshark", "exe");
				Protection.Outbuilt.Search("C:\\Program Files", "dumpcap", "exe");
				Protection.Outbuilt.Search("C:\\Program Files", "editcap", "exe");
				Protection.Outbuilt.Search("C:\\Program Files", "k5sprt64", "dll");
				Protection.Outbuilt.Search("C:\\Program Files", "libgmodule-2.0-0", "dll");
				if (!Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Programs"))
				{
					Directory.CreateDirectory("C:\\Users\\" + userName + "\\AppData\\Local\\Programs");
				}
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Programs", "Telerik.NetworkConnections", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Programs", "Xceed.Zip.v5.4", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Programs", "Zopfli", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "Procmon.exe", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Downloads", "Procmon", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Desktop", "Procmon", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Videos", "Procmon", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "SimpleAssemblyExplorer", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Downloads", "SimpleAssemblyExplorer", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Desktop", "SimpleAssemblyExplorer", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Videos", "SimpleAssemblyExplorer", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "SimpleAssemblyExplorer.vshost", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Downloads", "SimpleAssemblyExplorer.vshost", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Desktop", "SimpleAssemblyExplorer.vshost", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Videos", "SimpleAssemblyExplorer.vshost", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "ICSharpCode.NRefactory.CSharp", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Downloads", "ICSharpCode.NRefactory.CSharp", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Desktop", "ICSharpCode.NRefactory.CSharp", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Videos", "ICSharpCode.NRefactory.CSharp", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "Qt5Core", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Downloads", "Qt5Core", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Desktop", "Qt5Core", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Videos", "Qt5Core", "dll");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Ghidra\\packed-db-cache", "cache", "map");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\AppData\\Local\\Temp", "FolderChangesView", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Downloads", "FolderChangesView", "exe");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Desktop", "FolderChangesView", "exe");
				Protection.Outbuilt.Search("C:\\Program Files(x86)\\HTTPDebuggerPro", "HTTPDebuggerSvc", "exe");
				Protection.Outbuilt.Search("C:\\Program Files (x86)\\mitmproxy", "uninstall", "exe");
				Protection.Outbuilt.Search("C:\\Program Files\\Charles", "Charles", "exe");
				Protection.Outbuilt.Search("C:\\ProgramData\\HTTPDebuggerPro", "settings", "xml");
				Protection.Outbuilt.Search("C:\\Users\\" + userName + "\\Videos", "FolderChangesView", "exe");
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00009AD4 File Offset: 0x00007CD4
			internal static void Search(string dir, string file, string Extention)
			{
				string text = string.Concat(new string[]
				{
					dir,
					"\\",
					file,
					".",
					Extention
				});
				if (File.Exists(text))
				{
					Directory.CreateDirectory("C:/ProgramData/Outbuilt");
					File.Create("C:/ProgramData/Outbuilt/" + file);
					Process.Start(new ProcessStartInfo("cmd.exe", "/c START CMD /C \"COLOR C && TITLE OUTBUILT.OOO Protection && ECHO " + text + " Detected! && TIMEOUT 10\"")
					{
						CreateNoWindow = true,
						UseShellExecute = false
					});
					Process.GetCurrentProcess().Kill();
				}
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00009B68 File Offset: 0x00007D68
			internal static void AssemblyHashAlgorithm()
			{
				int num = new Random().Next(3000, 10000);
				DateTime now = DateTime.Now;
				Thread.Sleep(num);
				if ((DateTime.Now - now).TotalMilliseconds < (double)num)
				{
					Protection.Error();
				}
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00009BB2 File Offset: 0x00007DB2
			internal static void MemberFilter(string A_0)
			{
				Process.Start(new ProcessStartInfo("cmd.exe", "/c " + A_0)
				{
					CreateNoWindow = true,
					UseShellExecute = false
				});
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00009BDD File Offset: 0x00007DDD
			public static void DefaultDependencyAttribute()
			{
				new Thread(new ThreadStart(Protection.Outbuilt.ByteEqualityComparer)).Start();
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00009BF8 File Offset: 0x00007DF8
			internal static void ByteEqualityComparer()
			{
				string[] array = Protection.Outbuilt.GetArray();
				List<string> whitelist = new List<string>
				{
					"winstore.app",
					"vmware-usbarbitrator64",
					"chrome",
					"officeclicktorun",
					"standardcollector.service",
					"svchost",
					"explorer"
				};
				Debugger.Log(0, null, "%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s");
				for (;;)
				{
					foreach (Process process in Process.GetProcesses())
					{
						if (process != Process.GetCurrentProcess())
						{
							for (int i = 0; i < array.Length; i++)
							{
								int id = Process.GetCurrentProcess().Id;
								if (process.ProcessName.ToLower().Contains(array[i]) && !whitelist.Contains(process.ProcessName.ToLower()))
								{
									Directory.CreateDirectory("C:/ProgramData/Outbuilt");
									File.Create("C:/ProgramData/Outbuilt/" + process.ProcessName);
									Thread.Sleep(500);
									Protection.Error();
								}
								if (process.MainWindowTitle.ToLower().Contains(array[i]) && !whitelist.Contains(process.ProcessName.ToLower()))
								{
									Directory.CreateDirectory("C:/ProgramData/Outbuilt");
									File.Create("C:/ProgramData/Outbuilt/" + process.ProcessName);
									Thread.Sleep(500);
									Protection.Error();
								}
								if (process.MainWindowHandle.ToString().ToLower().Contains(array[i]) && !whitelist.Contains(process.ProcessName.ToLower()))
								{
									Directory.CreateDirectory("C:/ProgramData/Outbuilt");
									File.Create("C:/ProgramData/Outbuilt/" + process.ProcessName);
									Thread.Sleep(500);
									Protection.Error();
								}
								if (Protection.GetModuleHandle("HTTPDebuggerBrowser.dll") != IntPtr.Zero || Protection.GetModuleHandle("FiddlerCore4.dll") != IntPtr.Zero || Protection.GetModuleHandle("RestSharp.dll") != IntPtr.Zero || Protection.GetModuleHandle("Titanium.Web.Proxy.dll") != IntPtr.Zero)
								{
									Directory.CreateDirectory("C:/ProgramData/Outbuilt");
									File.Create("C:/ProgramData/Outbuilt/HTTPDebuggerBrowser");
									Protection.Error();
								}
								if (File.ReadAllText("C:\\WINDOWS\\System32\\Drivers\\Etc\\hosts").Contains(array[i]))
								{
									Directory.CreateDirectory("C:/ProgramData/Outbuilt");
									File.Create("C:/ProgramData/Outbuilt/Hosts Debugger");
									Protection.Error();
								}
								Protection.CheckForAnyProxyConnections();
							}
						}
					}
				}
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00009E84 File Offset: 0x00008084
			private static string[] GetArray()
			{
				return new string[]
				{
					"procmon64",
					"codecracker",
					"x96dbg",
					"pizza",
					"pepper",
					"reverse",
					"reversal",
					"pc-ret",
					"crack",
					"ILSpy",
					"x32dbg",
					"sharpod",
					"x64dbg",
					"x32_dbg",
					"x64_dbg",
					"debug",
					"dbg",
					"strongod",
					"PhantOm",
					"titanHide",
					"scyllaHide",
					"ilspy",
					"graywolf",
					"simpleassemblyexplorer",
					"MegaDumper",
					"megadumper",
					"X64NetDumper",
					"x64netdumper",
					"Protection_ID",
					"protection_id",
					"die",
					"process hacker 2",
					"process",
					"hacker",
					"ollydbg",
					"x32dbg",
					"x64dbg",
					"ida -",
					"charles",
					"dnspy",
					"simpleassembly",
					"peek",
					"httpanalyzer",
					"httpdebug",
					"fiddler",
					"wireshark",
					"proxifier",
					"mitmproxy",
					"process hacker",
					"process monitor",
					"process hacker 2",
					"system explorer",
					"systemexplorer",
					"systemexplorerservice",
					"WPE PRO",
					"ghidra",
					"folderchangesview",
					"pc-ret",
					"folder",
					"dump",
					"proxy",
					"de4dotmodded",
					"StringDecryptor",
					"Centos",
					"SAE",
					"monitor",
					"brute",
					"checker",
					"zed",
					"sniffer",
					"http",
					"debugger",
					"james",
					"exeinfope",
					"codecracker",
					"x32dbg",
					"x64dbg",
					"ollydbg",
					"ida -",
					"charles",
					"dnspy",
					"simpleassembly",
					"peek",
					"httpanalyzer",
					"httpdebug",
					"fiddler",
					"wireshark",
					"dbx",
					"mdbg",
					"gdb",
					"windbg",
					"dbgclr",
					"kdb",
					"kgdb",
					"mdb"
				};
			}
		}
	}
}
