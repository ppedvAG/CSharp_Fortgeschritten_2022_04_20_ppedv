namespace BuilderPattern
{
	public class Car : IBuildable
	{
		private Product vehicle;

		public Car()
		{
			vehicle = new Product();
		}

		public void ErstelleBasisGerät()
		{
			vehicle.Add("Karosserie");
		}

		public void ReifenHinzufügen()
		{
			vehicle.Add("4 Reifen");
		}

		public void ScheinwerferHinzufügen()
		{
			vehicle.Add("2 Scheinwerfer");
		}

		public Product GetVehicle()
		{
			return vehicle;
		}
	}
}
