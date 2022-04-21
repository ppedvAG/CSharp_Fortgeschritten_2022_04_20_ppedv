public class Program
{
	static void Main(string[] args)
	{
		Task<string> task = Task.Run(DayTime);
		Task<string> cont = task.ContinueWith(task => task.Result); //task: vorheriger Task, task.Result: Ergebnis vom vorherigen Task
		string result = cont.Result;
	}

	public static string DayTime()
	{
		DateTime dt = DateTime.Now;
		return dt.Hour > 19 ? "Abend" : dt.Hour > 12 ? "Nachmittag" : "Morgen";
	}
}