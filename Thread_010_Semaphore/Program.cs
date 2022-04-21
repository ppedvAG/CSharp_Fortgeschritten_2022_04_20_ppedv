public class Program
{
	static void Main(string[] args)
	{
		SemaphoreZähler sem = new SemaphoreZähler();
		for (int i = 0; i < 500; i++)
			new Thread(sem.DoSomething).Start(); //500 Threads starten aber nie mehr als 5 Threads können auf das Semaphor zugreifen
	}

	public class SemaphoreZähler
	{
		Semaphore semaphore = new Semaphore(5, 5); //Zwei Variablen: Platz am Anfang, Maximaler Platz
		int Counter = 0;

		public void DoSomething()
		{
			semaphore.WaitOne(); //Einen Thread reinlegen
			Counter++;
			Console.WriteLine(Counter);
			Counter--;
			semaphore.Release(); //Einen Thread rausnehmen
		}
	}
}