public class BadEmployee
{
	public int ID { get; set; }
	public string Name { get; set; }

	public double GehaltBerechnen()
	{
		return 0;
	}

	public void GenerateReport()
	{
		//PDF Generieren mit ID, Name, GehaltBerechnen()
	}

	public void InsertEmployee()
	{
		//Insert this
	}
}

//Reduziert auf Model
public class Employee
{
	public int ID { get; set; }

	public string Name { get; set; }

	public double GehaltBerechnen()
	{
		return 0;
	}
}

//Datenbankinteraktion
public class EmployeeRepository
{
	public Employee GetEmployeeByID(int id)
	{
		//Select Employee mit ID
		return null;
	}

	public void InsertEmployee(Employee emp)
	{
		//Insert emp
	}
}

public class ReportGenerator
{
	public void GeneratePDF(Employee emp)
	{
		//PDF Generieren mit ID, Name, GehaltBerechnen() aus emp
	}

	public void GenerateOther(Employee emp)
	{
		//Other Generieren
	}
}