namespace BuilderPatternAbstract;

public class Program
{
	static void Main(string[] args)
	{
		TurkeyClub turkeyClub = new TurkeyClub();

		SandwichMaker s = new SandwichMaker(turkeyClub);
		s.BuildSandwich();

		Sandwich sandwich = turkeyClub.Sandwich;
		sandwich.Show();
	}
}