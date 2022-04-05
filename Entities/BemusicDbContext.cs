using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bemusic.Entities
{
    public class BeMusicDbContext : DbContext
    {
        public BeMusicDbContext(DbContextOptions<BeMusicDbContext> options) : base(options)
        {
            
        }
      public DbSet<Album> Albums { get; set; }
      public DbSet<Supplier> Suppliers { get; set; }
      public DbSet<Track> Tracks { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<Role> Roles { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
      }

    }
}
