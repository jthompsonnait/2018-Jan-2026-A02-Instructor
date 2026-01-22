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

Customers
	.Where(c => c.TotalChildren > 2)
	.Sum(c => c.TotalChildren).Dump();

Products
	.Select(p => new
	{
		Name = p.ProductName,
		TotalOnHand = p.Inventories.Sum(i => i.OnHandQuantity) == null
						? 0 : p.Inventories.Sum(i => i.OnHandQuantity)
	})
	.OrderBy(p => p.Name)
	.ToList()
	.Dump();
