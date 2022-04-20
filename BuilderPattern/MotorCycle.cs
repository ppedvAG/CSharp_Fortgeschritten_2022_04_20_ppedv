namespace BuilderPattern
{
	public class MotorCycle : IBuildable
	{
		private Vehicle vehicle;

		public MotorCycle()
		{
			vehicle = new Vehicle();
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

		public Vehicle GetVehicle()
		{
			return vehicle;
		}
	}
}
