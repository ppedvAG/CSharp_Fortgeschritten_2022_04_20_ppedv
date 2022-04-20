namespace BuilderPattern
{
	public class Director
	{
		IBuildable product;

		public Vehicle Construct(IBuildable product)
		{
			//Referenz zu car
			this.product = product;
			this.product.ErstelleBasisGerät();
			this.product.ReifenHinzufügen();
			this.product.ScheinwerferHinzufügen();
			return product.GetVehicle();
		}
	}
}
