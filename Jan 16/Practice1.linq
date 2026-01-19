<Query Kind="Statements">
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

Inventories
	.Where(i => i.SafetyStockQuantity < 31)
	.Select(i => new
	{
		StoreId = i.StoreID,
		StoreName = i.Store.StoreName,
		ProductName = i.Product.ProductName,
		OnHandQuantity = i.OnHandQuantity,
		OnOrderQuantity = i.OnOrderQuantity,
		SafetyStockQuantity = i.SafetyStockQuantity,
		ReOrder = i.OnHandQuantity + i.OnOrderQuantity
					< i.SafetyStockQuantity ? "Yes" : "No"
	})
	.OrderBy(i => i.StoreId)
	.ThenBy(i => i.ProductName)
	.ToList()
	.Dump();
	