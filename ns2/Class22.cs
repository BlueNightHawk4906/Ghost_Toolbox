using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ns0;
using ns1;
using ns4;
using ns5;

namespace ns2
{
	internal sealed class Class22 : PSHostUserInterface
	{
		private Process process_0 = Process.GetCurrentProcess();

		private bool bool_0 = Process.GetCurrentProcess().MainWindowTitle.Contains("PrimalScript");

		public const int int_0 = 0;

		public const int int_1 = 1;

		public const int int_2 = 2;

		public const int int_3 = 3;

		private const uint uint_0 = 2032u;

		private Dictionary<long, Progress> dictionary_0 = new Dictionary<long, Progress>();

		public ArrayList arrayList_0;

		public int int_4;

		public string string_0;

		public bool bool_1 = true;

		private Class23 class23_0 = new Class23();

		PSHostRawUserInterface PSHostUserInterface.RawUI => class23_0;

		[DllImport("User32.dll")]
		public static extern uint SendMessage(uint uint_1, uint uint_2, IntPtr intptr_0, string string_1);

		Dictionary<string, PSObject> PSHostUserInterface.Prompt(string caption, string message, Collection<FieldDescription> descriptions)
		{
			//Discarded unreachable code: IL_0043, IL_01b6, IL_01be
			CPrompt cPrompt = new CPrompt();
			cPrompt.string_0 = caption;
			if (cPrompt.string_0.Length == 0)
			{
				cPrompt.string_0 = "Prompt";
			}
			cPrompt.m_Message.Text = message;
			Dictionary<string, PSObject> dictionary = new Dictionary<string, PSObject>();
			IEnumerator<FieldDescription> enumerator = descriptions.GetEnumerator();
			/*Error near IL_003e: Could not find block for branch target IL_0169*/;
		}

		int PSHostUserInterface.PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
		{
			int num = -1;
			PromptChoiceDlg promptChoiceDlg = new PromptChoiceDlg();
			promptChoiceDlg.m_Message.Text = message;
			promptChoiceDlg.string_0 = caption;
			for (int i = 0; i < choices.Count; i++)
			{
				string label = choices[i].Label;
				label = label.Replace("&", string.Empty);
				promptChoiceDlg.m_Choices.Items.Add(label);
			}
			promptChoiceDlg.ShowDialog();
			num = promptChoiceDlg.int_0;
			promptChoiceDlg.Dispose();
			return num;
		}

		PSCredential PSHostUserInterface.PromptForCredential(string caption, string message, string userName, string targetName)
		{
			if (caption.Length == 0)
			{
				caption = "Windows PowerShell Credential Request";
			}
			if (message.Length == 0)
			{
				message = "Enter your credentials";
			}
			Class17 @class;
			try
			{
				@class = ((targetName.Length == 0) ? Class12.smethod_21(" ", caption, message, userName, "") : Class12.smethod_21(targetName, caption, message, userName, ""));
			}
			catch (Exception)
			{
				return null;
			}
			if (@class == null)
			{
				return null;
			}
			char[] array = @class.Password.ToCharArray();
			SecureString secureString = new SecureString();
			char[] array2 = array;
			foreach (char c in array2)
			{
				secureString.AppendChar(c);
			}
			return new PSCredential(@class.UserName, secureString);
		}

		PSCredential PSHostUserInterface.PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options)
		{
			if (caption.Length == 0)
			{
				caption = "Windows PowerShell Credential Request";
			}
			if (message.Length == 0)
			{
				message = "Enter your credentials";
			}
			Class17 @class;
			try
			{
				@class = ((targetName.Length == 0) ? Class12.smethod_21(" ", caption, message, userName, "") : Class12.smethod_21(targetName, caption, message, userName, ""));
			}
			catch (Exception)
			{
				return null;
			}
			if (@class == null)
			{
				return null;
			}
			char[] array = @class.Password.ToCharArray();
			SecureString secureString = new SecureString();
			char[] array2 = array;
			foreach (char c in array2)
			{
				secureString.AppendChar(c);
			}
			return new PSCredential(@class.UserName, secureString);
		}

		string PSHostUserInterface.ReadLine()
		{
			CPrompt cPrompt = new CPrompt();
			cPrompt.string_0 = "PowerShell Input";
			cPrompt.m_Message.Text = "Please enter text input";
			cPrompt.m_Field.Text = "";
			cPrompt.ShowDialog();
			string text = cPrompt.m_Text.Text;
			cPrompt.Dispose();
			return text;
		}

		SecureString PSHostUserInterface.ReadLineAsSecureString()
		{
			CPrompt cPrompt = new CPrompt();
			cPrompt.string_0 = "PowerShell Secure Input";
			cPrompt.m_Message.Text = "Please enter text";
			cPrompt.m_Field.Text = "";
			cPrompt.bool_0 = true;
			cPrompt.ShowDialog();
			char[] array = cPrompt.m_Text.Text.ToCharArray();
			SecureString secureString = new SecureString();
			char[] array2 = array;
			foreach (char c in array2)
			{
				secureString.AppendChar(c);
			}
			cPrompt.Dispose();
			return secureString;
		}

