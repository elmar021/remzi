using All_Up.Models;
using Microsoft.EntityFrameworkCore;

namespace All_Up.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> optons) : base (optons) 
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
