using BandNamespace.Models;
namespace BandNamespace.Menu;

internal class ShowDetailsMenu : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        DisplayOptionTitle("Show Band Details");
        Console.Write("Which Band would you like to know more about? ");
        string bandName = Console.ReadLine()!;
        if (RegisteredBands.ContainsKey(bandName))
        {
            Band band = RegisteredBands[bandName];
            Console.WriteLine(band.Summary);
            Console.WriteLine($"\nThe average rating for the Band {bandName} is {band.AverageRating}.");
            Console.WriteLine("\nDiscography:");
            foreach (Album album in band.Albums)
            {
                Console.WriteLine($"{album.Name} -> {album.AverageRating}");
            }
            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
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
