namespace BuilderPatternAbstract
{
	public class Sandwich
	{
		private SandwichType SandwichType { get; set; }

		//Key: Art der Zutat, Value: Die Zutat selber
		private Dictionary<string, string> ingredients = new Dictionary<string, string>();

		public Sandwich(SandwichType type)
		{
			SandwichType = type;
		}

		//Indexer: Objekt wie Array oder Liste ansprechen
		public string this[string key]
		{
			get { return ingredients[key]; }
			set { ingredients[key] = value; }
		}

		public void Show()
		{
			Console.WriteLine($"Bread {ingredients["bread"]}");
			Console.WriteLine($"Meat {ingredients["meat"]}");
			Console.WriteLine($"Cheese {ingredients["cheese"]}");
			Console.WriteLine($"Veggies {ingredients["veggies"]}");
			Console.WriteLine($"Condiments {ingredients["condiments"]}");
		}
	}

	public enum SandwichType
	{
		BLT,
		HamAndCheese,
		TurkeyClub
	}
}
