using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using ns0;
using ns1;
using ns5;

namespace ns4
{
	internal static class Class12
	{
		[Flags]
		public enum Enum1
		{
			flag_0 = 0x1,
			flag_1 = 0x2,
			flag_2 = 0x10,
			flag_3 = 0x20,
			flag_4 = 0x100,
			flag_5 = 0x200,
			flag_6 = 0x1000,
			flag_7 = 0x10000000
		}

		[Flags]
		public enum Enum2
		{
			flag_0 = 0x1,
			flag_1 = 0x2,
			flag_2 = 0x4,
			flag_3 = 0x8,
			flag_4 = 0x10,
			flag_5 = 0x40,
			flag_6 = 0x80,
			flag_7 = 0x100,
			flag_8 = 0x200,
			flag_9 = 0x400,
			flag_10 = 0x800,
			flag_11 = 0x1000,
			flag_12 = 0x4000,
			flag_13 = 0x20000,
			flag_14 = 0x40000,
			flag_15 = 0x80000,
			flag_16 = 0x100000
		}

		public sealed class Class13
		{
			private string string_0;

			private string string_1;

			[CompilerGenerated]
			private IntPtr intptr_0;

			[CompilerGenerated]
			private IntPtr intptr_1;

			[CompilerGenerated]
			private bool bool_0;

			[CompilerGenerated]
			private Enum1 enum1_0;

			[CompilerGenerated]
			private int int_0;

			public string Caption
			{
				get
				{
					return string_0;
				}
				set
				{
					if (value.Length > 128)
					{
						throw new ArgumentOutOfRangeException("value");
					}
					string_0 = value;
				}
			}

			public string Message
			{
				get
				{
					return string_1;
				}
				set
				{
					if (value.Length > 32767)
					{
						throw new ArgumentOutOfRangeException("value");
					}
					string_1 = value;
				}
			}

			public IntPtr HwndParent
			{
				[CompilerGenerated]
				get
				{
					return intptr_0;
				}
				[CompilerGenerated]
				set
				{
					intptr_0 = value;
				}
			}

			public IntPtr HbmBanner
			{
				[CompilerGenerated]
				get
				{
					return intptr_1;
				}
				[CompilerGenerated]
				set
				{
					intptr_1 = value;
				}
			}

			public bool IsSaveChecked
			{
				[CompilerGenerated]
				get
				{
					return bool_0;
				}
				[CompilerGenerated]
				set
				{
					bool_0 = value;
				}
			}

			public Enum1 Flags
			{
				[CompilerGenerated]
				get
				{
					return enum1_0;
				}
				[CompilerGenerated]
				set
				{
					enum1_0 = value;
				}
			}

			public int AuthErrorCode
			{
				[CompilerGenerated]
				get
				{
					return int_0;
				}
				[CompilerGenerated]
				set
				{
					int_0 = value;
				}
			}

			public Class13(string caption, string message)
			{
				if (string.IsNullOrEmpty(caption))
				{
					throw new ArgumentNullException("caption");
				}
				if (string.IsNullOrEmpty(message))
				{
					throw new ArgumentNullException("message");
				}
				Caption = caption;
				Message = message;
				Flags = Enum1.flag_0;
			}
		}

		public sealed class Class14
		{
			private string string_0;

			private string string_1;

			[CompilerGenerated]
			private string string_2;

			[CompilerGenerated]
			private IntPtr intptr_0;

			[CompilerGenerated]
			private IntPtr intptr_1;

			[CompilerGenerated]
			private bool bool_0;

			[CompilerGenerated]
			private Enum2 enum2_0;

			[CompilerGenerated]
			private int int_0;

			public string Caption
			{
				get
				{
					return string_0;
				}
				set
				{
					if (value.Length > 128)
					{
						throw new ArgumentOutOfRangeException("value");
					}
					string_0 = value;
				}
			}

			public string Message
			{
				get
				{
					return string_1;
				}
				set
				{
					if (value.Length > 32767)
					{
						throw new ArgumentOutOfRangeException("value");
					}
					string_1 = value;
				}
			}

			public string TargetName
			{
				[CompilerGenerated]
				get
				{
					return string_2;
				}
				[CompilerGenerated]
				set
				{
					string_2 = value;
				}
			}

			public IntPtr HwndParent
			{
				[CompilerGenerated]
				get
				{
					return intptr_0;
				}
				[CompilerGenerated]
				set
				{
					intptr_0 = value;
				}
			}

