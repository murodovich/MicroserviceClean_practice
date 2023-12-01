using Microsoft.EntityFrameworkCore;
using NajotNur.Domain.Entities.Models;

namespace NajotNur.Application.Data
{
    public class NajotNurDBContext : DbContext
    {
        public NajotNurDBContext(DbContextOptions<NajotNurDBContext> options) : base(options)
        {
            Database.Migrate();
            
        }
         
        public DbSet<User> users { get; set; }

     }
}
