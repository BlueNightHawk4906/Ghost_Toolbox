using System;
using System.Globalization;
using System.Management.Automation.Host;
using System.Threading;

namespace ns2
{
	internal sealed class Class21 : PSHost
	{
		private CultureInfo cultureInfo_0 = Thread.CurrentThread.CurrentCulture;

		private CultureInfo cultureInfo_1 = Thread.CurrentThread.CurrentUICulture;

		private static Guid guid_0 = Guid.NewGuid();

		private Class22 class22_0 = new Class22();

		CultureInfo PSHost.CurrentCulture => cultureInfo_0;

		CultureInfo PSHost.CurrentUICulture => cultureInfo_1;

		Guid PSHost.InstanceId => guid_0;

		string PSHost.Name => "PrimalScriptHostImplementation";

		PSHostUserInterface PSHost.UI => class22_0;

		Version PSHost.Version => new Version(5, 0, 0, 0);

		void PSHost.EnterNestedPrompt()
		{
		}

		void PSHost.ExitNestedPrompt()
		{
		}

		void PSHost.NotifyBeginApplication()
		{
		}

		void PSHost.NotifyEndApplication()
		{
		}

		void PSHost.SetShouldExit(int exitCode)
		{
		}

		public void method_0()
		{
			class22_0.method_0();
		}
	}
}
