namespace CSharp8
{
	internal class IndizesRanges
	{
		static void Main2(string[] args)
		{
			int[] ints = Enumerable.Range(0, 10).ToArray(); //Enumerable.Range: gibt eine aufsteigende Liste von Start mit Count Elementen
			int letzte = ints[^1]; //^: Von Rechts (Length - <Wert>, also 0 nicht funktional)
			int[] mitte = ints[3..6]; //X..Y: Bereich von 3 bis 5 ohne Obergrenze
			int[] letzteZwei = ints[^2..^0]; //Hier letzte Zwei aber ^0 ist valide in einer Range
			int[] alle = ints[..]; //Holt alles (für was?)
			int[] nullBisGrenze = ints[..4]; //0-3
			int[] mitteBisEnde = ints[6..]; //6-9
		}
	}
}
