namespace BuilderPatternFluent.RegularBuilder
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
			report.BuildHeader();
			report.BuildBody();
			report.BuildFooter();
			return report.GetReport();
		}
	}
}