			public IntPtr HbmBanner
			{
				[CompilerGenerated]
				get
				{
					return intptr_1;
				}
				[CompilerGenerated]
				set
				{
					intptr_1 = value;
				}
			}

			public bool IsSaveChecked
			{
				[CompilerGenerated]
				get
				{
					return bool_0;
				}
				[CompilerGenerated]
				set
				{
					bool_0 = value;
				}
			}

			public Enum2 Flags
			{
				[CompilerGenerated]
				get
				{
					return enum2_0;
				}
				[CompilerGenerated]
				set
				{
					enum2_0 = value;
				}
			}

			public int AuthErrorCode
			{
				[CompilerGenerated]
				get
				{
					return int_0;
				}
				[CompilerGenerated]
				set
				{
					int_0 = value;
				}
			}

			public Class14(string targetName, string caption, string message)
			{
				if (string.IsNullOrEmpty(targetName))
				{
					throw new ArgumentNullException("targetName");
				}
				if (string.IsNullOrEmpty(caption))
				{
					throw new ArgumentNullException("caption");
				}
				if (string.IsNullOrEmpty(message))
				{
					throw new ArgumentNullException("message");
				}
				TargetName = targetName;
				Caption = caption;
				Message = message;
				Flags = Enum2.flag_1 | Enum2.flag_14;
			}
		}

		private static class Class15
		{
			public enum Enum3
			{
				const_0 = 0,
				const_1 = 1223,
				const_2 = 87,
				const_3 = 1004
			}

			[StructLayout(LayoutKind.Sequential)]
			public sealed class Class16
			{
				public int int_0;

				public IntPtr intptr_0;

				[MarshalAs(UnmanagedType.LPWStr)]
				public string string_0;

				[MarshalAs(UnmanagedType.LPWStr)]
				public string string_1;

				public IntPtr intptr_1;

				public Class16()
				{
					int_0 = Marshal.SizeOf(typeof(Class16));
				}
			}

			public const int int_0 = 32767;

			public const int int_1 = 128;

			public const int int_2 = 513;

			public const int int_3 = 513;

			public const int int_4 = 256;

			[DllImport("credui.dll", CharSet = CharSet.Unicode)]
			public static extern Enum3 CredUIPromptForCredentials(Class16 class16_0, string string_0, IntPtr intptr_0, int int_5, IntPtr intptr_1, int int_6, IntPtr intptr_2, int int_7, ref bool bool_0, Enum2 enum2_0);

			[DllImport("credui.dll", CharSet = CharSet.Unicode)]
			public static extern Enum3 CredUIPromptForWindowsCredentials(Class16 class16_0, int int_5, ref int int_6, IntPtr intptr_0, int int_7, out IntPtr intptr_1, out int int_8, ref bool bool_0, Enum1 enum1_0);

			[DllImport("credui.dll", CharSet = CharSet.Unicode, SetLastError = true)]
			public static extern bool CredPackAuthenticationBuffer(int int_5, string string_0, string string_1, IntPtr intptr_0, ref int int_6);

			[DllImport("credui.dll", CharSet = CharSet.Unicode, EntryPoint = "CredPackAuthenticationBuffer", SetLastError = true)]
			public static extern bool CredPackAuthenticationBuffer_1(int int_5, IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ref int int_6);

			[DllImport("credui.dll", CharSet = CharSet.Unicode, SetLastError = true)]
			public static extern bool CredUnPackAuthenticationBuffer(int int_5, IntPtr intptr_0, int int_6, StringBuilder stringBuilder_0, ref int int_7, StringBuilder stringBuilder_1, ref int int_8, StringBuilder stringBuilder_2, ref int int_9);

			[DllImport("credui.dll", CharSet = CharSet.Unicode, EntryPoint = "CredUnPackAuthenticationBuffer", SetLastError = true)]
			public static extern bool CredUnPackAuthenticationBuffer_1(int int_5, IntPtr intptr_0, int int_6, IntPtr intptr_1, ref int int_7, IntPtr intptr_2, ref int int_8, IntPtr intptr_3, ref int int_9);

