namespace BuilderPatternFluent.RegularBuilder
{
	public interface IReportBuilder
	{
		void BuildHeader();

		void BuildBody();

		void BuildFooter();

		ProductReport GetReport();
	}
}
