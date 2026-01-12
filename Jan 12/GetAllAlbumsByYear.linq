<Query Kind="Program">
  <Connection>
    <ID>e0a87a77-277f-494c-93a7-51c2205344d2</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Chinook-2025</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

void Main()
{
	//  call to our method
	GetAllAlbumsByYear(2000).Dump();
}

//	image this is the method in our BLL
public List<Album> GetAllAlbumsByYear(int year)
{
	return Albums
			.Where(a => a.ReleaseYear == year)
			.ToList();
}

