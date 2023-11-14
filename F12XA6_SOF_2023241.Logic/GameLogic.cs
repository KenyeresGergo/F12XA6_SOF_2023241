﻿using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace F12XA6_SOF_2023241.Logic
{
    public class GameLogic
    {
        AppDbContext context;
        public GameLogic(AppDbContext context)
        {
            this.context = context;
        }

        public void Create(Game game)
        {
            var gameId = context.Games.FirstOrDefault(x => x.Id == game.Id);
            if (gameId != null)
            {
                throw new ArgumentException("Game with thos name already exists!");
            }
           context.Games.Add(game);
           context.SaveChanges();
        }
        public IEnumerable<Game> Read()
        {
            return this.context.Games;
        }
        public void Update()
        {   
        
        }
        public void Delete() 
        {
        
        }
    }
}