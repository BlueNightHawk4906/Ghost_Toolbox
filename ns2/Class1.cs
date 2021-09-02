using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using ns0;
using ns1;

namespace ns2
{
	internal abstract class Class1
	{
		protected const int int_0 = 1024;

		private static readonly Guid guid_0 = new Guid(892833452, 26687, 4562, 168, 154, 0, 192, 79, 187, 207, 162);

		private static readonly Guid guid_1 = new Guid(smethod_0<GuidAttribute>(Assembly.GetExecutingAssembly()).Value);

		protected GInterface0 ginterface0_0;

		private static T smethod_0<T>(ICustomAttributeProvider icustomAttributeProvider_0) where T : Attribute
		{
			object[] customAttributes = icustomAttributeProvider_0.GetCustomAttributes(typeof(T), inherit: true);
			if (customAttributes.Length == 0)
			{
				return null;
			}
			return (T)customAttributes[0];
		}

		internal Class1()
		{
			ginterface0_0 = smethod_1();
		}

		public void method_0()
		{
			if (ginterface0_0.imethod_4(bool_0: true, bool_1: true, guid_0, guid_1) != 0)
			{
				throw new Exception("Error saving machine settings");
			}
			if (ginterface0_0.imethod_4(bool_0: false, bool_1: true, guid_0, guid_1) != 0)
			{
				throw new Exception("Error saving user settings");
			}
		}

		public void method_1()
		{
			if (ginterface0_0.imethod_5() != 0)
			{
				throw new Exception("Error deleting the GPO");
			}
			ginterface0_0 = null;
		}

		public RegistryKey method_2(GroupPolicySection groupPolicySection_0)
		{
			if (ginterface0_0.imethod_12((uint)groupPolicySection_0, out var intptr_) != 0)
			{
				throw new Exception($"Unable to get section '{Enum.GetName(typeof(GroupPolicySection), groupPolicySection_0)}'");
			}
			return RegistryKey.FromHandle(new SafeRegistryHandle(intptr_, ownsHandle: true), RegistryView.Default);
		}

		public abstract string vmethod_0(GroupPolicySection groupPolicySection_0);

		protected static GInterface0 smethod_1()
		{
			return (GInterface0)(object)new Class0();
		}
	}
}
