public class Program
{
	static void Main(string[] args)
	{
		ParameterizedThreadStart pt = new ParameterizedThreadStart(ThreadMitParam); //Funktionszeiger
		Thread t = new Thread(pt); //ParameterizedThreadStart übergeben
		t.Start(50); //Hier Parameter übergeben

		for (int i = 0; i < 20; i++)
			Console.WriteLine($"Main Thread {i}");
	}

	static void ThreadMitParam(object o) //Methode muss void sein und object als Parameter haben
	{
		if (o is int)
		{
			int bis = (int) o;
			for (int i = 0; i < bis; i++)
			{
				Console.WriteLine($"Side Thread {i}");
			}
		}
	}
}