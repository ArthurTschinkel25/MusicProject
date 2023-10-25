namespace BandNamespace.Menus2
{
    internal class YearMenu : Menu2
    {
        public override void Execute(List<Menu2> musics, List<Menu2> favorites)
        {
            Console.Clear();
            Console.WriteLine("Which year's musics would you like to see? ");
            string? year = Console.ReadLine().ToLower();
            var filteredmusicsByYear = musics
                .Where(music => music.Year.ToLower().Equals(year))
                .Select(music => music.Name)
                .Distinct()
                .ToList();

            foreach (var music in filteredmusicsByYear)
            {
                Console.WriteLine($"-{music}");
            }
        }
    }
}
