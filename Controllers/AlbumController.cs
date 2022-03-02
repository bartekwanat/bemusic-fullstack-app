using System.Collections.Generic;
using bemusic.Models;
using bemusic.Services;
using Microsoft.AspNetCore.Mvc;

namespace bemusic.Controllers
{
    [Route("api/album")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        

        public AlbumController(IAlbumService albumService )
        {
            _albumService = albumService;
        }

        //GET
        [HttpGet]
        public ActionResult<IEnumerable<AlbumDto>> GetAll([FromQuery] string searchPhrase)
        {
            
            var albumsDtos = _albumService.GetAll(searchPhrase);
                
            return Ok(albumsDtos);
        }
        
    

        [HttpGet("{id}")]
        public ActionResult<AlbumDto> Get([FromRoute] int id)
        {

            var album = _albumService.GetById(id);

            if (album is null)
            {
                return NotFound();
            }

            return album;
        }
        
        //POST
        [HttpPost]
        public ActionResult CreateAlbum([FromBody] CreateAlbumDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var id = _albumService.Create(dto);

            return Created($"/api/albums/{id}", null);
        }

        //PUT
        [HttpPut]
        public ActionResult Update([FromRoute] int id, [FromBody] UpdateAlbumtDto dto)
        {
            _albumService.Update(id, dto);
            return Ok();
        }

    }

   
}
