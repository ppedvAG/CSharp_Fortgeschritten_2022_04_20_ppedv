namespace BuilderPatternFluent.FluentBuilder
{
	public interface IReportBuilder
	{
		IReportBuilder BuildHeader();

		IReportBuilder BuildBody();

		IReportBuilder BuildFooter();

		ProductReport GetReport();
	}
}
