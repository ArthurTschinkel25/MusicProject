namespace BandNamespace.Models;

internal class Band : IRatable
{
    private List<Album> albums = new List<Album>();
    private List<Rating> ratings = new List<Rating>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double AverageRating
    {
        get
        {
            if (ratings.Count == 0) return 0;
            else return ratings.Average(r => r.Score);
        }
    }
    public string? Summary { get; set; }
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(Rating rating)
    {
        ratings.Add(rating);
    }

    public void DisplayDiscography()
    {
        Console.WriteLine($"Discography of Band {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
        }
    }
}
