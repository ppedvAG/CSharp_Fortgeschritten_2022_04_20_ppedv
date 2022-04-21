namespace BuilderPatternFluent.FluentBuilder
{
	public class ReportDirector
	{
		private IReportBuildable report;

		public ReportDirector(IReportBuildable report)
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
