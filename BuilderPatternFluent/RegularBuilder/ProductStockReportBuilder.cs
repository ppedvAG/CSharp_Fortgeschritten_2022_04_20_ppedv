namespace BuilderPatternFluent.RegularBuilder
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

		public void BuildHeader()
		{
			productReport.Header = "Stock Report";
		}

		public void BuildBody()
		{
			productReport.Body = products.Aggregate("", (agg, product) => agg + $"Name: {product.Name}, Price: {product.Price}\n");
		}

		public void BuildFooter()
		{
			productReport.Footer = "Report End";
		}

		public ProductReport GetReport()
		{
			return productReport;
		}
	}
}
