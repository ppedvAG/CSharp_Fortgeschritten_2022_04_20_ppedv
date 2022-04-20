using BuilderPatternFluent.RegularBuilder;

namespace BuilderPatternFluent;

public class Program
{
	public static void Main(string[] args)
	{
		List<Product> products = new List<Product>()
		{
			new Product() { Name = "Monitor", Price = 200 },
			new Product() { Name = "Mouse", Price = 20},
			new Product() { Name = "Keyboard", Price = 50}
		};

		ProductStockReportBuilder builder = new ProductStockReportBuilder(products);
		ReportDirector director = new ReportDirector(builder);
		ProductReport report = director.BuildReport();
		Console.WriteLine(report.ToString());



		List<Product> productsFB = new List<Product>()
		{
			new Product() { Name = "Monitor", Price = 200 },
			new Product() { Name = "Mouse", Price = 20},
			new Product() { Name = "Keyboard", Price = 50}
		};

		ProductStockReportBuilder builderFB = new ProductStockReportBuilder(productsFB);
		ReportDirector directorFB = new ReportDirector(builderFB);
		ProductReport reportFB = directorFB.BuildReport();
		Console.WriteLine(reportFB.ToString());
	}
}