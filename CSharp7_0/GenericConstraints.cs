namespace CSharp7
{
	internal class GenericConstraints
	{
	}

	public class DataStore<T> where T : Enum { } //Enum erzwingen bei Generic

	public class DataStore1<T> where T : Delegate { } //Delegate erzwingen

	public class DataStore2<T> where T : unmanaged { } //int, double, enums, pointer, ...
	//alles unmanaged: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types
}
