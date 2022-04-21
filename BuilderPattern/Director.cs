namespace BuilderPattern
{
	public class Director
	{
		public Vehicle Construct(IBuildable product)
		{
			product.ErstelleBasisGerät();
			product.ReifenHinzufügen();
			product.ScheinwerferHinzufügen();
			return product.GetVehicle();
		}
	}
}
