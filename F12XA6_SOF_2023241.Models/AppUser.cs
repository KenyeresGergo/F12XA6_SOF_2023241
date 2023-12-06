using F12XA6_SOF_2023241.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F12XA6_SOF_2023241.Models
{
    public class AppUser : IdentityUser, IAppUser
    {
        [StringLength(200)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(200)]
        [Required]
        public string LastName { get; set; }

        [NotMapped]
        public virtual ICollection<Game> GamesOwned { get; set; }

        [StringLength(200)]
        public string? PhotoContentType { get; set; }

        public byte[]? PhotoData { get; set; }

        public AppUser()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
