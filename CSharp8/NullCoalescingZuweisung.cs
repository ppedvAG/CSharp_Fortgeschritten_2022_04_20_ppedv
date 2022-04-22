namespace CSharp8
{
	internal class NullCoalescingZuweisung
	{
		public void Method()
		{
			List<int> list = null;
			list ??= new List<int>(); //Liste erstellen wenn null

			int? zahl = null;
			zahl ??= 3;
			zahl ??= 5; //Keine Zuweisung
		}
	}
}
