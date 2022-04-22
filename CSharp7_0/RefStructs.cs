namespace CSharp7
{
	internal class RefStructs
	{
		public void Ref()
		{
			SehrGrossesStruct s1 = new SehrGrossesStruct();
			SehrGrossesStruct s2 = new SehrGrossesStruct();

			//Wertetypen können Standardmäßig nicht referenziert werden aber mit ref schon
			ref SehrGrossesStruct referenz = ref s1;
			referenz = ref s2;
		}
	}

	public struct SehrGrossesStruct { } //Wertetyp
}
