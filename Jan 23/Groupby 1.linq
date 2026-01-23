<Query Kind="Statements">
  <Connection>
    <ID>af9efb4e-acd2-4c19-b04d-92901e6e0f43</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <UseMicrosoftDataSqlClient>true</UseMicrosoftDataSqlClient>
    <EncryptTraffic>true</EncryptTraffic>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Chinook-2025</Database>
    <MapXmlToString>false</MapXmlToString>
    <DriverData>
      <SkipCertificateCheck>true</SkipCertificateCheck>
    </DriverData>
  </Connection>
</Query>

//Albums
//	.OrderBy(x => x.ReleaseYear)
//	.Select(x => x)
//	.ToList()
//	.Dump();
	
	Albums		
		.GroupBy(a => a.ReleaseYear)
		//  you may order by key
		.OrderByDescending(a => a.Key)
		.Select(a => a)
		.ToList()
		.Dump();