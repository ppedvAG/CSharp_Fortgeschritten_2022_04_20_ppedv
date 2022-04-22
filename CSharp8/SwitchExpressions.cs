namespace CSharp8
{
	internal class SwitchExpressions
	{
		public string Wochentag()
		{
			//switch (DateTime.Now.DayOfWeek)
			//{
			//	case DayOfWeek.Monday:
			//		return "Montag";
			//	case DayOfWeek.Tuesday:
			//		return "Dienstag";
			//	case DayOfWeek.Wednesday:
			//		return "Mittwoch";
			//	case DayOfWeek.Thursday:
			//		return "Donnerstag";
			//	case DayOfWeek.Friday:
			//		return "Freitag";
			//	default:
			//		return "Wochenende";
			//}

			return DateTime.Now.DayOfWeek switch //Strg + .: direkt umwandeln
			{
				DayOfWeek.Monday => "Montag", //keine cases sondern Lambda
				DayOfWeek.Tuesday => "Dienstag",
				DayOfWeek.Wednesday => "Mittwoch",
				DayOfWeek.Thursday => "Donnerstag",
				DayOfWeek.Friday => "Freitag",
				_ => "Wochenende", //_: Default
			};
		}

		public int GetBonus(Mitarbeiter ma)
		{
			return ma switch //return <Object> switch
			{
				{ Alter: 20 } => 1000, //In Mitarbeiter hineingreifen
				{ Alter: 21 } => 1100, //{ Property: <Wert> }
				{ Alter: 22 } => 1200,
				{ Alter: 23 } => 1300,
				{ Alter: 24 } => 1400,
				{ Alter: 25 } => 1500,
				{ Kollege.Alter: 26 } => 2000, //In Objekte reingreifen
				_ => 0
			};
		}

		public int GetBonus2(Mitarbeiter ma) //Position Pattern mit Deconstruct
		{
			return ma switch
			{
				var (alter, kollege) when alter >= 20 => 1000, //Deconstruct Methode erforderlich
				var (alter, kollege) when alter >= 21 && kollege.Alter >= 25 => 1000, //Mehrere Bedingungen
				_ => 0 //default case
			};
		}

		public string SchereSteinPapier(string auswahl1, string auswahl2) //Tupel Pattern
		{
			return (auswahl1, auswahl2) switch //Tupel switchen
			{
				("Schere", "Stein") => "Stein", //Möglichkeiten durchgehen
				("Schere", "Papier") => "Schere",
				_ => "Unentschieden"
			};
		}
	}

	public class Mitarbeiter
	{
		public int Alter { get; set; }

		public Mitarbeiter Kollege { get; set; }

		public void Deconstruct(out int a, out Mitarbeiter k)
		{
			a = Alter;
			k = Kollege;
		}
	}
}
