using System;
using System.Diagnostics;
using System.Text;

public class Program
{
	static void Main2(string[] args)
	{
		//string: char array [H][a][l][l][o] -> 5 Stellen, kann nicht dynamisch erweitert werden
		//+: Alter string wird kopiert und neuer string wird drangehängt

		string aufbau = string.Empty;

		Stopwatch sw = new Stopwatch();
		sw.Start();

		for (int i = 0; i < 10000; i++)
			aufbau += i; //Alten string kopieren + dranhängen -> Performanceintensiv

		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);

		Console.ReadKey();

		StringBuilder sb = new StringBuilder();

		Stopwatch sw2 = new Stopwatch();
		sw2.Start();

		for (int i = 0; i < 1000000; i++)
			sb.Append(i); //Append statt +=

		string output = sb.ToString();  //ToString(): string zusammenbauen
		sw2.Stop();
		Console.WriteLine(sw2.ElapsedMilliseconds);
	}
}