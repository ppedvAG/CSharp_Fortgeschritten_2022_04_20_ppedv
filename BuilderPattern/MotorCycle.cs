namespace BuilderPattern
{
	public class MotorCycle : IBuildable
	{
		private Product vehicle;

		public MotorCycle()
		{
			vehicle = new Product();
		}

		public void ErstelleBasisGerät()
		{
			Console.WriteLine("Karosserie");
		}

		public void ReifenHinzufügen()
		{
			Console.WriteLine("2 Reifen");
		}

		public void ScheinwerferHinzufügen()
		{
			Console.WriteLine("Ein Scheinwerfer");
		}

		public Product GetVehicle()
		{
			return vehicle;
		}
	}
}
