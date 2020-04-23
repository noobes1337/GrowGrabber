using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Outbuilt
{
	// Token: 0x02000011 RID: 17
	internal class AntiDumps
	{
		// Token: 0x0600007D RID: 125
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x0600007E RID: 126
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x0600007F RID: 127 RVA: 0x00008714 File Offset: 0x00006914
		private static void EraseSection(IntPtr address, int size)
		{
			IntPtr sz = (IntPtr)size;
			IntPtr dwOld = 0;
			AntiDumps.VirtualProtect(address, sz, (IntPtr)64, ref dwOld);
			AntiDumps.ZeroMemory(address, sz);
			IntPtr temp = 0;
			AntiDumps.VirtualProtect(address, sz, dwOld, ref temp);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000875C File Offset: 0x0000695C
		public static void AntiDump()
		{
			IntPtr base_address = Process.GetCurrentProcess().MainModule.BaseAddress;
			int dwpeheader = Marshal.ReadInt32((IntPtr)(base_address.ToInt32() + 60));
			short wnumberofsections = Marshal.ReadInt16((IntPtr)(base_address.ToInt32() + dwpeheader + 6));
			AntiDumps.EraseSection(base_address, 30);
			for (int i = 0; i < AntiDumps.peheaderdwords.Length; i++)
			{
				AntiDumps.EraseSection((IntPtr)(base_address.ToInt32() + dwpeheader + AntiDumps.peheaderdwords[i]), 4);
			}
			for (int j = 0; j < AntiDumps.peheaderwords.Length; j++)
			{
				AntiDumps.EraseSection((IntPtr)(base_address.ToInt32() + dwpeheader + AntiDumps.peheaderwords[j]), 2);
			}
			for (int k = 0; k < AntiDumps.peheaderbytes.Length; k++)
			{
				AntiDumps.EraseSection((IntPtr)(base_address.ToInt32() + dwpeheader + AntiDumps.peheaderbytes[k]), 1);
			}
			int x = 0;
			int y = 0;
			while (x <= (int)wnumberofsections)
			{
				if (y == 0)
				{
					AntiDumps.EraseSection((IntPtr)(base_address.ToInt32() + dwpeheader + 250 + 40 * x + 32), 2);
				}
				AntiDumps.EraseSection((IntPtr)(base_address.ToInt32() + dwpeheader + 250 + 40 * x + AntiDumps.sectiontabledwords[y]), 4);
				y++;
				if (y == AntiDumps.sectiontabledwords.Length)
				{
					x++;
					y = 0;
				}
			}
		}

		// Token: 0x04000079 RID: 121
		private static int[] sectiontabledwords = new int[]
		{
			8,
			12,
			16,
			20,
			24,
			28,
			36
		};

		// Token: 0x0400007A RID: 122
		private static int[] peheaderbytes = new int[]
		{
			26,
			27
		};

		// Token: 0x0400007B RID: 123
		private static int[] peheaderwords = new int[]
		{
			4,
			22,
			24,
			64,
			66,
			68,
			70,
			72,
			74,
			76,
			92,
			94
		};

		// Token: 0x0400007C RID: 124
		private static int[] peheaderdwords = new int[]
		{
			0,
			8,
			12,
			16,
			22,
			28,
			32,
			40,
			44,
			52,
			60,
			76,
			80,
			84,
			88,
			96,
			100,
			104,
			108,
			112,
			116,
			260,
			264,
			268,
			272,
			276,
			284
		};
	}
}
