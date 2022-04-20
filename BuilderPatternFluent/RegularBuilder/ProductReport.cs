using System.Text;

namespace BuilderPatternFluent.RegularBuilder
{
	public class ProductReport
	{
		public string Header { get; set; }

		public string Body { get; set; }

		public string Footer { get; set; }

		public override string ToString() => new StringBuilder().AppendLine(Header).AppendLine(Body).AppendLine(Footer).ToString();
	}
}