			public static Class17 smethod_0(bool bool_0, IntPtr intptr_0, int int_5)
			{
				StringBuilder stringBuilder = new StringBuilder(255);
				StringBuilder stringBuilder2 = new StringBuilder(255);
				StringBuilder stringBuilder3 = new StringBuilder(255);
				int int_6 = stringBuilder.Capacity;
				int int_7 = stringBuilder2.Capacity;
				int int_8 = stringBuilder3.Capacity;
				if (!CredUnPackAuthenticationBuffer(bool_0 ? 1 : 0, intptr_0, int_5, stringBuilder, ref int_6, stringBuilder2, ref int_7, stringBuilder3, ref int_8))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error != 122)
					{
						throw new Win32Exception(lastWin32Error);
					}
					stringBuilder.Capacity = int_6;
					stringBuilder3.Capacity = int_8;
					stringBuilder2.Capacity = int_7;
					if (!CredUnPackAuthenticationBuffer(bool_0 ? 1 : 0, intptr_0, int_5, stringBuilder, ref int_6, stringBuilder2, ref int_7, stringBuilder3, ref int_8))
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
				}
				return new Class17
				{
					UserName = stringBuilder.ToString(),
					DomainName = stringBuilder2.ToString(),
					Password = stringBuilder3.ToString()
				};
			}

