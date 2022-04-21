public class Program
{
	static void Main(string[] args)
	{
		Task t = Task.Run(() =>
		{
			Thread.Sleep(2000);

			//throw new Exception();
		});

		//t.ContinueWith(task => Folgetask()); //ContinueWith um Tasks zu verketten
		t.ContinueWith(task => Fehlertask(), TaskContinuationOptions.OnlyOnFaulted); //Fehlertask() wenn Exception
		t.ContinueWith(task => CompletedTask(), TaskContinuationOptions.OnlyOnRanToCompletion); //CompletedTask() wenn alles OK
		Console.ReadKey();
	}

	public static void Folgetask()
	{
		Console.WriteLine("Folgetask");
	}

	public static void Fehlertask()
	{
		Console.WriteLine("Fehler");
	}

	public static void CompletedTask()
	{
		Console.WriteLine("Completed");
	}
}