using BandNamespace.Models;

namespace BandNamespace.Menu;

internal class RateBandMenu : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        DisplayOptionTitle("Rate Band");
        Console.Write("What's the name of the band you want to rate? ");
        string bandName = Console.ReadLine()!;
        if (RegisteredBands.ContainsKey(bandName))
        {
            Band band = RegisteredBands[bandName];
            Console.Write($"What rating does the band {bandName} deserve: ");
            Rating rating = Rating.Parse(Console.ReadLine()!);
            band.AddRating(rating);
            Console.WriteLine($"\nThe rating {rating.Score} has been successfully recorded for the band {bandName}");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nThe band {bandName} was not found!");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
