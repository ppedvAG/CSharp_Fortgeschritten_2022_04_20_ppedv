public class Program
{
	//Delegate mit string als Rückgabewert und einem Parameter (string)
	delegate string Vorstellung(string name);

	//Void Delegate
	delegate void PrintName(string name);

	static void Main2(string[] args)
	{
		Vorstellung v = new Vorstellung(VorstellungDE); //Delegate erstellen
		v += VorstellungEN; //Methode dranhängen
		Console.WriteLine(v("Max")); //Aufruf wie eine Methode


		PrintName p = new PrintName(PrintNameDE);
		p += PrintNameEN;
		p -= PrintNameDE; //Methode abziehen
		p("Max"); //Aufruf
		p.Invoke("Max"); //Aufruf mit Invoke

		foreach (Delegate d in p.GetInvocationList()) //Methoden von einem Delegate iterieren
		{
			Console.WriteLine(d.Method.Name);
		}

		p = null; //Wirft alle Methoden raus
	}

	public static string VorstellungDE(string name)
	{
		return $"Mein Name ist {name}";
	}

	public static string VorstellungEN(string name)
	{
		return $"My name is {name}";
	}

	public static void PrintNameDE(string name)
	{
		Console.WriteLine($"Mein Name ist {name}");
	}

	public static void PrintNameEN(string name)
	{
		Console.WriteLine($"My name is {name}");
	}
}