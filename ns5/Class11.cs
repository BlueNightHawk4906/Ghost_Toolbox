using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;
using System.Windows.Forms;

namespace ns5
{
	internal sealed class Class11
	{
		private static IntPtr intptr_0 = new IntPtr(0);

		private static WindowsImpersonationContext windowsImpersonationContext_0;

		[DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool LogonUser(string string_0, string string_1, string string_2, int int_0, int int_1, ref IntPtr intptr_1);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern bool CloseHandle(IntPtr intptr_1);

		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public bool method_0(string string_0, string string_1, string string_2)
		{
			try
			{
				intptr_0 = IntPtr.Zero;
				bool flag;
				if (string_1.Contains("@"))
				{
					flag = LogonUser(string_1, null, string_2, 2, 0, ref intptr_0);
				}
				else if (string_1.Contains("\\"))
				{
					int num = string_1.IndexOf('\\');
					string string_3 = string_1.Substring(0, num);
					string_1 = string_1.Substring(num + 1);
					flag = LogonUser(string_1, string_3, string_2, 2, 0, ref intptr_0);
				}
				else
				{
					flag = LogonUser(string_1, ".", string_2, 2, 0, ref intptr_0);
				}
				if (!flag)
				{
					MessageBox.Show("LogonUser call failed with error code : " + Marshal.GetLastWin32Error());
					return false;
				}
				windowsImpersonationContext_0 = new WindowsIdentity(intptr_0).Impersonate();
				if (windowsImpersonationContext_0 == null)
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception occurred. " + ex.Message);
				return false;
			}
			return true;
		}

		public void method_1()
		{
			try
			{
				if (windowsImpersonationContext_0 != null)
				{
					windowsImpersonationContext_0.Undo();
				}
				if (intptr_0 != IntPtr.Zero)
				{
					CloseHandle(intptr_0);
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
