public class Program
{
	static void Main(string[] args)
	{
		ThreadPool.QueueUserWorkItem(Methode1); //Threads reihen bis Platz im Pool ist
		ThreadPool.QueueUserWorkItem(Methode2);
		ThreadPool.QueueUserWorkItem(Methode3);

		Console.ReadLine();
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