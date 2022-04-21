public class Program
{
	static void Main(string[] args)
	{
		CancellationTokenSource cts = new CancellationTokenSource(); //Source erstellen
		CancellationToken token = cts.Token; //Aus Source Token holen

		Task t = new Task(PrintI, token); //Hier Token direkt übergeben
		t.Start();

		Thread.Sleep(500);
		cts.Cancel(); //Auf der Source canceln

		Console.ReadKey();
	}
	public static void PrintI(object token)
	{
		CancellationToken ct = (CancellationToken) token;

		for (int i = 0; i < 1000; i++)
		{
			if (ct.IsCancellationRequested)
				ct.ThrowIfCancellationRequested(); //Task wirft Exception aber ist nicht "sichtbar"

			Console.WriteLine($"Task {i}");
			Thread.Sleep(50);
		}
	}
}