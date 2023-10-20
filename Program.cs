using BandNamespace.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using BandNamespace.Menu;
using BandNamespace.Menus2;

class Program
{
    private static Dictionary<string, Band> RegisteredBands = new Dictionary<string, Band>();
    static async Task Main(string[] args)
    {
        List<Menu2> musics = null;
        List<Menu2> FavoriteMusics = new List<Menu2>();


        using (HttpClient client = new HttpClient())
        {
            string apiMusica = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
            musics = JsonSerializer.Deserialize<List<Menu2>>(apiMusica);
        }

        void DisplayLogo()
        {
            Console.WriteLine("Welcome to my music program!");
            Console.WriteLine();
            Console.WriteLine("Press 1 to view the existing Musics in this program");
            Console.WriteLine("Press 2 to add musics you like to the program");
            string selectedOption = Console.ReadLine();
            switch (selectedOption)
            {
                case "1":
                    DisplayExistingMusicOptions();
                    break;
                case "2":
                    DisplayCreationMenuOptions();
                    break;
        
            }
        }

        DisplayLogo();

        void DisplayExistingMusicOptions()
        {
            Dictionary<int, Menu2> menuOptions2 = new();
            Console.Clear();
            Console.WriteLine("Press 1 to filter musics by an artist of your choice");
            Console.WriteLine("Press 2 to filter by musical genre");
            Console.WriteLine("Press 3 to see the releases in a specific year");
            Console.WriteLine("Press 4 to add a music to your favorites");
            Console.WriteLine("Press 5 to see all your favorite musics");
            string selectedOption = Console.ReadLine()!;
            int selectedOptionNumeric = int.Parse(selectedOption);
            menuOptions2.Add(1, new ArtistMenu());
            menuOptions2.Add(2, new GenreMenu());
            menuOptions2.Add(3, new YearMenu());
            menuOptions2.Add(4, new FavoritesMenu());
            menuOptions2.Add(5, new ShowFavoritesMenu());
            if (menuOptions2.ContainsKey(selectedOptionNumeric))
            {
                Menu2 menu = menuOptions2[selectedOptionNumeric];
                menu.Execute(musics, FavoriteMusics);
                Console.WriteLine("Press any key to return to the main menu");
                Console.ReadKey();  
                Console.Clear();
                DisplayLogo();
            }
            else
            {
                Console.WriteLine("Please choose an existing option");
            }
        }
        void DisplayCreationMenuOptions()
        {
            
            Dictionary<int, Menu> menuOptions = new();
            Console.Clear();
            menuOptions.Add(1, new RegisterBandMenu());
            menuOptions.Add(2, new RegisterAlbumMenu());
            menuOptions.Add(3, new ShowBandsMenu());
            menuOptions.Add(4, new RateBandMenu());
            menuOptions.Add(5, new RateAlbumMenu());
            menuOptions.Add(6, new ShowDetailsMenu());
            menuOptions.Add(-1, new ExitMenu());
            Console.WriteLine("\nEnter 1 to register a Band");
            Console.WriteLine("Enter 2 to register an album for a Band");
            Console.WriteLine("Enter 3 to show all Bands");
            Console.WriteLine("Enter 4 to rate a Band");
            Console.WriteLine("Enter 5 to rate an album");
            Console.WriteLine("Enter 6 to display details of a Band");
            Console.WriteLine("Enter -1 to exit");

            Console.Write("\nEnter your option: ");
            string selectedOption = Console.ReadLine()!;
            int selectedOptionNumeric = int.Parse(selectedOption);
            if (menuOptions.ContainsKey(selectedOptionNumeric))
            {
                Menu menu = menuOptions[selectedOptionNumeric];
                menu.Execute(RegisteredBands);
                if (selectedOptionNumeric > 0) DisplayCreationMenuOptions();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            Console.Clear();   
        }
    }
}