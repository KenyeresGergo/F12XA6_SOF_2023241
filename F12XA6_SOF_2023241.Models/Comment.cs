using Castle.Components.DictionaryAdapter;
using F12XA6_SOF_2023241.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Models
{
    public class Comment : IDbEntity, IComment
    {

        public string Id { get; set; }
        public string Content { get; set; }
        public int ReactionCounter { get; set; }
        public Game Game { get; set; }
        public AppUser User { get; set; }
        public Comment()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
