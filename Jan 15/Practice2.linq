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
	.Where(c => c.Geography.StateProvinceName == "British Columbia" 
				&& c.Geography.RegionCountryName == "Canada")
				.Select(c => new
				{
					First = c.FirstName,
					Last = c.LastName,
					City = c.Geography.CityName
				})
				.OrderBy(c => c.City)
				.ThenBy(c => c.Last)
				.ToList()
	.Dump();
	