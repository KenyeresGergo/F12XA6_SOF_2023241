using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using F12XA6_SOF_2023241.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;

namespace F12XA6_SOF_2023241.Models
{
    [Table("Games")]
    public class Game :  IDbEntity, IGame
    {
        [Key]
        public string Id { get;  set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Content is required.")]
        public string Title { get; set; }

        [StringLength(2000)]
        [Required(ErrorMessage = "Content is required.")]
        public string Description { get; set; }

        [DefaultValue(0)]
        [Range(0, 10)]
        public int Rating { get; set; }

        [StringLength(200)]
        public string? PhotoContentType { get; set; }

        public byte[]? PhotoData { get; set; }

        public string StudiosId { get; set; }
        [JsonIgnore]
        [NotMapped]
        [ValidateNever]
        public IFormFile PhotoFile { get; set; }

        [ForeignKey("StudiosId")]
        [JsonIgnore]
        [NotMapped]
        [ValidateNever]
        public Studios Studios { get; set; }

        public string OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        [JsonIgnore]
        [NotMapped]
        [ValidateNever]
        public AppUser Owner { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

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
