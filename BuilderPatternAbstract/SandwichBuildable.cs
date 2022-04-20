namespace BuilderPatternAbstract
{
	public abstract class SandwichBuildable
	{
		protected Sandwich sandwich;

		public Sandwich Sandwich => sandwich;

		public abstract void AddBread();
		public abstract void AddMeat();
		public abstract void AddCheese();
		public abstract void AddVeggies();
		public abstract void AddCondiments();
	}
}
