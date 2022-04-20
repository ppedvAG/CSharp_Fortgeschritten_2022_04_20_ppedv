namespace BuilderPatternFluent.FluentBuilder
{
	public class ProductStockReportBuilder : IReportBuilder
	{
		private ProductReport productReport;
		private	List<Product> products;

		public ProductStockReportBuilder(List<Product> products)
		{
			productReport = new ProductReport();
			this.products = products;
		}

		public IReportBuilder BuildHeader()
		{
			productReport.Header = "Stock Report";
			return this;
		}

		public IReportBuilder BuildBody()
		{
			productReport.Body = products.Aggregate("", (agg, product) => agg + $"Name: {product.Name}, Price: {product.Price}\n");
			return this;
		}

		public IReportBuilder BuildFooter()
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
