namespace BuilderPatternAbstract
{
	public class SandwichMaker
	{
		private SandwichBuildable sandwich;

		public SandwichMaker(SandwichBuildable sandwich)
		{
			this.sandwich = sandwich;
		}

		public void BuildSandwich()
		{
			sandwich.AddBread();
			sandwich.AddMeat();
			sandwich.AddCondiments();
			sandwich.AddCheese();
			sandwich.AddVeggies();
		}
	}
}