		void PSHostUserInterface.Write(string value)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, value);
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.Write(value);
				break;
			case 1:
				if (value.Length != 0)
				{
					MessageBox.Show(value, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(value);
				break;
			}
		}

		void PSHostUserInterface.Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, value);
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.Write(value);
				break;
			case 1:
				if (value.Length != 0)
				{
					MessageBox.Show(value, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(value);
				break;
			}
		}

		void PSHostUserInterface.WriteDebugLine(string message)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, string.Format(CultureInfo.CurrentCulture, "DEBUG: {0}", new object[1] { message }));
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "DEBUG: {0}", new object[1] { message }));
				break;
			case 1:
				if (message.Length != 0)
				{
					MessageBox.Show(message, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(message);
				break;
			}
		}

		void PSHostUserInterface.WriteErrorLine(string value)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, string.Format(CultureInfo.CurrentCulture, "ERROR: {0}", new object[1] { value }));
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "ERROR: {0}", new object[1] { value }));
				break;
			case 1:
				if (value.Length != 0)
				{
					MessageBox.Show(value, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(value);
				break;
			}
		}

		void PSHostUserInterface.WriteLine()
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, "");
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.WriteLine();
				break;
			case 2:
				arrayList_0.Add("");
				break;
			case 1:
				break;
			}
		}

		void PSHostUserInterface.WriteLine(string value)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, value);
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.WriteLine(value);
				break;
			case 1:
				if (value.Length != 0)
				{
					MessageBox.Show(value, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(value);
				break;
			}
		}

		void PSHostUserInterface.WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, value);
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.WriteLine(value);
				break;
			case 1:
				if (value.Length != 0)
				{
					MessageBox.Show(value, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(value);
				break;
			}
		}

		public void method_0()
		{
			//Discarded unreachable code: IL_000e, IL_003e
			Dictionary<long, Progress>.Enumerator enumerator = dictionary_0.GetEnumerator();
			/*Error near IL_000c: Could not find block for branch target IL_0025*/;
		}

		void PSHostUserInterface.WriteProgress(long sourceId, ProgressRecord record)
		{
			if (bool_1)
			{
				return;
			}
			if (record.RecordType == ProgressRecordType.Completed && int_4 != 1)
			{
				if ((bool_0 && int_4 == 0) || int_4 == 3)
				{
					SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, record.StatusDescription);
				}
				else
				{
					switch (int_4)
					{
					case 2:
						arrayList_0.Add(record.StatusDescription);
						break;
					case 0:
						Console.WriteLine(record.StatusDescription);
						break;
					}
				}
			}
			if (int_4 != 1)
			{
				return;
			}
			if (dictionary_0.TryGetValue(sourceId, out var value))
			{
				if (record.RecordType == ProgressRecordType.Completed)
				{
					dictionary_0.Remove(sourceId);
					value.Dispose();
					Application.DoEvents();
				}
				else if (!value.IsHandleCreated)
				{
					dictionary_0.Remove(sourceId);
					value.Dispose();
					value = new Progress();
					value.string_0 = record.Activity;
					value.long_0 = sourceId;
					value.m_Operation.Text = record.CurrentOperation;
					if (record.SecondsRemaining != -1)
					{
						value.m_Remaining.Text = record.SecondsRemaining + "s remaining";
					}
					else
					{
						value.m_Remaining.Text = "";
					}
					value.m_Status.Text = record.StatusDescription;
					dictionary_0.Add(sourceId, value);
					value.Show();
					Application.DoEvents();
					if (record.PercentComplete != -1)
					{
						value.method_0(record.PercentComplete);
					}
					else
					{
						value.method_0(0);
					}
					Application.DoEvents();
				}
				else
				{
					value.string_0 = record.Activity;
					value.long_0 = sourceId;
					value.m_Operation.Text = record.CurrentOperation;
					if (record.SecondsRemaining != -1)
					{
						value.m_Remaining.Text = record.SecondsRemaining + "s remaining";
					}
					value.m_Status.Text = record.StatusDescription;
					if (record.PercentComplete != -1)
					{
						value.method_0(record.PercentComplete);
					}
					value.Update();
					Application.DoEvents();
				}
			}
			else if (record.RecordType != ProgressRecordType.Completed)
			{
				value = new Progress();
				value.string_0 = record.Activity;
				value.long_0 = sourceId;
				value.m_Operation.Text = record.CurrentOperation;
				if (record.SecondsRemaining != -1)
				{
					value.m_Remaining.Text = record.SecondsRemaining + "s remaining";
				}
				else
				{
					value.m_Remaining.Text = "";
				}
				value.m_Status.Text = record.StatusDescription;
				dictionary_0.Add(sourceId, value);
				value.Show();
				Application.DoEvents();
				if (record.PercentComplete != -1)
				{
					value.method_0(record.PercentComplete);
				}
				else
				{
					value.method_0(0);
				}
				Application.DoEvents();
			}
		}

		void PSHostUserInterface.WriteVerboseLine(string message)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, string.Format(CultureInfo.CurrentCulture, "VERBOSE: {0}", new object[1] { message }));
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "VERBOSE: {0}", new object[1] { message }));
				break;
			case 1:
				if (message.Length != 0)
				{
					MessageBox.Show(message, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(message);
				break;
			}
		}

		void PSHostUserInterface.WriteWarningLine(string message)
		{
			if ((bool_0 && int_4 == 0) || int_4 == 3)
			{
				SendMessage((uint)(int)process_0.MainWindowHandle, 2032u, (IntPtr)5, string.Format(CultureInfo.CurrentCulture, "WARNING: {0}", new object[1] { message }));
				return;
			}
			switch (int_4)
			{
			case 0:
				Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "WARNING: {0}", new object[1] { message }));
				break;
			case 1:
				if (message.Length != 0)
				{
					MessageBox.Show(message, string_0);
				}
				break;
			case 2:
				arrayList_0.Add(message);
				break;
			}
		}
	}
}
