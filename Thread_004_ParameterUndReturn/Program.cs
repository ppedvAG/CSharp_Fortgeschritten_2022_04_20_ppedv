public class Program
{
	private static string ReturnString = string.Empty;

	static void Main(string[] args)
	{
		string s = "Test";
		Thread t = new Thread(() => //Workaround um Thread Limits
		{
			ReturnString = ToUpper(s); //"Parameter" und "Return Wert"
		});
		t.Start();
	}

	static string ToUpper(string param)
	{
		return param.ToUpper();
	}
}