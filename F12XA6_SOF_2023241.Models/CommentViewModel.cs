using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Models
{
    public class CommentViewModel
    {
        public Game Game { get; set; }

        public List<Comment> Comments { get; set;}
        public AppUser CommentOwner { get; set; }
        public CommentViewModel()
        {
            Comments = new List<Comment>();
        }
        public CommentViewModel(Game game)
        {
            this.Game = game;
            Comments = new List<Comment>();
        }

        public CommentViewModel(Game game, List<Comment> comments)
        {
            Game = game;
            Comments = comments;
        }
    }
}
