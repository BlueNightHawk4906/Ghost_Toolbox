using System.Runtime.CompilerServices;
using System.Security;
using ns5;

namespace ns1
{
	internal sealed class Class18 : Interface0
	{
		[CompilerGenerated]
		private SecureString secureString_0;

		[CompilerGenerated]
		private SecureString secureString_1;

		[CompilerGenerated]
		private SecureString secureString_2;

		[CompilerGenerated]
		private bool bool_0;

		public SecureString UserName
		{
			[CompilerGenerated]
			get
			{
				return secureString_0;
			}
			[CompilerGenerated]
			internal set
			{
				secureString_0 = value;
			}
		}

		public SecureString DomainName
		{
			[CompilerGenerated]
			get
			{
				return secureString_1;
			}
			[CompilerGenerated]
			internal set
			{
				secureString_1 = value;
			}
		}

		public SecureString Password
		{
			[CompilerGenerated]
			get
			{
				return secureString_2;
			}
			[CompilerGenerated]
			internal set
			{
				secureString_2 = value;
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
	}
}
