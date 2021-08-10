using System.ComponentModel.DataAnnotations;

namespace Mozaika.Data.Models.Core
{
    public class Tag
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
