namespace PluginBase
{
	public interface ICommand //Schnittstelle die jedes Plugin implementiert
	{
		string Name { get; }

		string Description { get; }

		int Execute(); //EntryPoint: Jedes Plugin hat seine eigene Logik
	}
}