using Mozaika.Data.Models.Associative;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mozaika.Data.Models.Core
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3)]
        public string Username { get; set; }
        [Required]
        [RegularExpression("/^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,10}$/")]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string ProfilePicFileName { get; set; }

        public List<UserSocialMedia> UserSocialMedias { get; set; }
        public List<Mosaic> Mosaics { get; set; }
        public List<Tile> Tiles { get; set; }
    }
}
