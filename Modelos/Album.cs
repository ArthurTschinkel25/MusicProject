namespace BandNamespace.Models;

internal class Album : IRatable
{
    private List<Music> musics = new List<Music>();
    private List<Rating> ratings = new List<Rating>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => Musics.Sum(s => s.Duration);
    public double AverageRating
    {
        get
        {
            if (ratings.Count == 0) return 0;
            else return ratings.Average(rating => rating.Score);
        }
    }
    public List<Music> Musics => musics;

    public void AddMusic(Music Music)
    {
        Musics.Add(Music);
    }

    public void AddRating(Rating rating)
    {
        ratings.Add(rating);
    }

    public void DisplayMusicsInAlbum()
    {
        Console.WriteLine($"List of Musics in the album {Name}:\n");
        foreach (var Music in Musics)
        {
            Console.WriteLine($"Music: {Music.Name}");
        }
        Console.WriteLine($"\nTo listen to the entire album, you need {TotalDuration}.");
    }
}
