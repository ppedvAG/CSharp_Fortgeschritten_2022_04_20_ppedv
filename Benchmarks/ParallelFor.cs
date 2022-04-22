using System.Diagnostics;

namespace Benchmarks
{
	public class ParallelFor
	{
		static void Main(string[] args)
		{
			int[] durchgänge = { 1_000, 10_000, 50_000, 100_000, 250_000, 500_000, 1_000_000, 5_000_000, 10_000_000, 100_000_000 };
			for (int i = 0; i < durchgänge.Length; i++)
			{
				Stopwatch sw = new Stopwatch();
				sw.Start();
				RegularFor(durchgänge[i]);
				sw.Stop();
				Console.WriteLine($"For {durchgänge[i]}: {sw.ElapsedMilliseconds}");

				Stopwatch sw2 = new Stopwatch();
				sw2.Start();
				ParallelForMethod(durchgänge[i]);
				sw2.Stop();
				Console.WriteLine($"Parallel For {durchgänge[i]}: {sw2.ElapsedMilliseconds}");
			}

			/*
				For 1000: 0
				Parallel For 1000: 42
				For 10000: 2
				Parallel For 10000: 46
				For 50000: 6
				Parallel For 50000: 16
				For 100000: 26
				Parallel For 100000: 17
				For 250000: 50
				Parallel For 250000: 62
			Ab hier schneller
				For 500000: 66
				Parallel For 500000: 33
				For 1000000: 204
				Parallel For 1000000: 83
				For 5000000: 1095
				Parallel For 5000000: 356
				For 10000000: 1387
				Parallel For 10000000: 282
				For 100000000: 12586
				Parallel For 100000000: 3170
			*/
		}

		public static void RegularFor(int iterations)
		{
			double[] erg = new double[iterations];
			for (int i = 0; i < iterations; i++)
			{
				erg[i] = (Math.Pow(i, 0.333333333333) * Math.Sin(i + 2) / Math.Exp(i) + Math.Log(i + 1)) * Math.Sqrt(i + 100);
			}
		}

		public static void ParallelForMethod(int iterations)
		{
			double[] erg = new double[iterations];
			Parallel.For(0, iterations, i =>
			{
				erg[i] = (Math.Pow(i, 0.333333333333) * Math.Sin(i + 2) / Math.Exp(i) + Math.Log(i + 1)) * Math.Sqrt(i + 100);
			});
		}
	}
}
