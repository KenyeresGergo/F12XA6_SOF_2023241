using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Logic
{
    public class CommentLogic
    {
        private IRepository<Comment> repository;
        public CommentLogic(IRepository<Comment> repository)
        {
            this.repository = repository;
        }



    }
}
