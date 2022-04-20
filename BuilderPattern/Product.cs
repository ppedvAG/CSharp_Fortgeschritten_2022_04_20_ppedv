namespace BuilderPattern
{
	public class Product
	{
		private List<string> Parts;

		public Product()
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