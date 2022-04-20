//Programmierer B: Fängt Tag 1 an und braucht 5 Tage
public class BadCar
{
	public string Marke { get; set; }
	public string Modell { get; set; }
	public int Baujahr { get; set; }
}

//Programmierer A: Fängt Tag 1 an und braucht 3 Tage
public class BadCarService
{
	public void Repair(BadCar c)
	{

	}
}

//Tag 1
public interface ICar
{
	string Marke { get; set; }
	string Modell { get; set; }
	int Baujahr { get; set; }
}

public interface ICarService
{
	void RepairPKW(ICar c); //Lose Kopplung mit Interface
}

public class CarService : ICarService
{
	public void RepairPKW(ICar c)
	{

	}

	public void RepairLKW(ICar c)
	{

	}
}

//Testklasse Dummy Objekt/Test Objekt
public class DummyCar : ICar
{
	public string Marke { get; set; } = "VW";
	public string Modell { get; set; } = "Golf";
	public int Baujahr { get; set; } = 2015;
}

//Programmierer B: Braucht 5 Tage
public class Car : ICar
{
	public string Marke { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public string Modell { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public int Baujahr { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public class Program
{
	static void Main(string[] args)
	{
		CarService cs = new CarService();
		cs.RepairPKW(new Car());
	}
}