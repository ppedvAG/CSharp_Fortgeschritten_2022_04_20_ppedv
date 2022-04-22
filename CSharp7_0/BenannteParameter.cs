namespace CSharp7
{
	internal class BenannteParameter
	{
		public void Main()
		{
			int zahl1 = 3;
			int zahl2 = 4;
			int zahl3 = 5;

			Summe(z: zahl1, y: zahl2, x: zahl3); //Ordnung für Parameter festlegen
		}

		public int Summe(int x, int y, int z) => x + y + z;
	}
}
