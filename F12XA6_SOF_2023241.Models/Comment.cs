using Castle.Components.DictionaryAdapter;
using F12XA6_SOF_2023241.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Models
{
    public class Comment : IDbEntity, IComment
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Id { get; set; }
        public string Content { get; set; }
        public int ReactionCounter { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string GameId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }
        public string OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public AppUser Owner { get; set; }
        public Comment()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
