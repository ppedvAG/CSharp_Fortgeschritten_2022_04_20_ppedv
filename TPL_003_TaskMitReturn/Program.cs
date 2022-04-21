public class Program
{
	static void Main(string[] args)
	{
		Task<int> task = Task<int>.Run(SumI); //int als Generic für den Return Typ
		//int res = task.Result; //.Result wartet auf das Resultat (blockt den Main Thread)

		Task<int> t2 = Task.Run(() => //Methode als Lambda-Expression
		{
			int summe = 0;
			for (int i = 0; i < 1000; i++)
				summe += i;
			Thread.Sleep(1000);
			return summe;
		});

		Task.WaitAll(task, t2); //Warte bis alle angegebenen Tasks fertig sind
		Task.WaitAny(task, t2); //Warte bis einer der angegebenen Tasks fertig ist

		Console.ReadKey();
	}

	public static int SumI()
	{
		int summe = 0;
		for (int i = 0; i < 1000; i++)
			summe += i;
		Thread.Sleep(1000);
		return summe;
	}
}