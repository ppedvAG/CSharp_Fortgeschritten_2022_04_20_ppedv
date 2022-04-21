public class Program
{
	static Mutex Mutex;

	static void Main(string[] args)
	{
		if (Mutex.TryOpenExisting("009", out Mutex)) //Checken ob Applikation läuft
		{
			Console.WriteLine("Applikation läuft schon");
			Environment.Exit(0);
		}
		else
		{
			Mutex = new Mutex(false, "009"); //Wenn nicht läuft, Mutex belegen
		}
		Mutex.ReleaseMutex(); //Mutex freigeben
	}
}