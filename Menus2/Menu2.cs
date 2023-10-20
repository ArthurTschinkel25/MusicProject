using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BandNamespace.Menus2
{
    internal class Menu2
    {
        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("song")]
        public string? Name { get; set; }

        [JsonPropertyName("genre")]
        public string? Genre { get; set; }

        [JsonPropertyName("year")]
        public string? Year { get; set; }

        public virtual void Execute(List<Menu2> musics, List<Menu2> FavoriteMusics)
        {
  
        }
    }
}
