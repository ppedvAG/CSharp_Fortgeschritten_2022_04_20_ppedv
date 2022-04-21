using System.Text;

public class Program
{
	static void Main(string[] args)
	{
		string[] words = GetWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

		Parallel.Invoke(() => //Mehrere Tasks gleichzeitig starten
		{
			//Längstes Wort
			Console.Write("Längstes Wort: ");
			GetLongestWord(words);
		},
		() =>
		{
			//Häufigstes Wort
			Console.WriteLine("Häufigste Wörter: ");
			GetMostCommonWords(words);
		},
		() =>
		{
			//Zähle ein Wort
			Console.WriteLine("Anzahl sleep: ");
			GetCountForWord(words, "sleep");
		});

		Console.ReadKey();
	}

	static void GetLongestWord(string[] words)
	{
		Console.WriteLine(words.OrderByDescending(e => e.Length).First());
	}

	static void GetCountForWord(string[] words, string wort)
	{
		Console.WriteLine(words.Count(e => e.Equals(wort, StringComparison.OrdinalIgnoreCase)));
	}

	static void GetMostCommonWords(string[] words)
	{
		var frequencyOrder = from word in words
							 where word.Length > 6
							 group word by word into g
							 orderby g.Count() descending
							 select g.Key;

		var commonWords = frequencyOrder.Take(10);

		StringBuilder sb = new StringBuilder();
		foreach (var v in commonWords)
		{
			sb.AppendLine("  " + v);
		}
		Console.WriteLine(sb.ToString());
	}

	static string[] GetWordArray(string url)
	{
		HttpClient client = new HttpClient();
		string full = client.GetStringAsync(url).Result;
		return full.Split(new char[] { ' ', '\n', ',', '.', ';', ':', '-', '_', '/' }, StringSplitOptions.RemoveEmptyEntries);
	}
}