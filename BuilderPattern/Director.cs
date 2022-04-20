namespace BuilderPattern
{
	public class Director
	{
		IBuildable product;

		public void Construct(IBuildable product)
		{
			//Referenz zu car
			this.product = product;
			this.product.ErstelleBasisGerät();
			this.product.ReifenHinzufügen();
			this.product.ScheinwerferHinzufügen();
		}
	}
}
