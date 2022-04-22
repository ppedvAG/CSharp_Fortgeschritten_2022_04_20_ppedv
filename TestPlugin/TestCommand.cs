using Newtonsoft.Json;
using PluginBase;

namespace TestPlugin
{
	public class TestCommand : ICommand
	{
		public string Name => "TestPlugin";

		public string Description => "Das ist ein TestPlugin";

		public int Execute() //Weitere Aktion vom Plugin (Files lesen, Web Schnittstellen ansprechen, ...)
		{
			Console.WriteLine("TestPlugin geladen");
			string s = JsonConvert.SerializeObject(this);
			Console.WriteLine(s);
			return 0;
		}
	}
}