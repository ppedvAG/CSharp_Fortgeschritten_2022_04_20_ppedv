public class Program
{
	static void Main(string[] args)
	{
		string[] words = GetWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

		Parallel.Invoke(() => //Mehrere Tasks gleichzeitig starten
		{
			//Längstes Wort
			GetLongestWord(words);
		},
		() =>
		{
			//Häufigstes Wort
			GetMostCommonWords(words);
		},
		() =>
		{
			//Zähle ein Wort
			GetCountForWord(words, "sleep");
		});

		Console.ReadKey();
	}

	static void GetLongestWord(string[] words)
	{
		Console.WriteLine("Längstes Wort: ");
		Console.WriteLine(words.OrderByDescending(e => e.Length).First());
	}

	static void GetCountForWord(string[] words, string wort)
	{
		Console.WriteLine("Anzahl sleep: ");
		Console.WriteLine(words.Count(e => e.Equals(wort, StringComparison.OrdinalIgnoreCase)));
	}

	static void GetMostCommonWords(string[] words)
	{
		Console.WriteLine("Häufigste Wörter: ");
		Console.WriteLine
		(
			words
			.Where(e => e.Length >= 7)
			.GroupBy(e => e.ToLower())
			.ToDictionary(e => e.Key, e => e.Count())
			.OrderByDescending(e => e.Value)
			.Take(10)
			.Aggregate("", (agg, kv) => agg + $"{kv.Key}: {kv.Value}\n")
		);
	}

	static string[] GetWordArray(string url)
	{
		HttpClient client = new HttpClient();
		string full = client.GetStringAsync(url).Result;
		return full.Split(new char[] { ' ', '\n', ',', '.', ';', ':', '-', '_', '/' }, StringSplitOptions.RemoveEmptyEntries);
	}
}