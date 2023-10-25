using BandNamespace.Menus2;
namespace BandNamespace.Menus2
{
    internal class ShowFavoritesMenu : Menu2
    {
        public override void Execute(List<Menu2> musics, List<Menu2> FavoriteMusics)
        {
            Console.Clear();
            Console.WriteLine("Favorite musics:");
            if (FavoriteMusics.Count == 0)
            {
                Console.WriteLine("Before checking your favorite musics, you must add one");
            }
            else
            {
                foreach (Menu2 music in FavoriteMusics)
                {
                    Console.WriteLine(music.Name);
                }
            }
        }

    }
}
