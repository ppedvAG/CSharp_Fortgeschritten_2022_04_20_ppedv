namespace CSharp7
{
	internal class LokaleFunktionen
	{
		public void LocalFunction()
		{
			int x = 5;
			Square(x);

			//lokale Methode, nur in der LocalFunction() sichtbar
			int Square(int zahl) 
			{
				x = 5; //Rausgreifen
				return zahl * zahl;
			}
		}
	}
}
