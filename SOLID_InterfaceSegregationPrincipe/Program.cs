public interface IBadVehicle
{
	void CanDrive();

	void CanFly();
	
	void CanSwim();
}

public class BadVehicle : IBadVehicle
{
	public void CanDrive()
	{
		//Drive Code
	}

	public void CanFly()
	{
		throw new NotImplementedException();
	}

	public void CanSwim()
	{
		//Swim Code
	}
}

public interface IDriveVehicle
{
	void Drive();
}

public interface ISwimVehicle
{
	void Swim();
}

public interface IFlyVehicle
{
	void Fly();
}

public class Car : IDriveVehicle
{
	public void Drive()
	{
		//Drive Code
	}
}

public class AmphibischeVehicle : IDriveVehicle, ISwimVehicle
{
	public void Drive()
	{
		//Drive Code
	}

	public void Swim()
	{
		//Swim Code
	}
}