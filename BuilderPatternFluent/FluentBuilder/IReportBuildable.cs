namespace BuilderPatternFluent.FluentBuilder
{
	public interface IReportBuildable
	{
		IReportBuildable BuildHeader();

		IReportBuildable BuildBody();

		IReportBuildable BuildFooter();

		ProductReport GetReport();
	}
}
