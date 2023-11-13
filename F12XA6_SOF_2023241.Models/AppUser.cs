using Microsoft.AspNetCore.Identity;

namespace F12XA6_SOF_2023241.Webapp.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContentType { get; set; }

        public byte[] Data { get; set; }
    }
}
