namespace Erweiterungsmethoden;

public static class ExtensionMethods //static Klasse
{
	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list) //mit this auf Typ verweisen auf den die Methode drankommen soll
	{
		return list.OrderBy(e => Random.Shared.Next());
	}

	public static int Quersumme(this int x) //Erweiterungmethoden sind auch static
	{
		return x.ToString().ToCharArray().Sum(c => (int) char.GetNumericValue(c));
	}
}