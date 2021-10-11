using Mozaika.Data.Models.Associative;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mozaika.Data.Models.Core
{
    [Table("Tiles")]
    public class Tile
    {
        public int Id { get; set; }

        public string OriginURL { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        public List<TileTag> TileTags { get; set; }
    }
}
