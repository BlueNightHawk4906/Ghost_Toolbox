using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns5
{
	internal sealed class Class7 : ApplicationContext
	{
		private Class7()
		{
		}

		private static void smethod_0(object sender, ThreadExceptionEventArgs e)
		{
		}

		private static void smethod_1(object sender, UnhandledExceptionEventArgs e)
		{
		}

		[DllImport("kernel32.dll")]
		internal static extern bool IsDebuggerPresent();

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

		internal static bool smethod_2()
		{
			if (!Debugger.IsAttached && !IsDebuggerPresent())
			{
				bool bool_ = false;
				CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref bool_);
				return bool_;
			}
			return true;
		}

		private static void smethod_3(object sender, EventArgs e)
		{
		}

		private static int Main(string[] args)
		{
			Application.ThreadException += smethod_0;
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			AppDomain.CurrentDomain.UnhandledException += smethod_1;
			Class7 applicationContext_ = new Class7();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			if (IsDebuggerPresent())
			{
				return 0;
			}
			Application.Idle += smethod_3;
			return Class9.smethod_11(applicationContext_, args);
		}
	}
}
