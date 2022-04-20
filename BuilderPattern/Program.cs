namespace BuilderPattern;

public class Program
{
	static void Main(string[] args)
	{
		Director d = new Director();

		IBuildable car = new Car();

		d.Construct(car); //Referenz zu car

		Product p = car.GetVehicle();

		p.Show();
	}
}