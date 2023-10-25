using BandNamespace.Models;

namespace BandNamespace.Menu;

internal class RateAlbumMenu : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);

        DisplayOptionTitle("Rate Album");
        Console.Write("Which Band would you like to rate? ");
        string bandName = Console.ReadLine()!;
        if (RegisteredBands.ContainsKey(bandName))
        {
            Band band = RegisteredBands[bandName];

            Console.Write("Now, enter the album title: ");
            string albumTitle = Console.ReadLine()!;

            if (band.Albums.Any(a => a.Name.Equals(albumTitle)))
            {
                Album album = band.Albums.First(a => a.Name.Equals(albumTitle));
                Console.Write($"What rating does the album {albumTitle} deserve: ");
                Rating rating = Rating.Parse(Console.ReadLine()!);
                album.AddRating(rating);
                Console.WriteLine($"\nThe rating {rating.Score} has been successfully recorded for the album {albumTitle}");
                Console.WriteLine("Press any key to return to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nThe album {albumTitle} was not found!");
                Console.WriteLine("Press any key to return to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nThe Band {bandName} was not found!");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
