public class Program
{
	static void Main(string[] args)
	{
		Task<Task<int>> t = null;
		Task<int> unwrapped = t.Unwrap(); //Unwrap: entfernt eine Task Ebene vom Task

		Task<byte[]> data = Task.Run(GetData);

		Task<Task<byte>> schritt2 = data.ContinueWith(task => Task.Run(() => Compute(task.Result))); //Tasks verschachteln

		schritt2.Unwrap(); //Hier Task<byte> herausbekommen
	}

	private static byte[] GetData()
	{
		Random rand = new Random();
		byte[] bytes = new byte[64];
		rand.NextBytes(bytes);
		return bytes;
	}

	static byte Compute(byte[] data)
	{
		byte final = 0;
		foreach (byte item in data)
		{
			final ^= item;
			Console.WriteLine("{0:x}", final);
		}
		Console.WriteLine("Done computing");
		return final;
	}
}