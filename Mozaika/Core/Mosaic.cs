using Mozaika.Data.Models.Associative;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mozaika.Data.Models.Core
{
    public class Mosaic
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string CoverPhotoFileName { get; set; }
        public bool IsPrivate { get; set; }

        public int ThemeId { get; set; }
        [ForeignKey(nameof(ThemeId))]
        public Theme Theme { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        public List<TileMosaic> TileMosaics { get; set; }
    }
}
