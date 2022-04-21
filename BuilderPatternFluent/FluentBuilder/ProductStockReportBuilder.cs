namespace BuilderPatternFluent.FluentBuilder
{
	public class ProductStockReportBuilder : IReportBuildable
	{
		private ProductReport productReport;
		private	List<Product> products;

		public ProductStockReportBuilder(List<Product> products)
		{
			productReport = new ProductReport();
			this.products = products;
		}

		public IReportBuildable BuildHeader()
		{
			productReport.Header = "Stock Report";
			return this;
		}

		public IReportBuildable BuildBody()
		{
			productReport.Body = products.Aggregate("", (agg, product) => agg + $"Name: {product.Name}, Price: {product.Price}\n");
			return this;
		}

		public IReportBuildable BuildFooter()
		{
			productReport.Footer = "Report End";
			return this;
		}

		public ProductReport GetReport()
		{
			return productReport;
		}
	}
}
