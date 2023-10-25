using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNamespace.Menus2
{
    internal class FavoritesMenu : Menu2
    {
        public override void Execute(List<Menu2> musics, List<Menu2> FavoriteMusics)
        {
            Console.Clear();
            Console.WriteLine("Which music do you want to add to favorites?");
            string? name = Console.ReadLine().ToLower();
            Menu2 favoritemusic = musics.FirstOrDefault(music => music.Name.ToLower() == name.ToLower());
            if (favoritemusic != null)
            {
                FavoriteMusics.Add(favoritemusic);
                Console.WriteLine($"The music {favoritemusic.Name} has been added to favorites.");
            }
            else
            {
                Console.WriteLine($"The music {name} does not exist or was not typed correctly.");
            }
        }

    }
}