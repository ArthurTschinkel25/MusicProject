using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNamespace.Menus2
{
    internal class GenreMenu : Menu2
    {
        public override void Execute(List<Menu2> musics, List<Menu2> favorites)
        {
            Console.Clear();    
            Console.WriteLine("Enter the genre you want to see musics for");
            string? genre = Console.ReadLine();
            var musicsByMusicalGenre = musics
                .Where(music => music.Genre.ToLower().Contains(genre))
                .Select(music => music.Name)
                .Distinct()
                .ToList();

            foreach (var music in musicsByMusicalGenre)
            {
                Console.WriteLine($"-{music}");
            }
        }
    }
}
