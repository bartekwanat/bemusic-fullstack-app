using System.Collections.Generic;
using System.Linq;
using bemusic.Entities;

namespace bemusic
{
    public class AlbumSeeder
    {
        private readonly BeMusicDbContext _dbContext;

        public AlbumSeeder(BeMusicDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Roles.Any())
                {
                    var roles = GetRoles();
                    _dbContext.Roles.AddRange(roles);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Suppliers.Any())
                {
                    var supplier = GetSupplier();
                    _dbContext.Suppliers.AddRange(supplier);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Albums.Any())
                {
                    var albums = GetAlbums();
                    _dbContext.Albums.AddRange(albums);
                    _dbContext.SaveChanges();
                }
            }
        }

        private static IEnumerable<Supplier> GetSupplier()
        {
            var supplier = new List<Supplier>()
            {
                new Supplier()
                {
                    Name = "ACompany"
                },

                new Supplier()
                {
                    Name = "BCompany"
                }
            };
            return supplier;
        }

        private static IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Name = "User"
                },
                new Role()
                {
                    Name = "Admin"
                }
            };
            return roles;
        }

        private static IEnumerable<Album> GetAlbums()
        {
            var albums = new List<Album>()
            {
                new Album()
                {
                    ArtistName = "Em",
                    Title = "Encore",
                    Version = "MP3",
                    ReleaseYear = 2004,
                    SupplierId = 1,


                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Curtains Up",
                            ReleaseYear = 2004,
                            Duration = 98
                        }
                    }
                },
                new Album()
                {
                    ArtistName = "50Cent",
                    Title = "Encore",
                    Version = "MP3",
                    ReleaseYear = 2004,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "50",
                            Title = "PIMP",
                            ReleaseYear = 2004,
                            Duration = 90
                        }
                    }
                }
            };

            return albums;
        }
    }
}