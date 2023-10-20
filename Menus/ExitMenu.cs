using BandNamespace.Models;

namespace BandNamespace.Menu;

internal class ExitMenu : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        Console.WriteLine("Goodbye :)");
    }
}
