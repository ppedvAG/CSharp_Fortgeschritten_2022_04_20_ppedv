public class Program
{
	static void Main(string[] args)
	{
		List<Task<int>> tasks = new List<Task<int>>();
		for (int i = 0; i < 100; i++)
		{
			tasks.Add(Task.Factory.StartNew(Square, i)); //Tasks starten und dann in Liste hinzufügen
		}

		//tasks.ForEach(t => t.Start());

		Task<int[]> allResults = Task.WhenAll(tasks); //WhenAll: wartet auf alle angebenen Tasks
		int[] result = allResults.Result; //Result holen von allen Tasks
		Console.WriteLine(result.Aggregate("", (agg, str) => agg + str + ", "));


		Task<int> anyResult = Task.WhenAny(tasks).Unwrap(); //WhenAny: holt das Resultat vom ersten fertigen Task
		int res = anyResult.Result;
		Console.WriteLine(res);
	}

	public static int Square(object value)
	{
		return (int) value * (int) value;
	}
}