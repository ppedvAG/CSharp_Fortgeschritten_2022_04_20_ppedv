public class Program
{
	static void Main(string[] args)
	{
        int until = 10000;
        Task<List<long>> numbers = Task.Run(() => GetPrimeNumbers(10000));
        List<long> result = numbers.Result;
		Console.WriteLine($"Nummern berechnet bis {until}");

        numbers.ContinueWith(_ => WriteNumbersToFile(result));
		Console.WriteLine("Nummern geschrieben");
        Console.ReadKey();
    }

    public static void WriteNumbersToFile(List<long> num)
	{
        File.WriteAllLines("file.txt", num.Select(e => e.ToString()).ToArray());
	}

    public static List<long> GetPrimeNumbers(long until)
    {
        List<long> retValues = new List<long>();
        for (long i = 1; i < until; i += 2)
            if (CheckPrime(i))
                retValues.Add(i);
        return retValues;
    }

    private static bool CheckPrime(long num)
    {
        for (long i = 2; i < num; i++)
            if (num % i == 0)
                return false;
        return true;
    }
}