using ns2;

namespace ns6
{
	internal sealed class Class20
	{
		private Class19 class19_0;

		private string string_0;

		private string string_1;

		public long HistoryId => 0L;

		public string InvocationName => string_0;

		public string Line => string_0;

		public Class19 MyCommand => class19_0;

		public int OffsetInLine => int.MinValue;

		public int PipelineLength => 1;

		public int PipelinePosition => 1;

		public string PositionMessage => "";

		public int ScriptLineNumber => 1;

		public string ScriptName => string_1;

		public Class20(string scriptpath)
		{
			class19_0 = new Class19(scriptpath);
			string_1 = scriptpath;
			int num = scriptpath.LastIndexOf('\\');
			string text = ((num != -1) ? scriptpath.Substring(num + 1) : "");
			if (text.Length != 0)
			{
				string_0 = "./" + text;
			}
			else
			{
				string_0 = "";
			}
		}
	}
}
