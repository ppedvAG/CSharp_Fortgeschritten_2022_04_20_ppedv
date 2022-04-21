namespace DelegatesActionFuncPredicate
{
	public class Program2
	{
		static void Main(string[] args)
		{
			ComponentWithEvent c = new ComponentWithEvent();
			c.ValueChanged += (i) => Console.WriteLine(i); //Action mit einem int (i)
			c.ProcessCompleted += () => Console.WriteLine("Fertig"); //Action ohne Parameter mit leeren Klammern und Pfeil
			c.StartProcess();
		}
	}

	public class ComponentWithEvent
	{
		public event Action ProcessCompleted;
		public event Action<int> ValueChanged;

		public void StartProcess()
		{
			for(int i = 0; i < 100; i++)
			{
				ValueChanged(i);
			}
			ProcessCompleted?.Invoke(); //Invoke für null check (mit ?)
		}
	}

	public class ValueEventArgs : EventArgs
	{
		public int Value { get; set; }
	}
}