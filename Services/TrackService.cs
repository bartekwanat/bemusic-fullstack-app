using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using bemusic.Entities;
using bemusic.Models;
using Microsoft.EntityFrameworkCore;

namespace bemusic.Services
{

    public interface ITrackService
    {
        List<TrackDto> GetAll(int albumId);
        TrackDto GetById(int albumId, int trackId);
        int Create(int albumId, CreateTrackDto dto);
        void RemoveAll(int albumId);
        void RemoveById(int albumId, int trackId);
    }

    public class TrackService : ITrackService
    {
        private readonly Entities.BeMusicDbContext _context;
        public IMapper _mapper;

        public TrackService(Entities.BeMusicDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET
        public List<TrackDto> GetAll(int albumId)
        {
            var album = getAlbumById(albumId);

            var tracksDtos = _mapper.Map<List<TrackDto>>(album.Tracks);
            return tracksDtos;
        }

        public TrackDto GetById(int albumId, int trackId)
        {
            var album = _context.Albums.FirstOrDefault(a => a.Id == albumId);

            var track = _context.Tracks.FirstOrDefault(t => t.Id == trackId);
            
            var dishDto = _mapper.Map<TrackDto>(track);
            
            return dishDto;
        }

        //POST
        public int Create(int albumId, CreateTrackDto dto)
        {
            var album = getAlbumById(albumId);

            var trackEntity = _mapper.Map<Track>(dto);

            trackEntity.AlbumId = albumId;

            _context.Tracks.Add(trackEntity);
            _context.SaveChanges();

            return trackEntity.Id;


        }

        //DELETE
        public void RemoveAll(int albumId)
        {
            var album = getAlbumById(albumId);
            _context.RemoveRange(album.Tracks);
            _context.SaveChanges();
        }

        public void RemoveById(int albumId, int trackId)
        {
            var album = getAlbumById(albumId);
            var track = _context.Tracks.FirstOrDefault(t => t.Id == trackId);

            _context.Tracks.Remove(track);
            _context.SaveChanges();
        }


        //
        private Album getAlbumById(int albumId)
        {
            var album = _context
                .Albums
                .Include(t => t.Tracks)
                .FirstOrDefault(a => a.Id == albumId);

            return album;
        }
    }

    
}
