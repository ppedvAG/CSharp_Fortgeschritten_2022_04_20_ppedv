namespace BuilderPatternFluent.FluentBuilder
{
	public class ReportDirector
	{
		private IReportBuilder report;

		public ReportDirector(IReportBuilder report)
		{
			this.report = report;
		}

		public ProductReport BuildReport()
		{
			report.BuildHeader().BuildBody().BuildFooter();
			return report.GetReport();
		}
	}
}
