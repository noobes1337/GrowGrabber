using System;
using System.Runtime.InteropServices;

namespace CrypterExample
{
	// Token: 0x02000010 RID: 16
	internal class Writer
	{
		// Token: 0x06000078 RID: 120
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr BeginUpdateResource(string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

		// Token: 0x06000079 RID: 121
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool UpdateResource(IntPtr hUpdate, string lpType, string lpName, ushort wLanguage, IntPtr lpData, uint cbData);

		// Token: 0x0600007A RID: 122
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);

		// Token: 0x0600007B RID: 123 RVA: 0x000086B8 File Offset: 0x000068B8
		public static Writer.ICResult WriteResource(string FileName, byte[] FileBytes)
		{
			IntPtr hUpdate = Writer.BeginUpdateResource(FileName, false);
			if (!Writer.UpdateResource(hUpdate, "RT_RCDATA", "Encrypted", 1066, GCHandle.Alloc(FileBytes, GCHandleType.Pinned).AddrOfPinnedObject(), Convert.ToUInt32(FileBytes.Length)))
			{
				return Writer.ICResult.FailUpdate;
			}
			if (!Writer.EndUpdateResource(hUpdate, false))
			{
				return Writer.ICResult.FailEnd;
			}
			return Writer.ICResult.Success;
		}

		// Token: 0x0200001A RID: 26
		public enum ICResult
		{
			// Token: 0x04000099 RID: 153
			Success,
			// Token: 0x0400009A RID: 154
			FailBegin,
			// Token: 0x0400009B RID: 155
			FailUpdate,
			// Token: 0x0400009C RID: 156
			FailEnd
		}
	}
}