			public static Class18 smethod_1(bool bool_0, IntPtr intptr_0, int int_5)
			{
				int int_6 = 255;
				int int_7 = 255;
				int int_8 = 255;
				IntPtr intPtr = IntPtr.Zero;
				IntPtr intPtr2 = IntPtr.Zero;
				IntPtr intPtr3 = IntPtr.Zero;
				try
				{
					intPtr = Marshal.AllocCoTaskMem(int_6);
					intPtr2 = Marshal.AllocCoTaskMem(int_7);
					intPtr3 = Marshal.AllocCoTaskMem(int_8);
					if (!CredUnPackAuthenticationBuffer_1(bool_0 ? 1 : 0, intptr_0, int_5, intPtr, ref int_6, intPtr2, ref int_7, intPtr3, ref int_8))
					{
						int lastWin32Error = Marshal.GetLastWin32Error();
						if (lastWin32Error != 122)
						{
							throw new Win32Exception(lastWin32Error);
						}
						intPtr = Marshal.ReAllocCoTaskMem(intPtr, int_6);
						intPtr2 = Marshal.ReAllocCoTaskMem(intPtr2, int_7);
						intPtr3 = Marshal.ReAllocCoTaskMem(intPtr3, int_8);
						if (!CredUnPackAuthenticationBuffer_1(bool_0 ? 1 : 0, intptr_0, int_5, intPtr, ref int_6, intPtr2, ref int_7, intPtr3, ref int_8))
						{
							throw new Win32Exception(Marshal.GetLastWin32Error());
						}
					}
					return new Class18
					{
						UserName = smethod_3(intPtr, int_6),
						DomainName = smethod_3(intPtr2, int_7),
						Password = smethod_3(intPtr3, int_8)
					};
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						Marshal.ZeroFreeCoTaskMemUnicode(intPtr);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						Marshal.ZeroFreeCoTaskMemUnicode(intPtr2);
					}
					if (intPtr3 != IntPtr.Zero)
					{
						Marshal.ZeroFreeCoTaskMemUnicode(intPtr3);
					}
				}
			}

			public static SecureString smethod_2(IntPtr intptr_0)
			{
				SecureString secureString = new SecureString();
				int num = 0;
				while (true)
				{
					char c = (char)Marshal.ReadInt16(intptr_0, num++ * 2);
					if (c == '\0')
					{
						break;
					}
					secureString.AppendChar(c);
				}
				secureString.MakeReadOnly();
				return secureString;
			}

			public static SecureString smethod_3(IntPtr intptr_0, int int_5)
			{
				SecureString secureString = new SecureString();
				for (int i = 0; i < int_5; i++)
				{
					secureString.AppendChar((char)Marshal.ReadInt16(intptr_0, i * 2));
				}
				secureString.MakeReadOnly();
				return secureString;
			}
		}

		public static Class17 smethod_0(string string_0, string string_1)
		{
			return smethod_2(string_0, string_1, null, null);
		}

		public static Class17 smethod_1(string string_0, string string_1, IntPtr intptr_0)
		{
			return smethod_3(string_0, string_1, intptr_0, null, null);
		}

		public static Class17 smethod_2(string string_0, string string_1, string string_2, string string_3)
		{
			return smethod_3(string_0, string_1, IntPtr.Zero, string_2, string_3);
		}

		public static Class17 smethod_3(string string_0, string string_1, IntPtr intptr_0, string string_2, string string_3)
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				return smethod_11(string_0, string_1, intptr_0, string_2, string_3);
			}
			return smethod_22(Environment.UserDomainName, string_0, string_1, intptr_0, string_2, string_3);
		}

		public static Class18 smethod_4(string string_0, string string_1)
		{
			return smethod_5(string_0, string_1, IntPtr.Zero);
		}

		public static Class18 smethod_5(string string_0, string string_1, IntPtr intptr_0)
		{
			return smethod_7(string_0, string_1, IntPtr.Zero, null, null);
		}

		public static Class18 smethod_6(string string_0, string string_1, SecureString secureString_0, SecureString secureString_1)
		{
			return smethod_7(string_0, string_1, IntPtr.Zero, secureString_0, secureString_1);
		}

		public static Class18 smethod_7(string string_0, string string_1, IntPtr intptr_0, SecureString secureString_0, SecureString secureString_1)
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				return smethod_16(string_0, string_1, intptr_0, secureString_0, secureString_1);
			}
			return smethod_28(Environment.UserDomainName, string_0, string_1, intptr_0, secureString_0, secureString_1);
		}

		public static Class17 smethod_8(string string_0, string string_1)
		{
			return smethod_10(string_0, string_1, string.Empty, string.Empty);
		}

		public static Class17 smethod_9(string string_0, string string_1, IntPtr intptr_0)
		{
			return smethod_9(string_0, string_1, intptr_0);
		}

		public static Class17 smethod_10(string string_0, string string_1, string string_2, string string_3)
		{
			return smethod_11(string_0, string_1, IntPtr.Zero, string_2, string_3);
		}

		public static Class17 smethod_11(string string_0, string string_1, IntPtr intptr_0, string string_2, string string_3)
		{
			return smethod_12(new Class13(string_0, string_1)
			{
				HwndParent = intptr_0,
				IsSaveChecked = false
			}, string_2, string_3);
		}

		public static Class17 smethod_12(Class13 class13_0, string string_0, string string_1)
		{
			if (string.IsNullOrEmpty(string_0) && string.IsNullOrEmpty(string_1))
			{
				return smethod_18<Class17>(class13_0, null, null);
			}
			using (SecureString secureString = new SecureString())
			{
				using (SecureString secureString2 = new SecureString())
				{
					if (!string.IsNullOrEmpty(string_0))
					{
						string text = string_0;
						foreach (char c in text)
						{
							secureString.AppendChar(c);
						}
					}
					if (!string.IsNullOrEmpty(string_1))
					{
						string text = string_1;
						foreach (char c2 in text)
						{
							secureString2.AppendChar(c2);
						}
					}
					secureString.MakeReadOnly();
					secureString2.MakeReadOnly();
					return smethod_18<Class17>(class13_0, secureString, secureString2);
				}
			}
		}

		public static Class18 smethod_13(string string_0, string string_1)
		{
			return smethod_16(string_0, string_1, IntPtr.Zero, null, null);
		}

		public static Class18 smethod_14(string string_0, string string_1, IntPtr intptr_0)
		{
			return smethod_16(string_0, string_1, intptr_0, null, null);
		}

		public static Class18 smethod_15(string string_0, string string_1, SecureString secureString_0, SecureString secureString_1)
		{
			return smethod_16(string_0, string_1, IntPtr.Zero, secureString_0, secureString_1);
		}

		public static Class18 smethod_16(string string_0, string string_1, IntPtr intptr_0, SecureString secureString_0, SecureString secureString_1)
		{
			return smethod_17(new Class13(string_0, string_1)
			{
				HwndParent = intptr_0,
				IsSaveChecked = false
			}, secureString_0, secureString_1);
		}

		public static Class18 smethod_17(Class13 class13_0, SecureString secureString_0, SecureString secureString_1)
		{
			return smethod_18<Class18>(class13_0, secureString_0, secureString_1);
		}

		private static T smethod_18<T>(Class13 class13_0, SecureString secureString_0, SecureString secureString_1) where T : class, Interface0
		{
			Class15.Class16 class16_ = new Class15.Class16
			{
				string_1 = class13_0.Caption,
				string_0 = class13_0.Message,
				intptr_0 = class13_0.HwndParent,
				intptr_1 = class13_0.HbmBanner
			};
			Enum1 flags = class13_0.Flags;
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			int int_ = 0;
			IntPtr intptr_ = IntPtr.Zero;
			int int_2 = 0;
			IntPtr intPtr3 = IntPtr.Zero;
			int int_3 = 0;
			bool bool_ = class13_0.IsSaveChecked;
			try
			{
				if (secureString_0 != null || secureString_1 != null)
				{
					if (secureString_0 == null)
					{
						secureString_0 = new SecureString();
					}
					if (secureString_1 == null)
					{
						secureString_1 = new SecureString();
					}
					intPtr = Marshal.SecureStringToCoTaskMemUnicode(secureString_0);
					intPtr2 = Marshal.SecureStringToCoTaskMemUnicode(secureString_1);
				}
				if (intPtr != IntPtr.Zero || intPtr2 != IntPtr.Zero)
				{
					int_3 = 1024;
					intPtr3 = Marshal.AllocCoTaskMem(1024);
					if (!Class15.CredPackAuthenticationBuffer_1(0, intPtr, intPtr2, intPtr3, ref int_3))
					{
						int lastWin32Error = Marshal.GetLastWin32Error();
						if (lastWin32Error != 122)
						{
							throw new Win32Exception(lastWin32Error);
						}
						intPtr3 = Marshal.ReAllocCoTaskMem(intPtr3, int_3);
						if (!Class15.CredPackAuthenticationBuffer_1(0, intPtr, intPtr2, intPtr3, ref int_3))
						{
							throw new Win32Exception(Marshal.GetLastWin32Error());
						}
					}
				}
				Class15.Enum3 @enum = Class15.CredUIPromptForWindowsCredentials(class16_, class13_0.AuthErrorCode, ref int_, intPtr3, int_3, out intptr_, out int_2, ref bool_, flags);
				switch (@enum)
				{
				case Class15.Enum3.const_1:
					return null;
				default:
					throw new Win32Exception((int)@enum);
				case Class15.Enum3.const_0:
				{
					if (typeof(T) == typeof(Class18))
					{
						Class18 @class = Class15.smethod_1(bool_0: true, intptr_, int_2);
						@class.IsSaveChecked = bool_;
						return @class as T;
					}
					Class17 class2 = Class15.smethod_0(bool_0: true, intptr_, int_2);
					class2.IsSaveChecked = bool_;
					return class2 as T;
				}
				}
			}
			finally
			{
				if (intPtr3 != IntPtr.Zero)
				{
					Marshal.ZeroFreeCoTaskMemUnicode(intPtr3);
				}
				if (intptr_ != IntPtr.Zero)
				{
					Marshal.ZeroFreeCoTaskMemUnicode(intptr_);
				}
				if (intPtr != IntPtr.Zero)
				{
					Marshal.ZeroFreeCoTaskMemUnicode(intPtr);
				}
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.ZeroFreeCoTaskMemUnicode(intPtr2);
				}
			}
		}

		public static Class17 smethod_19(string string_0, string string_1, string string_2)
		{
			return smethod_23(new Class14(string_0, string_1, string_2));
		}

		public static Class17 smethod_20(string string_0, string string_1, string string_2, IntPtr intptr_0)
		{
			return smethod_20(string_0, string_1, string_2, intptr_0);
		}

		public static Class17 smethod_21(string string_0, string string_1, string string_2, string string_3, string string_4)
		{
			return smethod_22(string_0, string_1, string_2, IntPtr.Zero, string_3, string_4);
		}

		public static Class17 smethod_22(string string_0, string string_1, string string_2, IntPtr intptr_0, string string_3, string string_4)
		{
			return smethod_24(new Class14(string_0, string_1, string_2)
			{
				HwndParent = intptr_0
			}, string_3, string_4);
		}

		public static Class17 smethod_23(Class14 class14_0)
		{
			return smethod_24(class14_0, null, null);
		}

		public static Class17 smethod_24(Class14 class14_0, string string_0, string string_1)
		{
			using (SecureString secureString = new SecureString())
			{
				using (SecureString secureString2 = new SecureString())
				{
					if (!string.IsNullOrEmpty(string_0))
					{
						string text = string_0;
						foreach (char c in text)
						{
							secureString.AppendChar(c);
						}
					}
					if (!string.IsNullOrEmpty(string_1))
					{
						string text = string_1;
						foreach (char c2 in text)
						{
							secureString2.AppendChar(c2);
						}
					}
					secureString.MakeReadOnly();
					secureString2.MakeReadOnly();
					return smethod_31<Class17>(class14_0, secureString, secureString2);
				}
			}
		}

		public static Class18 smethod_25(string string_0, string string_1, string string_2)
		{
			return smethod_29(new Class14(string_0, string_1, string_2));
		}

		public static Class18 smethod_26(string string_0, string string_1, string string_2, IntPtr intptr_0)
		{
			return smethod_28(string_0, string_1, string_2, intptr_0, null, null);
		}

		public static Class18 smethod_27(string string_0, string string_1, string string_2, SecureString secureString_0, SecureString secureString_1)
		{
			return smethod_28(string_0, string_1, string_2, IntPtr.Zero, secureString_0, secureString_1);
		}

		public static Class18 smethod_28(string string_0, string string_1, string string_2, IntPtr intptr_0, SecureString secureString_0, SecureString secureString_1)
		{
			return smethod_30(new Class14(string_0, string_1, string_2)
			{
				HwndParent = intptr_0
			}, secureString_0, secureString_1);
		}

		public static Class18 smethod_29(Class14 class14_0)
		{
			return smethod_31<Class18>(class14_0, null, null);
		}

		public static Class18 smethod_30(Class14 class14_0, SecureString secureString_0, SecureString secureString_1)
		{
			return smethod_31<Class18>(class14_0, secureString_0, secureString_1);
		}

		private static T smethod_31<T>(Class14 class14_0, SecureString secureString_0, SecureString secureString_1) where T : class, Interface0
		{
			if (class14_0 == null)
			{
				throw new ArgumentNullException("options");
			}
			if (secureString_0 != null && secureString_0.Length > 513)
			{
				throw new ArgumentOutOfRangeException("userName", "CREDUI_MAX_USERNAME_LENGTH");
			}
			if (secureString_1 != null && secureString_1.Length > 256)
			{
				throw new ArgumentOutOfRangeException("password", "CREDUI_MAX_PASSWORD_LENGTH");
			}
			Class15.Class16 class16_ = new Class15.Class16
			{
				string_1 = class14_0.Caption,
				string_0 = class14_0.Message,
				intptr_0 = class14_0.HwndParent,
				intptr_1 = class14_0.HbmBanner
			};
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			bool bool_ = class14_0.IsSaveChecked;
			try
			{
				if (secureString_0 == null)
				{
					intPtr = Marshal.AllocCoTaskMem(1028);
					Marshal.WriteInt16(intPtr, 0, 0);
				}
				else
				{
					intPtr = Marshal.SecureStringToCoTaskMemUnicode(secureString_0);
					intPtr = Marshal.ReAllocCoTaskMem(intPtr, 1028);
				}
				if (secureString_1 == null)
				{
					intPtr2 = Marshal.AllocCoTaskMem(514);
					Marshal.WriteInt16(intPtr2, 0, 0);
				}
				else
				{
					intPtr2 = Marshal.SecureStringToCoTaskMemUnicode(secureString_1);
					intPtr2 = Marshal.ReAllocCoTaskMem(intPtr2, 514);
				}
				Marshal.WriteInt16(intPtr, 1026, 0);
				Marshal.WriteInt16(intPtr2, 512, 0);
				Class15.Enum3 @enum = Class15.CredUIPromptForCredentials(class16_, class14_0.TargetName, IntPtr.Zero, class14_0.AuthErrorCode, intPtr, 513, intPtr2, 256, ref bool_, class14_0.Flags);
				switch (@enum)
				{
				case Class15.Enum3.const_2:
					throw new Win32Exception((int)@enum);
				case Class15.Enum3.const_0:
					if (typeof(T) == typeof(Class18))
					{
						return new Class18
						{
							UserName = Class15.smethod_2(intPtr),
							Password = Class15.smethod_2(intPtr2),
							IsSaveChecked = bool_
						} as T;
					}
					return new Class17
					{
						UserName = Marshal.PtrToStringUni(intPtr),
						Password = Marshal.PtrToStringUni(intPtr2),
						IsSaveChecked = bool_
					} as T;
				default:
					throw new Win32Exception((int)@enum);
				case Class15.Enum3.const_3:
					throw new Win32Exception((int)@enum);
				case Class15.Enum3.const_1:
					return null;
				}
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.ZeroFreeCoTaskMemUnicode(intPtr);
				}
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.ZeroFreeCoTaskMemUnicode(intPtr2);
				}
			}
		}
	}
}
