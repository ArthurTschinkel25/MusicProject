using BandNamespace.Models;

namespace BandNamespace.Menu
{
    internal class Menu
    {
        public void DisplayOptionTitle(string title)
        {
            int letterCount = title.Length;
            string asterisks = string.Empty.PadLeft(letterCount, '*');
            Console.WriteLine(asterisks);
            Console.WriteLine(title);
            Console.WriteLine(asterisks + "\n");
        }

        public virtual void Execute(Dictionary<string, Band> RegisteredBands)
        {
           Console.Clear();
        }
    }
}
