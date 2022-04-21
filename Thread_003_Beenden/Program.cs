public class Program
{
	static void Main(string[] args)
	{ 
		Thread t = new Thread(PrintI);
		t.Start();

		Thread.Sleep(3000);
		//t.Abort(); //Deprecated
		t.Interrupt(); //Thread stoppen, wirft ThreadInterruptedException
	}

	static void PrintI() //Läuft 20 Sekunden lang
	{
		try
		{
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(200); //Warte 200ms
			}
		}
		catch (ThreadInterruptedException) { }
		//Exception fangen um Programabsturz zu unterbinden
		//Hier die Exception fangen, da Thread.Sleep ThreadInterruptedException wirft wenn abgebrochen
	}
}