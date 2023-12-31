﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F12XA6_SOF_2023241.Webapp.Models
{
    public class Game
    {
        [Key]
        public string Id { get;  private set; }
        [StringLength(200)]
        [Required]
        public string Title { get; set; }
        [StringLength(2000)]
        [Required]
        public string Description { get; set; }

        public int Rating { get; set; }

        public string? OwnerId { get; set; }

        [NotMapped]
        public virtual AppUser? Owner { get; set; }

        public string? ContentType { get; set; }

        public byte[]? PhotoData { get; set; }

        public Game()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
