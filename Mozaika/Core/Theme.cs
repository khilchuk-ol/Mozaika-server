using System.ComponentModel.DataAnnotations;

namespace Mozaika.Data.Models.Core
{
    public class Theme
    {
        public int Id { get; set; }

        [Required]
        public string WebClientName { get; set; }
    }
}
