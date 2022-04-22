namespace CSharp7
{
	internal class AsyncMain
	{
		static async Task Main3(string[] args) //async Main, muss Task returnen
		{
			await Task.Delay(2000); //Hier funktioniert Delay da awaited

			Console.WriteLine("Hallo");
		}

		static void Main2(string[] args)
		{
			Task.Delay(2000); //Hier läuft Delay Sync -> Kein Delay

			Console.WriteLine("Test");
		}
	}
}
