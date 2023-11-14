using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Logic
{
    public class GameLogic
    {
        AppDbContext context;
        public GameLogic(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Game> Read()
        {
            return this.context.Games;
        }
        
    }
}
