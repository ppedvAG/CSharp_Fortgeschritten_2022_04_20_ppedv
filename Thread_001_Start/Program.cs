public class Program
{
	static void Main(string[] args)
	{
		Thread t = new Thread(Run); //Thread mit Funktionszeiger übergeben
		t.Start(); //Thread starten, wird jetzt seperat ausgeführt
		t.Join(); //Warten bis der Thread fertig ist

		for (int i = 0; i < 100; i++)
			Console.WriteLine($"Main Thread {i}");
	}

	public static void Run()
	{
		for (int i = 0; i < 100; i++)
			Console.WriteLine($"Side Thread {i}");
	}
}