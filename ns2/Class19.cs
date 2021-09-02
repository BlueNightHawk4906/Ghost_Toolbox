using System.Management.Automation;

namespace ns2
{
	internal sealed class Class19
	{
		private string string_0;

		private string string_1;

		public CommandTypes CommandType => CommandTypes.ExternalScript;

		public string Definition => string_0;

		public string Name => string_1;

		public string Path => string_0;

		public Class19(string scriptpath)
		{
			string_0 = scriptpath;
			int num = string_0.LastIndexOf('\\');
			if (num == -1)
			{
				string_1 = "";
			}
			else
			{
				string_1 = Path.Substring(num + 1);
			}
		}

		string object.ToString()
		{
			return string_0;
		}
	}
}
