using System.ComponentModel.DataAnnotations.Schema;

namespace Mozaika.Data.Models.Core
{
    [Table("Tiles")]
    public class TextTile : Tile
    {
        public string Text { get; set; }
    }
}
