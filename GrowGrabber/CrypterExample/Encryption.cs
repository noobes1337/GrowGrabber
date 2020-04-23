using System;
using System.Security.Cryptography;
using System.Text;

namespace CrypterExample
{
	// Token: 0x0200000F RID: 15
	internal class Encryption
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000864C File Offset: 0x0000684C
		public static byte[] AESEncrypt(byte[] input, string Pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] hash = new byte[32];
			byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(Pass));
			Array.Copy(sourceArray, 0, hash, 0, 16);
			Array.Copy(sourceArray, 0, hash, 15, 16);
			rijndaelManaged.Key = hash;
			rijndaelManaged.Mode = CipherMode.ECB;
			return rijndaelManaged.CreateEncryptor().TransformFinalBlock(input, 0, input.Length);
		}
	}
}
