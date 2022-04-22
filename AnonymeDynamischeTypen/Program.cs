using Newtonsoft.Json;
using System.Dynamic;

public class Program
{
	static void Main(string[] args)
	{
		dynamic obj = new ExpandoObject(); //Dynamischer Typ
		obj.Name = "Max";
		obj.Description = "Keine Ahnung";
		obj.ID = 23;
		obj.Feierabend = true;

		if (obj.ID == 23)
		{
			//...
		}

		string s = JsonConvert.SerializeObject(obj, Formatting.Indented); //Dynamic Objekt zu Json konvertieren
		object o = JsonConvert.DeserializeObject(s);

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		var student = new { Name = "Test", ID = 12 }; //Anonymes Objekt
		var anon = fahrzeuge.Select(fzg => new { fzg.MaximalGeschwindigkeit, fzg.Marke }).ToList(); //Anonymous Type: einzelne Felder nehmen und durch den Code bewegen

		string anonymousJson = JsonConvert.SerializeObject(anon, Formatting.Indented); //Anonymous Objekt zu Json konvertieren
		object anonymousObj = JsonConvert.DeserializeObject(anonymousJson);
	}

	public record Fahrzeug(int MaximalGeschwindigkeit, FahrzeugMarke Marke);

	public enum FahrzeugMarke
	{
		BMW, VW, Audi
	}
}