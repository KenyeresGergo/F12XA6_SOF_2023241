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

    public class Comment : IComment
    {

        public string Id { get; set; }
        public string Content { get; set; }
        public int ReactionCounter { get; set; }
        public DateTime CreatedOn { get; set; }
        public string GameId { get; set; }
        [NotMapped]
        public AppUser Owner { get; set; }

        public Comment(string content, int reactionCounter, DateTime createdOn, string gameId, AppUser owner)
        {
            Id = Guid.NewGuid().ToString();
            Content = content;
            ReactionCounter = reactionCounter;
            CreatedOn = createdOn;
            GameId = gameId;
            Owner = owner;
        }
        public Comment()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
