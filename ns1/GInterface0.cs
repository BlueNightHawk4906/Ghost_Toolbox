using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns1
{
	[ComImport]
	[Guid("EA502723-A23D-11d1-A7D3-0000F87571E3")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface GInterface0
	{
		uint imethod_0([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, uint uint_0);

		uint imethod_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

		uint imethod_2(uint uint_0);

		uint imethod_3([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

		uint imethod_4([MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, [MarshalAs(UnmanagedType.LPStruct)] Guid guid_1);

		uint imethod_5();

		uint imethod_6([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		uint imethod_7([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		uint imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		uint imethod_9([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		uint imethod_10(uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		uint imethod_11(uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		uint imethod_12(uint uint_0, out IntPtr intptr_0);

		uint imethod_13(out uint uint_0);

		uint imethod_14(uint uint_0, uint uint_1);

		uint imethod_15(out IntPtr intptr_0);

		uint imethod_16([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		uint imethod_17(out IntPtr intptr_0);
	}
}
