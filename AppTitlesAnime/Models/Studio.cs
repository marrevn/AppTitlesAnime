using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTitlesAnime.Models
{
    public class Studio
    {
        public int id { get; set; }

        [Column("studio_name")] 
        public string StudioName { get; set; }

        public virtual ICollection<AnimeTitle> AnimeTitles { get; set; }
    }
}