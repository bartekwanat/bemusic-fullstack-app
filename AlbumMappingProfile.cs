using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using bemusic.Entities;
using bemusic.Models;


namespace bemusic
{
    public class AlbumMappingProfile : Profile
    {
        public AlbumMappingProfile()
        {
            CreateMap<Album, AlbumDto>()
                .ForMember(m => m.SupplierId, c => c.MapFrom(s => s.Supplier.Id));

            CreateMap<Track, TrackDto>();
            CreateMap<Supplier, SupplierDto>();

            CreateMap<CreateAlbumDto, Album>()
                .ForMember(a => a.Tracks, c => c.MapFrom(dto => new List<Track>()
                {
                    new Track()
                    {
                        ArtistName = dto.ArtistName,
                        Title = dto.Title,
                        ReleaseYear = dto.ReleaseYear
                    }
                }));

            CreateMap<CreateTrackDto, Track>();

            CreateMap<CreateSupplierDto, Supplier>();
        }
        
    }
}
