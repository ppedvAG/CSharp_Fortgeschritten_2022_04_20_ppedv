namespace BuilderPattern;

public class Program
{
	static void Main(string[] args)
	{
		IBuildable car = new Car();

		Director d = new Director();

		Vehicle p = d.Construct(car);

		p.Show();
	}
}