using BandNamespace.Models;

namespace BandNamespace.Menu;

internal class RegisterBandMenu : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        DisplayOptionTitle("Band Registration");
        Console.Write("What is the name of the Band you want to register? ");
        string bandName = Console.ReadLine()!;
        Band band = new Band(bandName);
        RegisteredBands.Add(bandName, band);
        Console.WriteLine("RegisteredBands after registration:");
        foreach (var pair in RegisteredBands)
        {
            Console.WriteLine($"Band: {pair.Key}");
        }
        Console.WriteLine($"The Band {bandName} has been successfully registered!");
        Console.WriteLine("Press any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();    
    }
}
