using System.Net;

public class Program
{
	static void Main(string[] args)
	{
		Task<string> str = Download();
		str.Wait();
		Console.WriteLine(str.Result);
		Console.ReadKey();
	}

	public static async Task<string> Download() //async um awaitable Code nach oben weiterzugeben, der dann mit einem Task abgearbeitet werden sollte
	{
		WebClient webClient = new WebClient();
		return await webClient.DownloadStringTaskAsync(new Uri(@"http://www.gutenberg.org/files/54700/54700-0.txt")); //await direkt aufs Resultat gehen
	}

	//Mögliche Async Methoden (void, Task, Task<T>, ValueTask<T>)
	//public async void Void() { } //Keine Exception

	//public async Task Task() { }

	//public async Task<string> TaskGeneric() { }

	//public async ValueTask<string> ValueTask() { }
}