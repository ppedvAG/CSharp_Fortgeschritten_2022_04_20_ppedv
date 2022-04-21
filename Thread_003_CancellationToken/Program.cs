public class Program
{
	static void Main(string[] args)
	{
		CancellationTokenSource cts = new CancellationTokenSource();
		CancellationToken cancellationToken = cts.Token; //Cancellation Token erstellen

		ParameterizedThreadStart pt = new ParameterizedThreadStart(PrintI);
		Thread t = new Thread(pt);
		t.Start(cancellationToken); //Token übergeben

		Thread.Sleep(2000);
		cts.Cancel(); //Hier um zu Canceln auf die Source zugreifen
	}

	static void PrintI(object o) //CancellationToken übergeben
	{
		try
		{
			if (o is CancellationToken ct) //Hier direkter cast
			{
				for (int i = 0; i < 50; i++)
				{
					if (ct.IsCancellationRequested)
						ct.ThrowIfCancellationRequested(); //Thread beenden

					Console.WriteLine(i);
					Thread.Sleep(200);
				}
			}
		}
		catch (OperationCanceledException) { } //Hier OperationCanceledException abfangen vom Token
	}
}