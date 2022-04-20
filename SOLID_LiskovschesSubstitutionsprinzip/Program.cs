public class BadKirsche
{
	public string Color = "Red";
}

public class BadErdbeere : BadKirsche 
{
	public void PrintColor()
	{
		Console.WriteLine(Color);
	}
}

public class Fruit
{
	public string Color { get; set; }
}

public class Kirsche : Fruit
{
	public void PrintColor()
	{
		Console.WriteLine("Red");
	}
}

public class Erdbeere : Fruit
{
	public void PrintColor()
	{
		Console.WriteLine("Red");
	}
}