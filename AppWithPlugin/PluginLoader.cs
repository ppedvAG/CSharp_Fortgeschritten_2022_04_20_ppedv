using System.Reflection;
using System.Runtime.Loader;

namespace AppWithPlugin
{
	internal class PluginLoader : AssemblyLoadContext //Loader muss von AssemblyLoadContext extenden
	{
		private AssemblyDependencyResolver resolver; //Dependencies von Dll extra dazu laden

		public PluginLoader(string path)
		{
			resolver = new AssemblyDependencyResolver(path);
		}

		protected override Assembly Load(AssemblyName assemblyName) //Load C# Plugins
		{
			string assemblyPath = resolver.ResolveAssemblyToPath(assemblyName); //Finde dll
			if (assemblyPath != null)
				return LoadFromAssemblyPath(assemblyPath); //Lade dll
			return null;
		}

		protected override IntPtr LoadUnmanagedDll(string unmanagedDllName) //Load andere Dll's (C++, C)
		{
			string assemblyPath = resolver.ResolveUnmanagedDllToPath(unmanagedDllName); //Finde dll
			if (assemblyPath != null)
				return LoadUnmanagedDllFromPath(assemblyPath); //Lade dll
			return IntPtr.Zero;
		}
	}
}
