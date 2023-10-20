using BandNamespace.Models;

namespace BandNamespace.Menu;

internal class ShowBandsMenu : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        DisplayOptionTitle("Displaying all the Bands registered in our application");

        foreach (string band in RegisteredBands.Keys)
        {
            Console.WriteLine($"Band: {band}");
        }

        Console.WriteLine("\nPress any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
    }
}
