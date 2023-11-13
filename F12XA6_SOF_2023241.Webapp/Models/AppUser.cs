﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace F12XA6_SOF_2023241.Webapp.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(200)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(200)]
        [Required]
        public string LastName { get; set; }
        [StringLength(200)]
        public string PhotoContentType { get; set; }

        public byte[] Data { get; set; }
    }
}
