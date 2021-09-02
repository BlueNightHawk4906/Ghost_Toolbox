using System;
using Microsoft.Win32;
using ns3;

namespace ns5
{
	internal sealed class Class6
	{
		public enum Enum0
		{
			const_0,
			const_1,
			const_2
		}

		public static Enum0 smethod_0()
		{
			int num = -1;
			try
			{
				num = (int)Class2.smethod_3("HKCU\\Software\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription!EnableTranscripting");
			}
			catch (Exception)
			{
				num = -1;
			}
			if (num > 0)
			{
				return Enum0.const_2;
			}
			if (num == 0)
			{
				return Enum0.const_1;
			}
			return Enum0.const_0;
		}

		public static Enum0 smethod_1()
		{
			int num = -1;
			try
			{
				num = (int)Class2.smethod_3("HKCU\\Software\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging!EnableScriptBlockLogging");
			}
			catch (Exception)
			{
				num = -1;
			}
			if (num > 0)
			{
				return Enum0.const_2;
			}
			if (num == 0)
			{
				return Enum0.const_1;
			}
			return Enum0.const_0;
		}

		public static Enum0 smethod_2()
		{
			int num = -1;
			try
			{
				num = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", -1);
			}
			catch (Exception)
			{
				num = -2;
			}
			if (num == -2)
			{
				try
				{
					string text = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", "-1");
					num = ((text != null) ? Convert.ToInt32(text) : (-2));
				}
				catch (Exception)
				{
					num = -2;
				}
			}
			if (num <= 0)
			{
				switch (num)
				{
				case 0:
					return Enum0.const_1;
				default:
					return Enum0.const_0;
				case -1:
					break;
				}
			}
			return Enum0.const_2;
		}

		public static Enum0 smethod_3()
		{
			int num = -1;
			try
			{
				num = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", -1);
			}
			catch (Exception)
			{
				num = -2;
			}
			if (num == -2)
			{
				try
				{
					string text = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", "-1");
					num = ((text != null) ? Convert.ToInt32(text) : (-2));
				}
				catch (Exception)
				{
					num = -2;
				}
			}
			if (num <= 0)
			{
				switch (num)
				{
				case 0:
					return Enum0.const_1;
				default:
					return Enum0.const_0;
				case -1:
					break;
				}
			}
			return Enum0.const_2;
		}

		public static Enum0 smethod_4()
		{
			int num = -1;
			try
			{
				num = (int)Class2.smethod_3("HKCU\\Software\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging!EnableScriptBlockLogging");
			}
			catch (Exception)
			{
				num = -1;
			}
			if (num > 0)
			{
				Class2.smethod_2("HKCU\\Software\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging!EnableScriptBlockLogging", "0", RegistryValueKind.DWord);
			}
			if (num > 0)
			{
				return Enum0.const_2;
			}
			if (num == 0)
			{
				return Enum0.const_1;
			}
			return Enum0.const_0;
		}

		public static Enum0 smethod_5()
		{
			int num = -2;
			try
			{
				num = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", -1);
				if (num != 0)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", 0);
				}
			}
			catch (Exception)
			{
				num = -2;
			}
			if (num == -2)
			{
				try
				{
					if ((string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", "-1") != "0")
					{
						Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", "0");
					}
				}
				catch (Exception)
				{
					num = -2;
				}
			}
			if (num <= 0)
			{
				switch (num)
				{
				case 0:
					return Enum0.const_1;
				default:
					return Enum0.const_0;
				case -1:
					break;
				}
			}
			return Enum0.const_2;
		}

		public static Enum0 smethod_6()
		{
			int num = -2;
			try
			{
				num = (int)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", -1);
				if (num != 0)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", 0);
				}
			}
			catch (Exception)
			{
				num = -2;
			}
			if (num == -2)
			{
				try
				{
					if ((string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", "-1") != "0")
					{
						Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", "0");
					}
				}
				catch (Exception)
				{
					num = -2;
				}
			}
			if (num <= 0)
			{
				switch (num)
				{
				case 0:
					return Enum0.const_1;
				default:
					return Enum0.const_0;
				case -1:
					break;
				}
			}
			return Enum0.const_2;
		}

		public static bool smethod_7(Enum0 enum0_0)
		{
			try
			{
				switch (enum0_0)
				{
				case Enum0.const_0:
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell", writable: true);
					registryKey.DeleteSubKeyTree("ScriptBlockLogging");
					registryKey.Close();
					break;
				}
				case Enum0.const_1:
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", 0);
					break;
				case Enum0.const_2:
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging", "EnableScriptBlockLogging", 1);
					break;
				}
			}
			catch (Exception)
			{
			}
			return true;
		}

		public static bool smethod_8(Enum0 enum0_0)
		{
			try
			{
				switch (enum0_0)
				{
				case Enum0.const_0:
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell", writable: true);
					registryKey.DeleteSubKeyTree("Transcription");
					registryKey.Close();
					break;
				}
				case Enum0.const_1:
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", 0);
					break;
				case Enum0.const_2:
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\PowerShell\\Transcription", "EnableTranscripting", 1);
					break;
				}
			}
			catch (Exception)
			{
			}
			return true;
		}

		public static bool smethod_9(Enum0 enum0_0)
		{
			try
			{
				switch (enum0_0)
				{
				case Enum0.const_0:
					Class2.smethod_2("HKCU\\Software\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging!EnableScriptBlockLogging", null, RegistryValueKind.Unknown);
					break;
				case Enum0.const_1:
					Class2.smethod_2("HKCU\\Software\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging!EnableScriptBlockLogging", "0", RegistryValueKind.DWord);
					break;
				case Enum0.const_2:
					Class2.smethod_2("HKCU\\Software\\Policies\\Microsoft\\Windows\\PowerShell\\ScriptBlockLogging!EnableScriptBlockLogging", "1", RegistryValueKind.DWord);
					break;
				}
			}
			catch (Exception)
			{
			}
			return true;
		}
	}
}
