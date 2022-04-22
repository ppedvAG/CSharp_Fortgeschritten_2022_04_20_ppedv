namespace CSharp7
{
	internal class ExpressionBodies : IExpressionBody
	{
		public ExpressionBodies() => Console.WriteLine("Konstruktor");

		//null coalescing Operator (??): wenn nicht null setze es, sonst wirf Exception
		public ExpressionBodies(string name) => Name = name ?? throw new NullReferenceException();

		~ExpressionBodies() => Console.WriteLine("Destruktor");

		private string name;

		public string Name
		{
			get => name; //Genau wie bei Methoden
			set => name = value;
		}

		//Exceptions in Expression Bodies (throw fällt nicht weg)
		public int Zahl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Method() => Console.WriteLine("Einzeilig"); //Klammern fallen weg, => stattdessen

		public int MethodReturn() => 0; //return fällt weg
	}

	public interface IExpressionBody
	{
		int Zahl { get; set; }
	}
}
