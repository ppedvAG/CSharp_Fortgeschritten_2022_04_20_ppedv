public class Program
{
	static void Main(string[] args)
	{
		Task t = new Task(PrintI); //Task erstellen genau wie bei Threads
		t.Start();
		t.Wait(); // = Join();

		Task.Factory.StartNew(PrintI); //Alte Methode bis .NET 4.0
		Task.Run(PrintI); //Run integriert Start() direkt (ab .NET 4.5)

		for (int i = 0; i < 1000; i++) //Läuft parallel
			Console.WriteLine($"Main Thread {i}");

		Console.ReadLine();
	}

	public static void PrintI()
	{
		for (int i = 0; i < 1000; i++)
		{
			Console.WriteLine($"Task {i}");
		}
	}
}