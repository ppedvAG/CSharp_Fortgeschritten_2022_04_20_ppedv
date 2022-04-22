namespace CSharp7
{
	internal class DefaultLiterale
	{
		static void Main(string[] args)
		{
		}

		public void Default()
		{
			int i = default; //0
			string s = default; //null
			Func<string, int> f = default; //delegates: null

			if (i is default) //Hier default check
				Console.WriteLine("i hat den Standardwert");

			DefaultLiterale x = default(DefaultLiterale); //default(Typ): gibt den default Wert für einen Typen zurück
		}
	}
}
