using F12XA6_SOF_2023241.Models;
using Microsoft.EntityFrameworkCore;

namespace F12XA6_SOF_2023241.Repository
{
    public interface IAppDbContext
    {
        DbSet<Game> Games { get; set; }
        DbSet<AppUser> Users { get; set; }
    }
}