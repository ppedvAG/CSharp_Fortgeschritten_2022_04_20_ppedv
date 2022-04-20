namespace BuilderPattern
{
	public class Car : IBuildable
	{
		private Vehicle vehicle;

		public Car()
		{
			vehicle = new Vehicle();
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

		public Vehicle GetVehicle()
		{
			return vehicle;
		}
	}
}
