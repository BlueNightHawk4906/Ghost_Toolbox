using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using ns2;
using ns4;

namespace ns3
{
	internal sealed class Class2 : Class1
	{
		[CompilerGenerated]
		private sealed class Class4
		{
			public GroupPolicySection groupPolicySection_0;

			public string string_0;

			public string string_1;

			public string string_2;

			public RegistryValueKind registryValueKind_0;

			public Exception exception_0;

			internal void method_0()
			{
				try
				{
					Class2 @class = new Class2();
					using (RegistryKey registryKey = @class.method_2(groupPolicySection_0))
					{
						if (string_0 == null)
						{
							using (RegistryKey registryKey2 = registryKey.OpenSubKey(string_1, writable: true))
							{
								registryKey2?.DeleteValue(string_2);
							}
						}
						else
						{
							using (RegistryKey registryKey3 = registryKey.CreateSubKey(string_1))
							{
								registryKey3.SetValue(string_2, string_0, registryValueKind_0);
							}
						}
					}
					@class.method_0();
				}
				catch (Exception ex)
				{
					Exception ex2 = (exception_0 = ex);
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class5
		{
			public GroupPolicySection groupPolicySection_0;

			public string string_0;

			public object object_0;

			public string string_1;

			internal void method_0()
			{
				using (RegistryKey registryKey = new Class2(new Class3(loadRegistryInfo: true, readOnly: true)).method_2(groupPolicySection_0))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(string_0, writable: true))
					{
						if (registryKey2 == null)
						{
							object_0 = null;
						}
						else
						{
							object_0 = registryKey2.GetValue(string_1);
						}
					}
				}
			}
		}

		public readonly bool bool_0;

		public Class2(Class3 options = null)
		{
			options = options ?? new Class3();
			if (ginterface0_0.imethod_2(options.Flag) != 0)
			{
				throw new Exception("Unable to open local machine GPO");
			}
			bool_0 = true;
		}

		public Class2(string computerName, Class3 options = null)
		{
			options = options ?? new Class3();
			if (ginterface0_0.imethod_3(computerName, options.Flag) != 0)
			{
				throw new Exception($"Unable to open GPO on remote machine '{computerName}'");
			}
			bool_0 = false;
		}

		public static void smethod_2(string string_0, string string_1, RegistryValueKind registryValueKind_0)
		{
			string string_3;
			GroupPolicySection groupPolicySection_0;
			string string_2 = smethod_4(string_0, out string_3, out groupPolicySection_0);
			Exception exception_0 = null;
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					Class2 @class = new Class2();
					using (RegistryKey registryKey = @class.method_2(groupPolicySection_0))
					{
						if (string_1 == null)
						{
							using (RegistryKey registryKey2 = registryKey.OpenSubKey(string_2, writable: true))
							{
								registryKey2?.DeleteValue(string_3);
							}
						}
						else
						{
							using (RegistryKey registryKey3 = registryKey.CreateSubKey(string_2))
							{
								registryKey3.SetValue(string_3, string_1, registryValueKind_0);
							}
						}
					}
					@class.method_0();
				}
				catch (Exception ex)
				{
					exception_0 = ex;
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			if (exception_0 != null)
			{
				throw exception_0;
			}
		}

		public static object smethod_3(string string_0)
		{
			string string_2;
			GroupPolicySection groupPolicySection_0;
			string string_ = smethod_4(string_0, out string_2, out groupPolicySection_0);
			object object_0 = null;
			Thread thread = new Thread((ThreadStart)delegate
			{
				using (RegistryKey registryKey = new Class2(new Class3(loadRegistryInfo: true, readOnly: true)).method_2(groupPolicySection_0))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(string_, writable: true))
					{
						if (registryKey2 == null)
						{
							object_0 = null;
						}
						else
						{
							object_0 = registryKey2.GetValue(string_2);
						}
					}
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			return object_0;
		}

		private static string smethod_4(string string_0, out string string_1, out GroupPolicySection groupPolicySection_0)
		{
			string[] array = string_0.Split('!');
			string text = array[0];
			string text2 = text.Substring(0, text.IndexOf('\\'));
			text = text.Substring(text.IndexOf('\\') + 1);
			string_1 = array[1];
			if (!text2.Equals("HKLM", StringComparison.OrdinalIgnoreCase) && !text2.Equals("HKEY_LOCAL_MACHINE", StringComparison.OrdinalIgnoreCase))
			{
				groupPolicySection_0 = GroupPolicySection.User;
			}
			else
			{
				groupPolicySection_0 = GroupPolicySection.Machine;
			}
			return text;
		}

		public override string vmethod_0(GroupPolicySection groupPolicySection_0)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			if (ginterface0_0.imethod_11((uint)groupPolicySection_0, stringBuilder, 1024) != 0)
			{
				throw new Exception($"Unable to retrieve path to section '{Enum.GetName(typeof(GroupPolicySection), groupPolicySection_0)}'");
			}
			return stringBuilder.ToString();
		}
	}
}
