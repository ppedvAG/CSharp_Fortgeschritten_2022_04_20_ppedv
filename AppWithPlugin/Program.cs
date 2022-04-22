using AppWithPlugin;
using PluginBase;
using System.Reflection;

public class Program
{
	static void Main(string[] args)
	{
		string pluginRoot = @"C:\Users\lk3\source\repos\CSharp_Fortgeschritten_2022_04_20";
		string pluginPath = @"TestPlugin\bin\debug\net6.0\TestPlugin.dll";
		string fullPath = Path.Combine(pluginRoot, pluginPath);

		Assembly assembly = Assembly.LoadFrom(fullPath); //Dll laden

		List<Type> types = assembly.GetTypes().Where(e => e.GetInterface("ICommand") != null).ToList(); //Alle "Klassen" holen

		ICommand command = Activator.CreateInstance(types.First()) as ICommand; //Activator.CreateInstance: Objekt über Typ/Name erstellen, am Ende casten

		command.Execute();

		LoadPlugin(fullPath);
	}

	static Assembly LoadPlugin(string path)
	{
		PluginLoader pl = new PluginLoader(path);

		return pl.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(path)));
	}
}