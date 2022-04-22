namespace CSharp7
{
	internal class Out
	{
		public void OutMethod()
		{
			string parse = "123";
			int result; //Extra Variable
			if (int.TryParse(parse, out result)) //Zwei return Werte
			{
				Console.WriteLine(result * 2);
			}

			if (int.TryParse(parse, out int result2)) //Variablendefinition bei out direkt
			{
				Console.WriteLine(result2 * 2);
			}
		}
	}
}
