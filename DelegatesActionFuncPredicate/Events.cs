namespace DelegatesActionFuncPredicate
{
	public class Events
	{
		static event EventHandler Event;

		static event EventHandler<TestEventArgs> TestEvent;

		static void Main2(string[] args)
		{
			Event += Events_Event; //Wie bei Delegate
			Event(null, new EventArgs()); //Aufruf von Event mit sender (hier null da static) und EventArgs

			TestEvent += Events_TestEvent;
			TestEvent(null, new TestEventArgs() { Status = "Test" });
		}

		private static void Events_TestEvent(object? sender, TestEventArgs e)
		{
			Console.WriteLine(e.Status);
		}

		private static void Events_Event(object? sender, EventArgs e) { }
	}

	public class TestEventArgs : EventArgs
	{
		public string Status { get; set; }
	}
}
