using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns2;
using ns6;
using SAPIENPowerShellWindowsHost;

namespace ns0
{
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
	internal sealed class Class10
	{
		public const int int_0 = 0;

		public const int int_1 = 1;

		public const int int_2 = 2;

		public const int int_3 = 3;

		private Process process_0 = Process.GetCurrentProcess();

		private bool bool_0 = Process.GetCurrentProcess().MainWindowTitle.Contains("PrimalScript");

		private const uint uint_0 = 2032u;

		public string string_0 = "";

		private Class21 class21_0;

		public Runspace runspace_0;

		private bool bool_1 = true;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5;

		private ArrayList arrayList_0 = new ArrayList();

		public string string_6 = "PowerShell Package";

		public string string_7 = "";

		public string string_8 = "";

		public string string_9;

		public int int_4;

		private bool bool_2 = true;

		private int int_5 = 2;

		private int int_6 = 80;

		public bool IsPowerShellInstalled
		{
			get
			{
				if (((string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PowerShell\\1\\PowerShellEngine", "ApplicationBase", "")).Length == 0)
				{
					bool_1 = false;
					return false;
				}
				return bool_1;
			}
		}

		public int OutputMode
		{
			get
			{
				return int_5;
			}
			set
			{
				if (value >= 0 && value <= 3)
				{
					int_5 = value;
				}
			}
		}

		public ArrayList Output => arrayList_0;

		public int OutputWidth
		{
			get
			{
				return int_6;
			}
			set
			{
				int_6 = value;
			}
		}

		public string OutputString
		{
			get
			{
				//Discarded unreachable code: IL_0014, IL_0052
				StringBuilder stringBuilder = new StringBuilder();
				IEnumerator enumerator = arrayList_0.GetEnumerator();
				/*Error near IL_0012: Could not find block for branch target IL_0037*/;
			}
		}

		[DllImport("User32.dll")]
		public static extern uint SendMessage(uint uint_1, uint uint_2, IntPtr intptr_0, string string_10);

		public bool method_0(bool bool_3, int int_7)
		{
			bool flag = false;
			bool_1 = true;
			bool_2 = bool_3;
			if (bool_3)
			{
				method_2();
			}
			flag = true;
			class21_0 = new Class21();
			if (int_7 == 1)
			{
				InitialSessionState initialSessionState = InitialSessionState.CreateDefault();
				initialSessionState.ApartmentState = ApartmentState.STA;
				initialSessionState.ThreadOptions = PSThreadOptions.ReuseThread;
				runspace_0 = RunspaceFactory.CreateRunspace(class21_0, initialSessionState);
				Runspace.DefaultRunspace = runspace_0;
			}
			else
			{
				runspace_0 = RunspaceFactory.CreateRunspace(class21_0);
				Runspace.DefaultRunspace = runspace_0;
			}
			runspace_0.Open();
			Pipeline pipeline = runspace_0.CreatePipeline();
			try
			{
				if (bool_3 && string_5.Length != 0)
				{
					pipeline.Commands.AddScript(string_5);
					pipeline.Commands.Add("out-default");
					pipeline.Commands[0].MergeMyResults(PipelineResultTypes.Error, PipelineResultTypes.Output);
					pipeline.Invoke();
				}
			}
			catch (Exception ex)
			{
				string_0 = ex.Message;
				flag = false;
			}
			string_0 = "";
			return flag;
		}

		private string method_1(string string_10)
		{
			//Discarded unreachable code: IL_000f, IL_003c
			StringBuilder stringBuilder = new StringBuilder();
			StreamReader streamReader = new StreamReader(string_10);
			/*Error near IL_000d: Could not find block for branch target IL_0026*/;
		}

		private int method_2()
		{
			if (!bool_2)
			{
				return 0;
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(folderPath);
			stringBuilder.Append("\\WindowsPowerShell\\v1.0\\profile.ps1");
			string_1 = stringBuilder.ToString();
			stringBuilder.Remove(0, stringBuilder.Length);
			stringBuilder.Append(folderPath);
			stringBuilder.Append("\\WindowsPowerShell\\v1.0\\Microsoft.PowerShell_profile.ps1");
			string_2 = stringBuilder.ToString();
			stringBuilder.Remove(0, stringBuilder.Length);
			stringBuilder.Append(folderPath2);
			stringBuilder.Append("\\WindowsPowerShell\\profile.ps1");
			string_3 = stringBuilder.ToString();
			stringBuilder.Remove(0, stringBuilder.Length);
			stringBuilder.Append(folderPath2);
			stringBuilder.Append("\\WindowsPowerShell\\Microsoft.PowerShell_profile.ps1");
			string_4 = stringBuilder.ToString();
			if (File.Exists(string_1))
			{
				string text = (string_1 = method_1(string_1));
			}
			else
			{
				string_1 = "";
			}
			if (File.Exists(string_2))
			{
				string text = (string_2 = method_1(string_2));
			}
			else
			{
				string_2 = "";
			}
			if (File.Exists(string_3))
			{
				string text = (string_3 = method_1(string_3));
			}
			else
			{
				string_3 = "";
			}
			if (File.Exists(string_4))
			{
				string text = (string_4 = method_1(string_4));
			}
			else
			{
				string_4 = "";
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append(string_1);
			stringBuilder2.Append(string_2);
			stringBuilder2.Append(string_3);
			stringBuilder2.Append(string_4);
			string_5 = stringBuilder2.ToString();
			return 0;
		}

		private static List<CommandParameter> smethod_0(string[] string_10, char char_0 = '-')
		{
			List<CommandParameter> list = new List<CommandParameter>();
			for (int i = 0; i < string_10.Length; i++)
			{
				string text = string_10[i];
				if (string.IsNullOrEmpty(text))
				{
					continue;
				}
				if (text[0] == char_0)
				{
					text = text.Substring(1, text.Length - 1);
					string text2 = null;
					if (i + 1 < string_10.Length && !string.IsNullOrEmpty(string_10[i + 1]))
					{
						text2 = string_10[i + 1];
						if (text2[0] != char_0)
						{
							i++;
						}
						else
						{
							text2 = null;
						}
					}
					list.Add(new CommandParameter(text, text2));
				}
				else
				{
					list.Add(new CommandParameter(null, text));
				}
			}
			return list;
		}

		public void method_3(string string_10, string[] string_11)
		{
			Size bufferSize = default(Size);
			if (!bool_1)
			{
				return;
			}
			Pipeline pipeline = runspace_0.CreatePipeline();
			try
			{
				bufferSize.Height = 25;
				bufferSize.Width = int_6;
				class21_0.UI.RawUI.BufferSize = bufferSize;
				Class22 obj = (Class22)class21_0.UI;
				obj.int_4 = int_5;
				obj.string_0 = string_6;
				obj.arrayList_0 = arrayList_0;
				obj.bool_1 = string_10.Contains("#pragma SuppressProgress");
				Class20 value = new Class20(string_8);
				SAPIENHost value2 = new SAPIENHost();
				runspace_0.SessionStateProxy.SetVariable("SAPIENHost", value2);
				runspace_0.SessionStateProxy.SetVariable("HostInvocation", value);
				runspace_0.SessionStateProxy.SetVariable("CommandLine", string_9);
				runspace_0.SessionStateProxy.SetVariable("EngineArgs", string_11);
				string directoryName = Path.GetDirectoryName(string_8);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("$PSScriptRoot = \"{0}\"\r\n", directoryName);
				stringBuilder.AppendFormat("$PSCommandPath = \"{0}\"\r\n", string_8);
				string_10 = string_10.Replace("#SAPIENPRESETS", stringBuilder.ToString());
				if (string_7.Length != 0)
				{
					runspace_0.SessionStateProxy.SetVariable("DataPath", string_7);
				}
				runspace_0.SessionStateProxy.SetVariable("ConsoleOutput", arrayList_0);
				pipeline.Commands.AddScript(string_10);
				pipeline.Commands.Add("out-default");
				pipeline.Commands[0].MergeMyResults(PipelineResultTypes.Error, PipelineResultTypes.Output);
				foreach (CommandParameter item in smethod_0(string_11))
				{
					pipeline.Commands[0].Parameters.Add(item);
				}
				pipeline.Invoke();
				string text = method_6("$ExitCode");
				if (text.Length != 0)
				{
					int_4 = int.Parse(text);
				}
				else
				{
					int_4 = 0;
				}
			}
			catch (RuntimeException ex)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.AppendFormat("Line {0}: {1}", ex.ErrorRecord.InvocationInfo.ScriptLineNumber + 1, ex.Message);
				string string_12 = stringBuilder2.ToString();
				method_7(string_12);
			}
			catch (Exception)
			{
			}
			bufferSize.Height = 25;
			bufferSize.Width = 400;
			class21_0.UI.RawUI.BufferSize = bufferSize;
			class21_0.method_0();
		}

		public bool method_4(string string_10)
		{
			if (!bool_1)
			{
				return false;
			}
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("$result = (");
				stringBuilder.Append(string_10);
				stringBuilder.Append("); if($result) { \"true\"} else {\"false\" }");
				return runspace_0.CreatePipeline(stringBuilder.ToString()).Invoke()[0].ToString().Trim().CompareTo("true") == 0;
			}
			catch (RuntimeException ex)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.AppendFormat("Line {0}: {1}", ex.ErrorRecord.InvocationInfo.ScriptLineNumber + 1, ex.Message);
				string string_11 = stringBuilder2.ToString();
				method_7(string_11);
			}
			catch (Exception)
			{
			}
			return false;
		}

		public void method_5()
		{
			arrayList_0.Clear();
		}

		public string method_6(string string_10)
		{
			string result = "";
			if (!bool_1)
			{
				return result;
			}
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(string_10);
				result = runspace_0.CreatePipeline(stringBuilder.ToString()).Invoke()[0].ToString().Trim();
				return result;
			}
			catch (RuntimeException ex)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.AppendFormat("Line {0}: {1}", ex.ErrorRecord.InvocationInfo.ScriptLineNumber + 1, ex.Message);
				string string_11 = stringBuilder2.ToString();
				method_7(string_11);
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		public void method_7(string string_10)
		{
			if ((bool_0 && int_5 == 0) || int_5 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, string_10);
				return;
			}
			switch (int_5)
			{
			case 0:
				Console.Write(string_10);
				break;
			case 1:
				MessageBox.Show(string_10, string_6);
				break;
			case 2:
				arrayList_0.Add(string_10);
				break;
			}
		}
	}
}
