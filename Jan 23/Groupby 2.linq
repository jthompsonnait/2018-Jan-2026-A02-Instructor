<Query Kind="Statements">
  <Connection>
    <ID>17f0f6e0-07c2-4191-89cd-bceb147f3aee</ID>
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

//Products
//	.GroupBy(p => p.Category.CategoryID)
//	.Select(x => new
//	{
//		Categories = x.Key,
//		Products = x.ToList()
//	})
//	.ToList()
//	.Dump();

Products
.GroupBy(p => p.Category.CategoryID) // This is the key
.Select(x => new
{
	Categories = x.Key,
	Products = x.Select(p => new
	{
		ProductID = p.ProductID,
		ProductName = p.ProductName
	})
})
.ToList()
.Dump();