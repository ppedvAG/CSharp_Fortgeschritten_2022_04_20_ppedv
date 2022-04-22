namespace CSharp8
{
	public interface InterfaceFeatures
	{
		public static int Etwas = 50; //InterfaceFeatures.Etwas -> 50

		protected static int Test2; //Protected oder Internal statt Public

		public virtual void Test() //Methode mit Code
		{
			//Bad practice
		}
	}

	public class InterfaceTest : InterfaceFeatures
	{
		static void Main2(string[] args)
		{
			InterfaceFeatures.Etwas = 20; //Statische Werte im Interface haben

			InterfaceFeatures test = new InterfaceTest();
			test.Test(); //Methode ausführen mit Varibale vom Interfacetyp
		}
	}
}
