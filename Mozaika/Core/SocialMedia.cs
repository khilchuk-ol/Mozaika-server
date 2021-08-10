using System.ComponentModel.DataAnnotations;

namespace Mozaika.Data.Models.Core
{
    public class SocialMedia
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string IconFileName { get; set; }
    }
}
