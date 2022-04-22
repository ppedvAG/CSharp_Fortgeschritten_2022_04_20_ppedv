namespace CSharp7
{
	internal class In
	{
		public void Input(in int x) //Parameter readonly machen
		{
			x++; //Nicht möglich da in-Keyword
		}
	}
}
