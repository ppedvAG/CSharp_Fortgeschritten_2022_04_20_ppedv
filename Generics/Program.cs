using System.Collections;

public class Program
{
	static void Main(string[] args)
	{
		List<string> list = new List<string>(); //Generic: T wird übernommen in Methoden und Feldern und Properties
		list.Add("Max");
		list.Add("Moritz");

		Dictionary<int, string> keyValuePairs = new Dictionary<int, string>(); //2 Generics
		keyValuePairs.Add(1, "Peter"); //Es werden beide übernommen

		foreach (KeyValuePair<int, string> pair in keyValuePairs)
		{
			//...
		}


		DataStore<int> ds = new DataStore<int>(); //Generic bei Erstellung
		ds.AddOrUpdate(1, 88);
		ds.GetIndex(1);
		ds.DisplayDefault<Program>(); //Generic beim Methodenaufruf
	}

	public class DataStore<T> : IEnumerable<int> //T als Generic in der Klasse, IEnumerable kann ein Generic von der Klassendefinition haben oder einen fixen Typ
	{
		private T[] data = new T[10]; //Array vom Typ T

		public T[] Data
		{
			get => data;
			set => data = value;
		}

		public T GetIndex(int index) //T als Return Typ
		{
			if (index < 0 || index >= data.Length)
				return default(T); //default(T): gibt den Standardwert vom entsprechenden Typen aus (int = 0, string = null, Program = null)
			return data[index];
		}

		public void AddOrUpdate(int index, T item) //T in einem Parameter
		{
			if (index >= 0 && index < data.Length)
				data[index] = item;
		}

		public void DisplayDefault<MyType>() //Generic in einer Methode
		{
			Console.WriteLine($"Standardwert von MyType: {default(MyType)}");
		}

		public IEnumerator<int> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}