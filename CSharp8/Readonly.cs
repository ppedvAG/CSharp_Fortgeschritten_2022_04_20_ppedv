namespace CSharp8
{
	internal class Readonly { }

	public struct Point
	{
		public int X { get; set; }

		public int Y { get; set; }

		public readonly int Z = 5; //Kann nur im Konstruktor gesetzt werden oder hier direkt

		public const int Length = 10; //Kann nur hier gesetzt und nicht geändert werden

		public Point()
		{
			X = 5;
			Y = 5;
			Z = 5;
		}

		public readonly double Entfernung => Math.Sqrt(X * X + Y * Y); //Kein *= auf Variablen da readonly

		public readonly void Berechne(int xOffset, int yOffset)
		{
			//X++; //Keine Zuweisungen erlaubt, da readonly
			//X += xOffset;
		}

		public void SetZ()
		{
			//Z = 5; //Nicht valide
		}
	}
}
