<Query Kind="Program">
  <Connection>
    <ID>a3db8247-b6f6-4189-8113-e14d9b40f7cd</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <UseMicrosoftDataSqlClient>true</UseMicrosoftDataSqlClient>
    <EncryptTraffic>true</EncryptTraffic>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Contoso</Database>
    <MapXmlToString>false</MapXmlToString>
    <DriverData>
      <SkipCertificateCheck>true</SkipCertificateCheck>
    </DriverData>
  </Connection>
</Query>

void Main()
{
	Invoices
	.OrderBy(i => i.Customer.LastName)
		.Select(i => new
		{
			InvoiceNo = i.InvoiceID,
			//InvoiceDate =  new DateOnly(int.Parse(i.SalesOrderNumber.Substring(0,4)),
			//					int.Parse(i.SalesOrderNumber.Substring(4,2)),
			//					int.Parse(i.SalesOrderNumber.Substring(6,2)))  //20210101211010	
			InvoiceDate = $"{i.SalesOrderNumber.Substring(0, 4)}/{i.SalesOrderNumber.Substring(4, 2)}/{i.SalesOrderNumber.Substring(6, 2)}",
			Name = i.Customer.FirstName + " " + i.Customer.LastName,
			StoreName = i.Store.StoreName,
			Manager = i.Store.Geography.CityName,
			//Priority = i.TotalAmount > 5000 ? "High Priority" : "Low Priority"
			Priority = GetPriority(i.TotalAmount)
		})
		//	example on post select (use the pre select)
		//.OrderBy(i => i.Name.Substring(i.Name.IndexOf(' ')+1))
		.ToList()
		.Dump();
}

public string GetPriority(decimal amount)
{
	if (amount > 5000)
		return "High Priority";
	else
		return "Low Priority";
}
