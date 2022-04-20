namespace BuilderPatternAbstract
{
	public class TurkeyClub : SandwichBuildable
	{
        public TurkeyClub()
		{
            sandwich = new Sandwich(SandwichType.TurkeyClub);
		}

		public override void AddBread()
		{
			sandwich["bread"] = "12-Grain";
		}

        public override void AddMeat()
        {
            sandwich["meat"] = "Turkey";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "Swiss";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }
}
