using Mozaika.Data.Models.Core;

namespace Mozaika.Data.Models.Associative
{
    public class TileMosaic
    {
        public int Id { get; set; }

        public int TileId { get; set; }
        public Tile Tile { get; set; }

        public int MosaicId { get; set; }
        public Mosaic Mosaic { get; set; }
    }
}
