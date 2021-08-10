using Mozaika.Data.Models.Core;

namespace Mozaika.Data.Models.Associative
{
    public class TileTag
    {
        public int Id { get; set; }

        public int TileId { get; set; }
        public Tile Tile { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
