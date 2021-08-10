using Mozaika.Data.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace Mozaika.Data.Models.Associative
{
    public class UserSocialMedia
    {
        public int Id { get; set; }

        [Required]
        [Url]
        public string URL { get; set; }

        public int SocialMediaId { get; set; }
        public SocialMedia SocailMedia { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
