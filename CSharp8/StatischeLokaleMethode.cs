namespace CSharp8
{
	internal class StatischeLokaleMethode
	{
		public void Main()
		{
			int x = 5;

			static void Square() //Kein Zugriff mehr auf übergeordnete Methode
			{
				//Console.WriteLine(x * x);
			}
		}
	}
}
