public class Program
{
	public static void Main(string[] args)
	{
		List<int> intListe = Enumerable.Range(0, 20).ToList();

		intListe.Average(); //Liste aufaddieren / intListe.Count
		intListe.Min();
		intListe.Max();

		intListe.Sum();

		intListe.First(); //Erstes Element, wenn kein Element vorhanden Exception
		intListe.FirstOrDefault(); //Erstes Element, wenn kein Element vorhanden -> null

		intListe.Last(); //Erstes Element, wenn kein Element vorhanden Exception
		intListe.LastOrDefault(); //Erstes Element, wenn kein Element vorhanden -> null

		intListe.Single(e => e == 5); //Einziges Element, wenn kein oder mehrere Element vorhanden Exception
		intListe.SingleOrDefault(e => e == 5); //Erstes Element, wenn mehrere Elemente vorhanden Exception, wenn kein Element null

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

		//Alle BMWs
		List<Fahrzeug> bmwsForEach = new List<Fahrzeug>();
		foreach (Fahrzeug fzg in fahrzeuge)
			if (fzg.Marke == FahrzeugMarke.BMW)
				bmwsForEach.Add(fzg);

		//SQL-ähnliche Schreibweise (alt)
		List<Fahrzeug> bmws = (from fzg in fahrzeuge where fzg.Marke == FahrzeugMarke.BMW select fzg).ToList();

		//Methodenkette: Neueste Schreibweise
		List<Fahrzeug> bmwsNeu = fahrzeuge.Where(auto => auto.Marke == FahrzeugMarke.BMW).ToList();

		//Schnellstes Auto
		fahrzeuge.Max(fzg => fzg.MaximalGeschwindigkeit);
		fahrzeuge.OrderByDescending(fzg => fzg.MaximalGeschwindigkeit).First();

		//Automarken
		List<FahrzeugMarke> marken = fahrzeuge.Select(fzg => fzg.Marke).ToList(); //Select: Variable von der Liste auf neue Liste mappen

		//Einzigartige Automarken
		List<FahrzeugMarke> einzigartig = marken.Distinct().ToList(); //Distinct: Jedes Element einzigartig machen

		//Alle MaxV's aufsummieren
		fahrzeuge.Sum(fzg => fzg.MaximalGeschwindigkeit);

		//Alle VWs mit mindestens 200km/h aufsummieren
		fahrzeuge.Where(fzg => fzg.Marke == FahrzeugMarke.VW && fzg.MaximalGeschwindigkeit >= 200).Sum(fzg => fzg.MaximalGeschwindigkeit); //Mehrere Bedingungen mit &&

		//Check ob alle Autos über 200 fahren können
		bool alleAutosSchnell = fahrzeuge.All(fzg => fzg.MaximalGeschwindigkeit >= 200);

		//Check ob mindestens ein Autos über 200 fahren kann
		bool einAutosSchnell = fahrzeuge.Any(fzg => fzg.MaximalGeschwindigkeit >= 200);

		IEnumerable<Fahrzeug[]> chunks = fahrzeuge.Chunk(5); //Teilt Liste in 5er Teile auf (letzte 2 Fahrzeuge bekommen eigenes Array)

		fahrzeuge.Append(null); //Hänge Fahrzeug dran am Ende
		fahrzeuge.Prepend(null); //Hänge Fahrzeug dran am Anfang
		fahrzeuge.Concat(new List<Fahrzeug>()); //Liste dranhängen

		//Summiere alle Maximalgeschwindigkeiten
		int summe = fahrzeuge.Aggregate(0, (agg, fzg) => agg + fzg.MaximalGeschwindigkeit); //0: Aggregator, (<Aggregatorname>, <Listenvariable>) => ...

		//Liste printen
		string output = fahrzeuge.Aggregate(string.Empty, (agg, fzg) => agg + $"{fzg.Marke}: {fzg.MaximalGeschwindigkeit}\n");
		Console.WriteLine(output);

		//Fahrzeuge nach Marke gruppieren (BMW Gruppe, VW Gruppe, Audi Gruppe)
		var group = fahrzeuge.GroupBy(fzg => fzg.Marke);
		var fahrzeugeAusGruppe = group.First(fzg => fzg.Key == FahrzeugMarke.BMW).Select(fzg => fzg); //Hier in Grouping reingreifen

		//ToDictionary
		Dictionary<FahrzeugMarke, List<Fahrzeug>> dict = fahrzeuge.GroupBy(fzg => fzg.Marke).ToDictionary(fzg => fzg.Key, fzg => fzg.Select(e => e).ToList());
	}

	public record Fahrzeug(int MaximalGeschwindigkeit, FahrzeugMarke Marke);

	public enum FahrzeugMarke
	{
		BMW, VW, Audi
	}
}