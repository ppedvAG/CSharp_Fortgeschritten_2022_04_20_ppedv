namespace CSharp7
{
	internal class Tupel
	{
		public void TupelMethod()
		{
			Person p = new Person() { FirstName = "Max", LastName = "Meier" };

			(string, string) str = p.BeideNamen(); //Zuweisung auf ein Tupel
			Console.WriteLine($"Vorname: {str.Item1}"); //Zugriff mit str.Item1/2
			Console.WriteLine($"Nachname: {str.Item2}");

			(string fn, string ln) = p.BeideNamen(); //Hier Name von Tupel unten übernehmen
			Console.WriteLine($"Vorname: {fn}"); //Zugriff hier direkt mit fn/ln
			Console.WriteLine($"Nachname: {ln}");

			var (fn2, ln2) = p.BeideNamen(); //Hier Kurzschreibweise mit var

			string vorname, nachname;
			(vorname, nachname) = p.BeideNamen(); //Auftrennung

			var (outFN, outLN) = p; //Deconstruct Methode wird aufgerufen, muss var sein

			//C# 7.1
			var tupel = (firstname: fn, lastname: ln); //Felder in dem Tupel spezifische Namen geben

			//C# 7.2
			var tupel2 = (fn, ln);
			if (tupel == tupel2) //== und != für Tupel
				Console.WriteLine("Tupel sind gleich"); //Wertevergleich (keine HashCodes)
		}
	}

	public class Person
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public (string fn, string ln) BeideNamen() //Mehrere Return Werte mit (wert1, wert2, ...)
		{
			return (FirstName, LastName); //Mehrere Werte Returnen
		}

		//Deconstruct Methode funktioniert hier wie eine Struktur (Konstruktor, Destruktor)
		public void Deconstruct(out string firstname, out string lastname)
		{
			firstname = FirstName;
			lastname = LastName;
		}
	}
}
