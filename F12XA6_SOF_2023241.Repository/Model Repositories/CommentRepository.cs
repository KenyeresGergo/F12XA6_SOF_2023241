using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.DataBase;
using F12XA6_SOF_2023241.Repository.Generic_Repository;
using F12XA6_SOF_2023241.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Repository.Model_Repositories
{
    public class CommentRepository : Repository<Comment>, IRepository<Comment>
    {
        private readonly AppDbContext context;
        public CommentRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public override bool Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}
