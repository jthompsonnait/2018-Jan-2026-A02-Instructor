<Query Kind="Statements">
  <Connection>
    <ID>6d895f10-acd3-445f-a90a-a90999d7f419</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <UseMicrosoftDataSqlClient>true</UseMicrosoftDataSqlClient>
    <EncryptTraffic>true</EncryptTraffic>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>WestWind-2024</Database>
    <MapXmlToString>false</MapXmlToString>
    <DriverData>
      <SkipCertificateCheck>true</SkipCertificateCheck>
    </DriverData>
  </Connection>
</Query>

//	(Company Name, Country & Fax). 
//	If the fax is empty (null) or blank, 
//	replace the “null” or blank value with “Unknown.”

Customers
	.Select(c => new
	{
		Name = c.CompanyName,
		Country = c.Country,
		Fax = c.Fax== "" || c.Fax == null ? "Unknown" : c.Fax,
		Fax1 = c.Fax
	})
.		OrderBy(c => c.Fax)
	.ToList()
	.Dump();