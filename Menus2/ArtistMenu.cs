using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BandNamespace.Menus2
{
    internal class ArtistMenu : Menu2
    {
        public override void Execute(List<Menu2> musics, List<Menu2> FavoriteMusics)
        {
            Console.Clear();
            Console.WriteLine("Which artist's musics would you like to see? ");
            string chosenArtist = Console.ReadLine().ToLower();
            var artistmusics = musics
            .Where(music => music.Artist.ToLower().Contains(chosenArtist))
            .Select(music => music.Name)
            .Distinct()
            .ToList();


            foreach (var music in artistmusics)
            {
                Console.WriteLine($"-{music}");
            }
            
        }
    }
}