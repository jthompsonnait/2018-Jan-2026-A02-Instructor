<Query Kind="Statements">
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

Products
	.Where(a => a.UnitPrice < 10)
	.Select(a => new
	{
		ProductLabel = a.ProductLabel,
		ProductName = a.ProductName,
		UnitPrice = a.UnitPrice.Value
	})
	.OrderBy(a => a.UnitPrice)
	.ToList()
	.Dump();
	
