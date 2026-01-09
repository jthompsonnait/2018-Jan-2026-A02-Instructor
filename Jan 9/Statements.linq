<Query Kind="Statements">
  <Connection>
    <ID>b63f7e81-6c16-405f-8db4-1101382b395c</ID>
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

int paramYear = 2000;
var selectM = Albums
				.Where(a => a.ReleaseYear == paramYear)
				.Select(a => a);
foreach(var album in selectM)
{
	album.ReleaseYear = album.ReleaseYear + 1;
}				
selectM.Dump();

//Albums
//				.Where(a => a.ReleaseYear == paramYear)
//				.Select(a => a)
//				.Dump();