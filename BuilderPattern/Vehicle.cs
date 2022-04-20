namespace BuilderPattern
{
	public class Vehicle
	{
		private List<string> Parts;

		public Vehicle()
		{
			Parts = new List<string>();
		}

		public void Add(string part)
		{
			Parts.Add(part);
		}

		public void Show()
		{
			Console.WriteLine("Product: ");

			foreach (string s in Parts)
				Console.WriteLine(s);
		}
	}
}