namespace CSharp8
{

    public class Program
    {
		static void Main(string[] args)
		{
			Car car = new Car(10, "Test");
            //Record Variable
            //Wird verwendet für Daten
        }
    }

    public record Car(int id, string name); //Record Definition, Code-Behind darunter

    //Referenztyp wie Klasse, aber Funktionalität wie Struct
    //== vergleicht alle Werte statt HashCode
    //Klassenmethoden weiterhin (ToString, GetHashCode, ...)
    //Nur andere Records vererben
    public class CarCompiled
    {
        public int ID { get; init; } //init: Kann nur im Konstruktor oder bei Erstellung von Objekt verwendet werden

        public string Name { get; init; }

        public CarCompiled(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
