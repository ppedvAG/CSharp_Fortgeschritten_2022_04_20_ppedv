public class Program
{
	static void Main(string[] args)
	{
		new Thread(() => Thread.Sleep(500)).Start(); //Erzeugt Vordergrundthread (hält das Programm auf bis er fertig ist)
		ThreadPool.QueueUserWorkItem(Methode1); //Erzeugt Hintergrundthreads (stoppt wenn das Programm stoppt, niedrige Priorität)
		ThreadPool.QueueUserWorkItem(Methode2); //Threads reihen bis Platz im Pool ist
		ThreadPool.QueueUserWorkItem(Methode3);
		Thread.Sleep(100); 
		//ThreadPool fängt an zu arbeiten wenn MainThread im Sleep ist
		//ThreadPool Threads werden abgebrochen wenn der alle Thread zu Ende sind
	}

	public static void Methode1(object o)
	{
		for (int i = 0; i < 100; i++)
		{
			Thread.Sleep(25);
			Console.WriteLine("Methode1");
		}
	}

	public static void Methode2(object o)
	{
		for (int i = 0; i < 100; i++)
		{
			Thread.Sleep(25);
			Console.WriteLine("Methode2");
		}
	}

	public static void Methode3(object o)
	{
		for (int i = 0; i < 100; i++)
		{
			Thread.Sleep(25);
			Console.WriteLine("Methode3");
		}
	}
}