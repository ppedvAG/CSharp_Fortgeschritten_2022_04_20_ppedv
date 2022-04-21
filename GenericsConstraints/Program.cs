public class Program
{
	static void Main(string[] args)
	{
		//DataStore4<TestClass> tc; //Hier kein Default Konstruktor
	}

	public class DataStore<T> where T : class { } //In T nur Referenztypen (Klasse, Interface, string, List, Array, ...)

	public class DataStore2<T> where T : struct { } //In T nur Wertetypen (Structs, int, float, bool, Enum, ...)

	public class DataStore3<T> where T : Program { } //Bestimmte Vererbungshierarchie

	public class DataStore4<T> where T : new() { } //Nur Typen die einen Default Konstruktor haben

	public class DataStore5<TKey, TValue> //Mehrere Generics restriktieren
		where TKey : class 
		where TValue : struct 
	{ 
	} 

	public class TestClass
	{
		public TestClass(int i) { } //Default Konstruktor entfernt durch mindestens einen Konstruktor mit Parameter
	}
}