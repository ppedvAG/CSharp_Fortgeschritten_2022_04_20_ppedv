namespace CSharp7
{
	internal class PatternMatchingTypes
	{
		public void PatternMatching(object o)
		{
			if (o is null)
				return;

			if (o is string)
			{
				string s = (string) o; //Cast
			}

			if (o is int zahl) //Direkten Cast
			{
				Console.WriteLine(zahl * 2);
			}

			//Wenn o string = true (Vergleich mit Vererbungshierarchie)
			if (o is IEnumerable<char>)
			{

			}

			//Genauer Typvergleich
			if (o.GetType() == typeof(IEnumerable<char>))
			{

			}
		}
	}
}
