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

Products
// This is the key using category ID
.GroupBy(p => p.Category.CategoryID)
//  group by CategoryName (Do Not Use This Method)
//.GroupBy(p => p.Category.CategoryName)
.Select(x => new
{
	//  group by CategoryName (Do Not Use This Method)
	//  Categories = x.Key,
	//	retreiving category name from CategoryID and x.key
	Categories = (Categories.Where(c => c.CategoryID == x.Key)
					.Select(c => c.CategoryName).FirstOrDefault()),
	Products = x.Select(p => new
	{
		ProductID = p.ProductID,
		ProductName = p.ProductName
	})
})
.ToList()
.Dump();