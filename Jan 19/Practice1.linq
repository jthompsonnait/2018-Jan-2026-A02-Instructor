<Query Kind="Program">
  <Connection>
    <ID>e911c88b-78d8-48b8-9b71-c4628c7c6afb</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Contoso</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

void Main()
{
	string lastName = "Al";
	int baseRate = 30;
	GetEmployeeReview(lastName, baseRate).Dump();
}

public List<EmployeeView> GetEmployeeReview(string lastName, int baseRate)
{
	return Employees
		.Where(e => e.LastName.ToLower().Contains(lastName.ToLower()))
		.OrderBy(e => e.LastName)
		.Select(e => new EmployeeView
		{
			FullName = e.FirstName + " " + e.LastName, // $"{e.FirstName} {e.LastName}",
		Department = e.DepartmentName,
		IncomeCategory = e.BaseRate < baseRate ? "Review Required"
									: "No Review Required"
		}).ToList();
}

public class EmployeeView
{
	public string FullName { get; set; }
	public string Department { get; set; }
	public string IncomeCategory { get; set; }
}
