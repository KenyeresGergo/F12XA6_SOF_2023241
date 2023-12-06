using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using F12XA6_SOF_2023241.Models.Interfaces;

namespace F12XA6_SOF_2023241.Models
{
    public class Game :  IDbEntity, IGame
    {
        [Key]
        public string Id { get;  set; }

        [StringLength(200)]
        [Required]
        public string Title { get; set; }

        [StringLength(2000)]
        [Required]
        public string Description { get; set; }

        [DefaultValue(0)]
        [Range(0, 10)]
        public int Rating { get; set; }

        [StringLength(200)]
        public string? PhotoContentType { get; set; }

        public byte[]? PhotoData { get; set; }

        public string StudiosId { get; set; }

        [ForeignKey("StudiosId")]
        public Studios Studios { get; set; }

        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public AppUser Owner { get; set; }

        public Game()
        {
            Id = Guid.NewGuid().ToString();
        }
        public void CopyFrom(Game old)
        {
            this.Description = old.Description;
            this.Rating = old.Rating;
            this.PhotoData = old.PhotoData;
            this.StudiosId = old.StudiosId;
            this.OwnerId = old.OwnerId;
            this.Title = old.Title;
        }
    }
}
