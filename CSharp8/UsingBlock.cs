namespace CSharp8
{
	internal class UsingBlock
	{
		public void Using()
		{
			using (MemoryStream stream = new MemoryStream()) //Using Block
			{

			}
			//Am Ende Dispose() -> räumt den Speicher auf

			using MemoryStream stream2 = new MemoryStream();
			//...
			//Dispose wird aufgerufen wenn Objekt nicht mehr verwendet wird
		}
	}
}
