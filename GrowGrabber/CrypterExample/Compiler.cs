using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace CrypterExample
{
	// Token: 0x0200000E RID: 14
	internal class Compiler
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00008470 File Offset: 0x00006670
		public static bool CompileFromSource(string source, string Output, string Icon = null, string[] Resources = null)
		{
			CompilerParameters CParams = new CompilerParameters();
			CParams.GenerateExecutable = true;
			CParams.OutputAssembly = Output;
			string options = "/optimize+ /platform:x86 /target:winexe /unsafe";
			if (Icon != null)
			{
				options = options + " /win32icon:\"" + Icon + "\"";
			}
			CParams.CompilerOptions = options;
			CParams.TreatWarningsAsErrors = false;
			CParams.ReferencedAssemblies.Add("System.dll");
			CParams.ReferencedAssemblies.Add("System.Windows.Forms.dll");
			CParams.ReferencedAssemblies.Add("System.Drawing.dll");
			CParams.ReferencedAssemblies.Add("System.Data.dll");
			CParams.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
			if (Resources != null && Resources.Length != 0)
			{
				foreach (string res in Resources)
				{
					CParams.EmbeddedResources.Add(res);
				}
			}
			CompilerResults Results = new CSharpCodeProvider(new Dictionary<string, string>
			{
				{
					"CompilerVersion",
					"v2.0"
				}
			}).CompileAssemblyFromSource(CParams, new string[]
			{
				source
			});
			if (Results.Errors.Count > 0)
			{
				MessageBox.Show(string.Format("The compiler has encountered {0} errors", Results.Errors.Count), "Errors while compiling", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				foreach (object obj in Results.Errors)
				{
					CompilerError Err = (CompilerError)obj;
					MessageBox.Show(string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", new object[]
					{
						Err.ErrorText,
						Err.Line,
						Err.Column,
						Err.FileName
					}), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				return false;
			}
			return true;
		}
	}
}
