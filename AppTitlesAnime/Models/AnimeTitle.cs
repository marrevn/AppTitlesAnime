using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTitlesAnime.Models
{
    public partial class AnimeTitle
    {
        public int Id { get; set; }

        public short IdType { get; set; }

        public string OriginalName { get; set; } = null!;

        public string Name { get; set; } = null!;

        public short CountSeries { get; set; }

        public short Duration { get; set; }

        [Column("studio_id")]
        public int StudioId { get; set; }

        public virtual Studio Studio { get; set; }

        public string? Poster { get; set; }

        public string? Description { get; set; }

        public virtual Type Type { get; set; } = null!;

        public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
        public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
    }
}