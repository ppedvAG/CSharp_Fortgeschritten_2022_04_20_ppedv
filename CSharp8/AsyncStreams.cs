namespace CSharp8
{
	internal class AsyncStreams
	{
		static void Main2(string[] args)
		{
			Task.Run(() => PrintZahlen());

			Console.ReadKey();
		}

		public static async IAsyncEnumerable<int> GeneriereZahlen()
		{
			for(int i = 0; i < 100; i++)
			{
				await Task.Delay(100);
				yield return i; //Bei jedem Schleifendurchlauf wird i in die Liste geschrieben
			}
		}

		public static async void PrintZahlen()
		{
			await foreach (int i in GeneriereZahlen()) //Schleife wartet auf neue Elemente (durch await), await vor der Schleife
			{
				Console.WriteLine(i);
			}
		}
	}
}
