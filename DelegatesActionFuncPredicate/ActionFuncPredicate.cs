namespace DelegatesActionFuncPredicate
{
	public class ActionFuncPredicate
	{
		static void Main3(string[] args)
		{
			Action<int, int> addiere = Addiere; //Action: kein Rückgabewert, bis zu 16 Parameter
			addiere(2, 1);
			addiere.Invoke(3, 8);

			Predicate<int> checkZero = CheckForZero; //Predicate: bool als Rückgabewert, genau ein Parameter
			bool b = checkZero(3);
			checkZero.Invoke(0);

			Func<int, int, int> sub = Subtrahiere; //Func: int als Rückgabewert, bis zu 16 Parameter
			int x = sub(2, 1);
			sub.Invoke(2, 1);

			Action<int, int> mult = (x, y) => 
			{
				Console.WriteLine(x * y);
			}; //Anonyme Action
			mult(4, 8);

			Action<int, int> div = (x, y) => Console.WriteLine(x / y);
			div.Invoke(4, 2);

			List<string> staedteListe = new List<string>() { "Berlin", "Wien", "Paris", "Köln" };
			string found = staedteListe.Find(match); //match ausgelagert in eigene Methode
			string found2 = staedteListe.Find(stadt => stadt.StartsWith("B")); //anonyme Methode
		}

		public static void Addiere(int x, int y)
		{
			Console.WriteLine(x + y);
		}

		public static bool CheckForZero(int x)
		{
			return x == 0;
		}

		public static int Subtrahiere(int x, int y)
		{
			return x - y;
		}

		public static void Test(Action<int, int> add)
		{

		}

		static bool match(string stadt) 
		{
			return stadt.StartsWith("B");
		}
	}
}
