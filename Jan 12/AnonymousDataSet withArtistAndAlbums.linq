<Query Kind="Statements">
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

Artists
	.Where(a => a.ArtistId < 6)
	.OrderBy(a => a.ArtistId)
	.Select(x => x).Dump();

Albums
.Where(a => a.AlbumId < 6)
.Select(x => new
{
	Album = x.Title,
	Label = x.ReleaseLabel,
	Year = x.ReleaseYear,
	Artist=x.Artist  // Using the navigational proerty to get the artist name
})
.OrderBy(x => x.Album)
.Dump();