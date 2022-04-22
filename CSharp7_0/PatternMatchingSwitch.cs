namespace CSharp7
{
	internal class PatternMatchingSwitch
	{
		public void PatternMatching(Grafik g)
		{
			switch (g) //Typ switchen
			{
				case Kreis k:
					Console.WriteLine("Grafik ist Kreis");
					break;
				case Rechteck r when r.Breite == r.Länge:
					Console.WriteLine("Rechteck ist ein Quadrat");
					break;
				case Rechteck r: //Hier wieder direkter Cast
					r.Breite = 5;
					r.Länge = 5;
					break;
			}
		}

		public void PatternMatching<T>(T input) where T : Grafik
		{
			switch (input)
			{
				case Rechteck r:
					Console.WriteLine("Ist Rechteck " + r.Länge);
					break;
				case Kreis k:
					Console.WriteLine("Ist Kreis");
					break;
			}
		}

		public abstract class Grafik { }

		public class Rechteck : Grafik
		{
			public int Länge, Breite;
		}

		public class Kreis : Grafik { }
	}
}
