namespace CSharp8
{
	internal class Patterns
	{
		public void TempToWetter()
		{
			int temp = 4;
			string temperatur = temp switch //switch Expression bei Variablenzuweisung
			{
				< 0 => "Sehr Kalt",
				> 0 and <= 10 => "Kalt",
				> 10 and <= 20 => "Warm",
				> 20 => "Heiß",
				_ => "Unbekannt"
			};
		}

		bool IstBuchstabe(char c)
		{
			//if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') //Simpelste Methode
			//{ }

			//if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z') //Mit Pattern Matching
			//	return true;
			//return false;

			return c is >= 'a' and <= 'z' or >= 'A' and <= 'Z'; //Maximales Pattern Matching
		}
	}
}
