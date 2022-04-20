namespace BuilderPattern
{
	public interface IBuildable
	{
		void ErstelleBasisGerät();

		void ReifenHinzufügen();

		void ScheinwerferHinzufügen();

		Vehicle GetVehicle();
	}
}
