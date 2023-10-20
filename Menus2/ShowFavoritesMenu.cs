using BandNamespace.Menus2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNamespace.Menus2
{
    internal class ShowFavoritesMenu : Menu2
    {
       public override void Execute(List<Menu2> musics, List<Menu2> favorites)
        {
            Console.Clear();   
            foreach (var music in favorites) 
            {
                Console.WriteLine(music);
            }
        }
    }
}
