using BandNamespace.Models;

namespace BandNamespace.Menu;

internal class RegisterAlbumMenu : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        DisplayOptionTitle("Album Registration");
        Console.Write("Which Band would you like to register an album for? ");
        string bandName = Console.ReadLine()!;
        if (RegisteredBands.ContainsKey(bandName))
        {
            Console.Write("Now, give a title for the album: ");
            string albumTitle = Console.ReadLine()!;
            Band band = RegisteredBands[bandName];
            band.AddAlbum(new Album(albumTitle));
            Console.WriteLine($"The album {albumTitle} by {bandName} has been successfully registered!");
            Thread.Sleep(4000);
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
