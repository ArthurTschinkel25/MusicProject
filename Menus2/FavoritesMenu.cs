using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNamespace.Menus2
{
    internal class FavoritesMenu : Menu2
    {
        public string Name { get; set; }
        public override void Execute(List<Menu2> musics, List<Menu2> FavoriteMusics)
        {
            Console.Clear();
            Console.WriteLine("Which music do you want to add to favorites?");
            string? name = Console.ReadLine();
            Menu2 favoritemusic = musics.FirstOrDefault(music => music.Name.ToLower() == name.ToLower());
            if (favoritemusic != null)
            {
                FavoriteMusics.Add(favoritemusic);
                Console.WriteLine($"The music {name} has been added to favorites.");
                foreach (Menu2 music in FavoriteMusics)
                {
                    Console.WriteLine(music.Name);
                }
            }
            else
            {
                Console.WriteLine($"The music {name} does not exist or was not typed correctly.");
            }
        }

    }
}