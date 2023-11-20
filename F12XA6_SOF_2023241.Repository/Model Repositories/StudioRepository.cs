using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.Interfaces;
using F12XA6_SOF_2023241.Repository.Generic_Repository;
using F12XA6_SOF_2023241.Repository.DataBase;

namespace F12XA6_SOF_2023241.Repository.Model_Repositories
{
    public class StudioRepository : Repository<Studios>, IRepository<Studios>
    {
        private readonly AppDbContext context;
        public StudioRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public override bool Update(Studios item)
        {
            var sourceItem = Read(item.Id);
            if (sourceItem == null)
            {
                return false;
            }

            sourceItem.CopyFrom(item);
            context.SaveChanges();
            return true;
        }
    }
}
