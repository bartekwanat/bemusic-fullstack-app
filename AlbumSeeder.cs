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


        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>
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

        private IEnumerable<Album> GetAlbums()
        {
            var albums = new List<Album>()
            {
                new Album()
                {
                    ArtistName = "Eminem",
                    Title = "Encore",
                    Version = "MP3",
                    ReleaseYear = 2004,
                    SupplierId = 1,


                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 1",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 2",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 3",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 4",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 5",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 6",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 7",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 8",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 9",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 10",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 11",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 12",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 13",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 14",
                            ReleaseYear = 2004,
                            Duration = 98
                        },
                        new Track()
                        {
                            ArtistName = "Eminem",
                            Title = "Track 15",
                            ReleaseYear = 2004,
                            Duration = 98
                        }
                    }
                },
                new Album()
                {
                    ArtistName = "50Cent",
                    Title = "Bulletproof",
                    Version = "MP3",
                    ReleaseYear = 2007,
                    SupplierId = 1,

                    Tracks = new List<Track>
                    {
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 1",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 2",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 3",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 4",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 5",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 6",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 7",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 8",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 9",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 10",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 11",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 12",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 13",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 14",
                            ReleaseYear = 2007,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "50 Cent",
                            Title = "Track 15",
                            ReleaseYear = 2007,
                            Duration = 100
                        }
                    }
                },
                new Album()
                {
                    ArtistName = "AC/DC",
                    Title = "Highway to Hell",
                    Version = "MP3",
                    ReleaseYear = 1979,
                    SupplierId = 1,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "AC/DC",
                            Title = "Track",
                            ReleaseYear = 1979,
                            Duration = 100
                        },
                    }
                },

                new Album()
                {
                    ArtistName = "Artist Name",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 1,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },

                new Album()
                {
                    ArtistName = "Artist Name",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 1,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },

                new Album()
                {
                    ArtistName = "Artist Name",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 1,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },

                new Album()
                {
                    ArtistName = "Artist Name",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 1,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },

                new Album()
                {
                    ArtistName = "Artist Name",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 1,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },

                /*new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },
                new Album()
                {
                    ArtistName = "Artist 2",
                    Title = "Album Title",
                    Version = "MP3",
                    ReleaseYear = 2000,
                    SupplierId = 2,

                    Tracks = new List<Track>()
                    {
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                        new Track()
                        {
                            ArtistName = "Artist Name",
                            Title = "Track",
                            ReleaseYear = 2000,
                            Duration = 100
                        },
                    }
                },*/
            };
            return albums;
        }
    }
}