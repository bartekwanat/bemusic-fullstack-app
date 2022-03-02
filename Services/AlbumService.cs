using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using bemusic.Entities;
using bemusic.Models;
using Microsoft.EntityFrameworkCore;

namespace bemusic.Services
{

    public interface IAlbumService
    {
        IEnumerable<AlbumDto> GetAll(string searchPhrase);
        AlbumDto GetById(int id);
        int Create(CreateAlbumDto dto);
        void Update(int id, UpdateAlbumtDto dto);
    }

    public class AlbumService : IAlbumService
    {
        private readonly Entities.BeMusicDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IUserContextService _userContextService;

        public AlbumService(Entities.BeMusicDbContext dbContext, IMapper mapper, IUserContextService userContextService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userContextService = userContextService;
        }


        //GET
        public IEnumerable<AlbumDto> GetAll(string searchPhrase)
        {
            var supplierId = _userContextService.GetSupplierId;
            
            var albums = _dbContext
                .Albums
                .Include(s => s.Supplier)
                .Include(t => t.Tracks)
                .Where(a => a.SupplierId == supplierId)
                .Where(a => searchPhrase == null  || 
                            (a.Title.ToLower().Contains(searchPhrase.ToLower())) ||
                            (a.ArtistName.ToLower().Contains(searchPhrase.ToLower())) ||
                            (a.ReleaseYear.ToString().Contains(searchPhrase)))
                .ToList();

            var albumsDtos = _mapper.Map<List<AlbumDto>>(albums);

            return albumsDtos;
        }
        

        public AlbumDto GetById(int id)
        {
            var supplierId = _userContextService.GetSupplierId;
            
            var album = _dbContext
                .Albums
                .Include(s => s.Supplier)
                .Include(t => t.Tracks)
                .Where(a => a.SupplierId == supplierId)
                .FirstOrDefault(a => a.Id == id);
            
            var albumDto = _mapper.Map<AlbumDto>(album);
            return albumDto;
        }

        //POST
        public int Create(CreateAlbumDto dto)
        {
            var album = _mapper.Map<Album>(dto);
            _dbContext.Albums.Add(album);
            _dbContext.SaveChanges();

            return album.Id;
        }

        //PUT
        public void Update(int id, UpdateAlbumtDto dto)
        {
            var album = _dbContext
                .Albums
                .FirstOrDefault(a => a.Id == id);

            album.ArtistName = dto.ArtistName;
            album.Title = dto.Title;
            album.Version = dto.Version;
            album.ReleaseYear = dto.ReleaseYear;

            _dbContext.SaveChanges();
        }

        //DELETE
        public void Delete(int id)
        {
            var album = _dbContext
                .Albums
                .FirstOrDefault(a => a.Id == id);

            _dbContext.Albums.Remove(album);
            _dbContext.SaveChanges();
        }
       
    }

    
}
