using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns5
{
	internal sealed class Class9
	{
		private const int int_0 = 0;

		private const int int_1 = 1;

		private const int int_2 = 2;

		private const int int_3 = 4;

		private const int int_4 = 8;

		private const int int_5 = 16;

		private const int int_6 = 32;

		private const int int_7 = 64;

		private const int int_8 = 256;

		private const int int_9 = 512;

		public static string string_0;

		public static string string_1;

		public static string string_2;

		public static string string_3;

		public static bool bool_0;

		public static bool bool_1;

		public static bool bool_2;

		public static bool bool_3;

		public static int int_10;

		public static string string_4;

		public static string string_5;

		public static int int_11;

		public static int int_12;

		public static int int_13;

		public static int int_14;

		public static bool bool_4;

		public static bool bool_5;

		public static bool bool_6;

		public static bool bool_7;

		public static bool bool_8;

		public static bool bool_9;

		public static int int_15;

		public static int int_16;

		public static int int_17;

		public static string string_6;

		public static string string_7;

		public static string string_8;

		public static string string_9;

		public static string string_10;

		public static string string_11;

		private static Mutex mutex_0;

		[DllImport("Kernel32.dll")]
		public static extern IntPtr FindResource(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

		[DllImport("Kernel32.dll")]
		public static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("Kernel32.dll")]
		public static extern IntPtr LockResource(IntPtr intptr_0);

		[DllImport("Kernel32.dll")]
		public static extern uint SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

		[DllImport("Kernel32.dll")]
		public static extern bool FreeResource(IntPtr intptr_0);

		[DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string string_12, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, ref int int_18);

		public static string smethod_0(string string_12)
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			int int_ = stringBuilder.Capacity;
			if (string_12.Length > 2 && string_12[1] == ':')
			{
				char c = string_12[0];
				if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) && WNetGetConnection(string_12.Substring(0, 2), stringBuilder, ref int_) == 0)
				{
					new DirectoryInfo(string_12);
					string path = Path.GetFullPath(string_12).Substring(Path.GetPathRoot(string_12).Length);
					return Path.Combine(stringBuilder.ToString().TrimEnd(), path);
				}
			}
			return string_12;
		}

		public unsafe static void smethod_1(IntPtr intptr_0)
		{
			IntPtr intPtr = FindResource(intptr_0, new IntPtr(1), new IntPtr(10));
			uint num = SizeofResource(intptr_0, intPtr);
			byte[] array = new byte[num];
			byte[] array2 = new byte[512];
			IntPtr source = LockResource(LoadResource(intptr_0, intPtr));
			int num2 = -1;
			Marshal.Copy(source, array, 0, (int)num);
			bool_0 = array[1816] != 0;
			bool_1 = array[1820] != 0;
			bool_2 = array[1824] != 0;
			bool_3 = array[1828] != 0;
			int_10 = BitConverter.ToInt32(array, 1832);
			int_11 = BitConverter.ToInt32(array, 2092);
			int_12 = BitConverter.ToInt32(array, 2096);
			int_13 = BitConverter.ToInt32(array, 2100);
			if ((int_13 & 1) == 1)
			{
				int_14 |= 1;
			}
			if ((int_13 & 4) == 4)
			{
				bool_4 = true;
			}
			if ((int_13 & 2) == 2)
			{
				bool_5 = true;
			}
			if ((int_13 & 8) == 8)
			{
				bool_7 = true;
			}
			if ((int_13 & 0x20) == 32)
			{
				bool_8 = true;
			}
			if ((int_13 & 0x40) == 64)
			{
				bool_9 = true;
			}
			if ((int_13 & 0x200) == 512)
			{
				bool_6 = true;
			}
			int_15 = BitConverter.ToInt32(array, 2104);
			int_16 = BitConverter.ToInt32(array, 2108);
			fixed (byte* ptr = &array[2112])
			{
				int_17 = *(int*)ptr;
			}
			string_0 = Encoding.Unicode.GetString(array);
			num2 = string_0.IndexOf('\0');
			if (num2 != -1)
			{
				string_0 = string_0.Substring(0, num2);
			}
			Array.Copy(array, 256, array2, 0, 512);
			string_1 = Encoding.Unicode.GetString(array2);
			num2 = string_1.IndexOf('\0');
			if (num2 != -1)
			{
				string_1 = string_1.Substring(0, num2);
			}
			Array.Copy(array, 776, array2, 0, 512);
			string_2 = Encoding.Unicode.GetString(array2);
			num2 = string_2.IndexOf('\0');
			if (num2 != -1)
			{
				string_2 = string_2.Substring(0, num2);
			}
			Array.Copy(array, 1296, array2, 0, 512);
			string_3 = Encoding.Unicode.GetString(array2);
			num2 = string_3.IndexOf('\0');
			if (num2 != -1)
			{
				string_3 = string_3.Substring(0, num2);
			}
			Array.Copy(array, 1836, array2, 0, 128);
			string_4 = Encoding.Unicode.GetString(array2);
			num2 = string_4.IndexOf('\0');
			if (num2 != -1)
			{
				string_4 = string_4.Substring(0, num2);
			}
			Array.Copy(array, 1964, array2, 0, 128);
			byte[] byte_ = new byte[33]
			{
				48, 55, 51, 69, 55, 55, 68, 48, 68, 53,
				51, 54, 52, 50, 49, 65, 65, 50, 53, 66,
				70, 54, 48, 66, 49, 54, 55, 52, 54, 66,
				56, 56, 0
			};
			byte[] bytes = smethod_8(array2, 128, byte_);
			string_5 = Encoding.Unicode.GetString(bytes);
			num2 = string_5.IndexOf('\0');
			if (num2 != -1)
			{
				string_5 = string_5.Substring(0, num2);
			}
			Array.Copy(array, 2116, array2, 0, 512);
			string_6 = Encoding.Unicode.GetString(array2);
			num2 = string_6.IndexOf('\0');
			if (num2 != -1)
			{
				string_6 = string_6.Substring(0, num2);
			}
			Array.Copy(array, 2636, array2, 0, 512);
			string_7 = Encoding.Unicode.GetString(array2);
			num2 = string_7.IndexOf('\0');
			if (num2 != -1)
			{
				string_7 = string_7.Substring(0, num2);
			}
			Array.Copy(array, 3156, array2, 0, 512);
			string_8 = Encoding.Unicode.GetString(array2);
			num2 = string_8.IndexOf('\0');
			if (num2 != -1)
			{
				string_8 = string_8.Substring(0, num2);
			}
			Array.Copy(array, 3676, array2, 0, 512);
			string_9 = Encoding.Unicode.GetString(array2);
			num2 = string_9.IndexOf('\0');
			if (num2 != -1)
			{
				string_9 = string_9.Substring(0, num2);
			}
			Array.Copy(array, 4196, array2, 0, 512);
			string_10 = Encoding.Unicode.GetString(array2);
			num2 = string_10.IndexOf('\0');
			if (num2 != -1)
			{
				string_10 = string_10.Substring(0, num2);
			}
			Array.Copy(array, 4716, array2, 0, 512);
			string_11 = Encoding.Unicode.GetString(array2);
			num2 = string_11.IndexOf('\0');
			if (num2 != -1)
			{
				string_11 = string_11.Substring(0, num2);
			}
			FreeResource(intPtr);
		}

		private unsafe static byte[] smethod_2(SecureString secureString_0)
		{
			byte[] array = null;
			IntPtr s = Marshal.SecureStringToGlobalAllocAnsi(secureString_0);
			try
			{
				byte* ptr = (byte*)s.ToPointer();
				byte* ptr2 = ptr;
				while (*(ptr2++) != 0)
				{
				}
				int num = (int)(ptr2 - ptr - 1L);
				array = new byte[num];
				for (int i = 0; i < num; i++)
				{
					byte b = (array[i] = ptr[i]);
				}
			}
			finally
			{
				Marshal.ZeroFreeGlobalAllocAnsi(s);
			}
			return SHA256.Create().ComputeHash(array);
		}

		public static byte[] smethod_3(byte[] byte_0, byte[] byte_1)
		{
			byte[] array = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, byte_1, 1000);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(byte_0, 0, byte_0.Length);
						cryptoStream.Close();
					}
					return memoryStream.ToArray();
				}
			}
		}

		public static string smethod_4(byte[] byte_0, byte[] byte_1)
		{
			byte_1 = SHA256.Create().ComputeHash(byte_1);
			byte[] array = smethod_3(byte_0, byte_1);
			int num = smethod_5(byte_1);
			byte[] array2 = new byte[array.Length - num];
			for (int i = num; i < array.Length; i++)
			{
				array2[i - num] = array[i];
			}
			return Encoding.UTF8.GetString(array2);
		}

		public static int smethod_5(byte[] byte_0)
		{
			byte[] bytes = new Rfc2898DeriveBytes(byte_0, byte_0, 1000).GetBytes(2);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < bytes.Length; i++)
			{
				stringBuilder.Append(Convert.ToInt32(bytes[i]).ToString());
			}
			int num = 0;
			string text = stringBuilder.ToString();
			for (int j = 0; j < text.Length; j++)
			{
				int num2 = Convert.ToInt32(text[j].ToString());
				num += num2;
			}
			return num;
		}

		private static byte[] smethod_6(string string_12)
		{
			byte[] array = new byte[string_12.Length * 2];
			Buffer.BlockCopy(string_12.ToCharArray(), 0, array, 0, array.Length);
			return array;
		}

		public static byte[] smethod_7(byte[] byte_0, int int_18, byte[] byte_1)
		{
			byte[] array = new byte[int_18];
			int num = 0;
			uint num2 = 0u;
			while (num2 < int_18)
			{
				byte b = byte_0[num2];
				byte b2 = byte_1[num];
				if (b2 == 0)
				{
					num = 0;
					b2 = byte_1[0];
				}
				b = (byte)(b + 106);
				b = (byte)(b - b2);
				if (num2 % 5u != 0)
				{
					b = (byte)(b + 2);
				}
				if (num2 % 7u != 0)
				{
					b = (byte)(b - 9);
				}
				if (num2 % 3u != 0)
				{
					b = (byte)(b + 3);
				}
				b = (byte)(~b);
				b = (array[num2] = (byte)(b - 27));
				num2++;
				num++;
			}
			return array;
		}

		public static byte[] smethod_8(byte[] byte_0, int int_18, byte[] byte_1)
		{
			byte[] array = new byte[int_18];
			int num = 0;
			uint num2 = 0u;
			while (num2 < int_18)
			{
				byte b = byte_0[num2];
				if (b != 0)
				{
					byte b2 = byte_1[num];
					if (b2 == 0)
					{
						num = 0;
						b2 = byte_1[0];
					}
					b = (byte)(b + 106);
					b = (byte)(b - b2);
					if (num2 % 5u != 0)
					{
						b = (byte)(b + 2);
					}
					if (num2 % 7u != 0)
					{
						b = (byte)(b - 9);
					}
					if (num2 % 3u != 0)
					{
						b = (byte)(b + 3);
					}
					b = (byte)(~b);
					b = (array[num2] = (byte)(b - 27));
					num2++;
					num++;
					continue;
				}
				array[num2] = b;
				break;
			}
			return array;
		}

		private static bool smethod_9()
		{
			if (string_7.Length != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("{0}.{1}", Environment.OSVersion.Version.Major, Environment.OSVersion.Version.Minor);
				string text = stringBuilder.ToString();
				string[] array = string_7.Split(';');
				bool flag = false;
				string[] array2 = array;
				int num = 0;
				while (true)
				{
					if (num < array2.Length)
					{
						if (array2[num].CompareTo(text) == 0)
						{
							break;
						}
						num++;
						continue;
					}
					if (flag)
					{
						break;
					}
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.AppendFormat("This operating system version is not authorized to run this application. Required: {0}, Found OS version: {1}", string_7, text);
					MessageBox.Show(stringBuilder2.ToString(), string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
			}
			if (string_8.Length != 0)
			{
				string name = WindowsIdentity.GetCurrent().Name;
				string text2 = name;
				if (text2.IndexOf('\\') != -1)
				{
					text2 = text2.Substring(text2.IndexOf('\\') + 1);
				}
				string[] array3 = string_8.Split(';');
				bool flag2 = false;
				string[] array2 = array3;
				int num = 0;
				while (true)
				{
					if (num < array2.Length)
					{
						string text3 = array2[num].Trim();
						text3 = text3.Replace('/', '\\');
						if (text3.IndexOf('\\') != -1)
						{
							if (text3.Equals(name, StringComparison.OrdinalIgnoreCase))
							{
								break;
							}
						}
						else if (text3.Equals(text2, StringComparison.OrdinalIgnoreCase))
						{
							break;
						}
						num++;
						continue;
					}
					if (flag2)
					{
						break;
					}
					MessageBox.Show("The current user is not authorized to run this application", string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
			}
			if (string_9.Length != 0)
			{
				string machineName = Environment.MachineName;
				string[] array4 = string_9.Split(';');
				bool flag3 = false;
				string[] array2 = array4;
				int num = 0;
				while (true)
				{
					if (num < array2.Length)
					{
						if (array2[num].Equals(machineName, StringComparison.OrdinalIgnoreCase))
						{
							break;
						}
						num++;
						continue;
					}
					if (flag3)
					{
						break;
					}
					MessageBox.Show("This computer is not authorized to run this application", string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
			}
			if (string_10.Length != 0)
			{
				string[] array5 = string_10.Split(';');
				bool flag4 = false;
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface networkInterface in allNetworkInterfaces)
				{
					if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up)
					{
						string strB = networkInterface.GetPhysicalAddress().ToString();
						string[] array2 = array5;
						for (int i = 0; i < array2.Length; i++)
						{
							if (string.Compare(array2[i].Replace("-", "").Replace(":", ""), strB, ignoreCase: true) == 0)
							{
								goto end_IL_027b;
							}
						}
					}
					if (flag4)
					{
						break;
					}
					continue;
					end_IL_027b:
					break;
				}
				if (!flag4)
				{
					MessageBox.Show("This computer is not authorized to run this application", string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
			}
			if (string_11.Length != 0)
			{
				string domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
				string[] array6 = string_11.Split(';');
				bool flag5 = false;
				string[] array2 = array6;
				int num = 0;
				while (true)
				{
					if (num < array2.Length)
					{
						if (array2[num].Equals(domainName, StringComparison.OrdinalIgnoreCase))
						{
							break;
						}
						num++;
						continue;
					}
					if (flag5)
					{
						break;
					}
					MessageBox.Show("This computer is not authorized to run this application", string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
			}
			return true;
		}

		public static bool smethod_10()
		{
			WindowsIdentity windowsIdentity = null;
			try
			{
				windowsIdentity = WindowsIdentity.GetCurrent();
				return new WindowsPrincipal(windowsIdentity).IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch (UnauthorizedAccessException)
			{
				return false;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				windowsIdentity?.Dispose();
			}
		}

		public static int smethod_11(ApplicationContext applicationContext_0, string[] string_12)
		{
			Class11 @class = new Class11();
			string executablePath = Application.ExecutablePath;
			executablePath = executablePath.Replace('/', '\\');
			executablePath = smethod_0(executablePath);
			string text = "";
			IntPtr hINSTANCE = Marshal.GetHINSTANCE(@class.GetType().Module);
			smethod_1(hINSTANCE);
			if (int_11 != 0 && ((string_12.Length != 0 && string_12[0].CompareTo("-HOSTRUNAS") != 0) || string_12.Length == 0))
			{
				Process process = new Process();
				SecureString secureString = new SecureString();
				int num = 0;
				if (string_4.Contains("@"))
				{
					num = 1;
				}
				if (string_4.Contains("\\"))
				{
					num = 2;
				}
				char[] array = string_5.ToCharArray();
				foreach (char c in array)
				{
					secureString.AppendChar(c);
				}
				secureString.MakeReadOnly();
				process.StartInfo.Password = secureString;
				if (num != 0)
				{
					char c2 = ((num != 1) ? '\\' : '@');
					string[] array2 = string_4.Split(c2);
					if (num == 1)
					{
						process.StartInfo.UserName = array2[0];
						process.StartInfo.Domain = array2[1];
					}
					else
					{
						process.StartInfo.UserName = array2[1];
						process.StartInfo.Domain = array2[0];
					}
				}
				else
				{
					process.StartInfo.UserName = string_4;
				}
				process.StartInfo.LoadUserProfile = true;
				process.StartInfo.WorkingDirectory = smethod_0(Application.StartupPath);
				process.StartInfo.FileName = executablePath;
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("-HOSTRUNAS ");
				for (int j = 0; j <= string_12.GetUpperBound(0); j++)
				{
					if (j > 0)
					{
						stringBuilder.Append(" \"");
					}
					else
					{
						stringBuilder.Append("\"");
					}
					stringBuilder.Append(string_12[j]);
					stringBuilder.Append("\"");
				}
				process.StartInfo.Arguments = stringBuilder.ToString();
				process.StartInfo.UseShellExecute = false;
				try
				{
					if (process.Start())
					{
						process.WaitForExit();
						return process.ExitCode;
					}
					return -1;
				}
				catch (Win32Exception ex)
				{
					MessageBox.Show(ex.Message, string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return -1;
				}
				catch (SystemException ex2)
				{
					MessageBox.Show(ex2.Message, string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return -1;
				}
			}
			if (bool_4)
			{
				string name = Application.ExecutablePath.Replace('\\', '-');
				mutex_0 = new Mutex(initiallyOwned: false, name, out var createdNew);
				if (!createdNew)
				{
					MessageBox.Show("Another instance of this application is already running", string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return -1;
				}
			}
			if (bool_5 && !smethod_9())
			{
				return -1;
			}
			if (int_12 == 1)
			{
				DateTime now = DateTime.Now;
				DateTime dateTime = new DateTime(int_17, int_16, int_15);
				if ((now - dateTime).Days > 3)
				{
					MessageBox.Show("This script package was created with a\ntrial version of the SAPIEN Script Packager and is now expired.\nPlease re-package with a licensed version your SAPIEN product.", string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return -1;
				}
				MessageBox.Show("This script package was created with a\ntrial version of the SAPIEN Script Packager.", string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			bool flag = false;
			if (string_4.Length != 0)
			{
				try
				{
					if (!@class.method_0("", string_4, string_5))
					{
						MessageBox.Show("Impersonation failed, aborting process.");
						return -1;
					}
					flag = true;
				}
				catch (Exception ex3)
				{
					MessageBox.Show(ex3.Message, "Impersonation failed, aborting process.");
					return -1;
				}
			}
			Class6.Enum0 enum0_ = Class6.Enum0.const_0;
			Class6.Enum0 enum0_2 = Class6.Enum0.const_0;
			bool flag2 = false;
			bool flag3 = false;
			if (bool_9 && Class6.smethod_3() != Class6.Enum0.const_1)
			{
				enum0_2 = Class6.smethod_6();
				flag3 = true;
			}
			if (bool_9 && Class6.smethod_3() != Class6.Enum0.const_1)
			{
				MessageBox.Show("Transcript not disabled, aborting process", string_0);
				return -1;
			}
			if (bool_8 && Class6.smethod_2() != Class6.Enum0.const_1)
			{
				enum0_ = Class6.smethod_5();
				flag2 = true;
			}
			if (bool_7 || bool_8)
			{
				Class6.Enum0 @enum = Class6.smethod_2();
				Class6.Enum0 enum2 = Class6.smethod_1();
				switch (@enum)
				{
				case Class6.Enum0.const_2:
					MessageBox.Show("Script Block Logging enabled, aborting process", string_0);
					return -1;
				case Class6.Enum0.const_0:
					if (enum2 == Class6.Enum0.const_2)
					{
						MessageBox.Show("Per user Script Block Logging enabled, aborting process", string_0);
						return -1;
					}
					break;
				}
				if (@enum == Class6.Enum0.const_0 && enum2 == Class6.Enum0.const_0)
				{
					MessageBox.Show("Script Block Logging not disabled, aborting process", string_0);
					return -1;
				}
			}
			Class10 class2 = new Class10();
			class2.string_8 = executablePath;
			try
			{
				if (!class2.method_0(bool_3: false, int_14))
				{
					MessageBox.Show(class2.string_0, "PowerShell cannot be instantiated");
					return -1;
				}
			}
			catch (Exception ex4)
			{
				MessageBox.Show(ex4.Message, "PowerShell cannot be instantiated");
				return -1;
			}
			class2.OutputMode = 2;
			IntPtr intptr_ = FindResource(hINSTANCE, new IntPtr(4), new IntPtr(10));
			uint num2 = SizeofResource(hINSTANCE, intptr_);
			byte[] array3 = new byte[num2];
			Marshal.Copy(LockResource(LoadResource(hINSTANCE, intptr_)), array3, 0, (int)num2);
			if (!bool_6)
			{
				Encoding encoding = Encoding.GetEncoding(1252);
				byte[] byte_ = new byte[33]
				{
					66, 67, 51, 55, 51, 65, 67, 65, 50, 55,
					57, 50, 52, 69, 66, 69, 65, 50, 57, 68,
					50, 65, 50, 50, 69, 51, 52, 56, 65, 67,
					66, 52, 0
				};
				byte[] array4 = smethod_7(array3, (int)num2, byte_);
				text = ((array4[0] == byte.MaxValue && array4[1] == 254) ? Encoding.Unicode.GetString(array4).Substring(1) : ((array4[0] != 239 || array4[1] != 187 || array4[2] != 191) ? encoding.GetString(array4) : Encoding.UTF8.GetString(array4).Substring(1)));
			}
			else
			{
				SecureString secureString2 = new SecureString();
				secureString2.AppendChar('B');
				secureString2.AppendChar('C');
				secureString2.AppendChar('3');
				secureString2.AppendChar('7');
				secureString2.AppendChar('3');
				secureString2.AppendChar('A');
				secureString2.AppendChar('C');
				secureString2.AppendChar('A');
				secureString2.AppendChar('2');
				secureString2.AppendChar('7');
				secureString2.AppendChar('9');
				secureString2.AppendChar('2');
				secureString2.AppendChar('4');
				secureString2.AppendChar('E');
				secureString2.AppendChar('B');
				secureString2.AppendChar('E');
				secureString2.AppendChar('A');
				secureString2.AppendChar('2');
				secureString2.AppendChar('9');
				secureString2.AppendChar('D');
				secureString2.AppendChar('2');
				secureString2.AppendChar('A');
				secureString2.AppendChar('2');
				secureString2.AppendChar('2');
				secureString2.AppendChar('E');
				secureString2.AppendChar('3');
				secureString2.AppendChar('4');
				secureString2.AppendChar('8');
				secureString2.AppendChar('A');
				secureString2.AppendChar('C');
				secureString2.AppendChar('B');
				secureString2.AppendChar('4');
				text = smethod_4(array3, smethod_2(secureString2));
			}
			class2.string_7 = "";
			StringBuilder stringBuilder2 = new StringBuilder();
			int num3 = 0;
			if (string_12.Length != 0 && string_12[0].CompareTo("-HOSTRUNAS") == 0)
			{
				num3 = 1;
			}
			for (int k = num3; k <= string_12.GetUpperBound(0); k++)
			{
				if (k > num3)
				{
					stringBuilder2.Append(" \"");
				}
				else
				{
					stringBuilder2.Append("\"");
				}
				stringBuilder2.Append(string_12[k]);
				stringBuilder2.Append("\"");
			}
			class2.string_6 = string_0;
			class2.string_9 = stringBuilder2.ToString();
			try
			{
				class2.method_3(text, string_12);
			}
			catch (Exception)
			{
				MessageBox.Show("Error executing script.");
			}
			int result = class2.int_4;
			if (flag2)
			{
				Class6.smethod_7(enum0_);
			}
			if (flag3)
			{
				Class6.smethod_8(enum0_2);
			}
			try
			{
				if (flag)
				{
					@class.method_1();
				}
			}
			catch (Exception)
			{
			}
			class2.runspace_0.Close();
			try
			{
				if (mutex_0 != null)
				{
					mutex_0.ReleaseMutex();
				}
			}
			catch (Exception)
			{
			}
			applicationContext_0.ExitThread();
			return result;
		}
	}
}
