using System.ComponentModel.DataAnnotations.Schema;

namespace Mozaika.Data.Models.Core
{
    [Table("Tiles")]
    public class BasicTile : Tile
    {
        public string PhotoFileName { get; set; }
    }
}
