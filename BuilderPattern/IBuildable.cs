namespace BuilderPattern
{
	public interface IBuildable
	{
		void ErstelleBasisGerät();

		void ReifenHinzufügen();

		void ScheinwerferHinzufügen();

		Product GetVehicle();
	}
}
