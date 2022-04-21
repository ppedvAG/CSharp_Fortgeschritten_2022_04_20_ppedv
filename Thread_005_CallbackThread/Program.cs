public class Program
{
	public delegate void CallbackDelegate(ReturnObject ro);

	static void Main(string[] args)
	{
		ThreadWithState tws = new ThreadWithState("Test", 123, new CallbackDelegate(Result)); //Result Methode an delegate anhängen
		Thread t = new Thread(tws.ThreadReturn); //Danach wird ThreadReturn ausgeführt und über das delegate kommt das Objekt zurück
		t.Start();
	}

	public static void Result(ReturnObject ro) //ThreadReturn ruft die Result Methode über das delegate auf
	{
		Console.WriteLine($"{ro.Text}, {ro.Zahl}");
	}

	public class ThreadWithState
	{
		private string text;
		private int zahl;
		private CallbackDelegate callback;

		public ThreadWithState(string text, int zahl, CallbackDelegate cd) //delegate übergeben und gespeichert in callback Variable
		{
			this.text = text;
			this.zahl = zahl;
			callback = cd;
		}

		public void ThreadReturn() //Thread Methode
		{
			ReturnObject returnObject = new ReturnObject();
			returnObject.Text = text;
			returnObject.Zahl = zahl;
			//Lange Operation
			callback(returnObject); //Return Wert in die Methode am delegate geben
		}
	}

	public class ReturnObject
	{
		public string Text { get; set; }

		public int Zahl { get; set; }
	}
}