public class Employee
{
	public int ID { get; set; }

	public string Name { get; set; }
}

public class BadReportGenerator
{
	public string ReportType { get; set; } = "PDF";

	public void GenerateReport(Employee emp)
	{
		switch(ReportType)
		{
			case "PDF":
				//Generate PDF
				break;
			case "List10":
				//Generate List10
				break;
		}
	}
}

//Abstrakte Klasse (Basisklasse)
public abstract class ReportGenerator
{
	public abstract void GenerateReport(Employee emp);
}

//Spezifizierungen
public class PDFGenerator : ReportGenerator
{
	public string FileName;

	public List<string> Fonts;

	public override void GenerateReport(Employee emp)
	{ 
		//Generate PDF
	}
}

public class List10Generator : ReportGenerator
{
	public object Vorlage;

	public override void GenerateReport(Employee emp)
	{
		//Generate List10
	}
}