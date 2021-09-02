namespace ns4
{
	internal sealed class Class3
	{
		public readonly bool bool_0;

		public readonly bool bool_1;

		private const uint uint_0 = 1u;

		private const uint uint_1 = 2u;

		internal uint Flag
		{
			get
			{
				uint num = 0u;
				if (bool_0)
				{
					num |= 1u;
				}
				if (bool_1)
				{
					num |= 2u;
				}
				return num;
			}
		}

		public Class3(bool loadRegistryInfo = true, bool readOnly = false)
		{
			bool_0 = loadRegistryInfo;
			bool_1 = readOnly;
		}
	}
}
