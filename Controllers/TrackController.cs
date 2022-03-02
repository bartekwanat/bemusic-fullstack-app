using bemusic.Models;
using bemusic.Services;
using Microsoft.AspNetCore.Mvc;

namespace bemusic.Controllers
{
    [Route("api/albums/{albumId}/track")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ITrackService _trackService;

        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        //GET
        [HttpGet]
        public ActionResult<TrackDto> Get([FromRoute] int albumId)
        {
            var track = _trackService.GetAll(albumId);
            return Ok(track);
        }

        [HttpGet("{trackId}")]
        public ActionResult Get([FromRoute] int albumId, [FromRoute] int trackId)
        {
            var track = _trackService.GetById(albumId, trackId);
            return Ok(track);
        }

        //POST
        [HttpPost]
        public ActionResult Post([FromRoute] int albumId, [FromBody] CreateTrackDto dto)
        {
            var newTrackId = _trackService.Create(albumId, dto);

            return Created($"api/{albumId}/track/{newTrackId}", null);
        }

        //DELETE
        [HttpDelete]
        public ActionResult Delete([FromRoute] int albumId)
        {
            _trackService.RemoveAll(albumId);
            return NoContent();
        }

        [HttpDelete("{trackId}")]
        public ActionResult Delete([FromRoute] int albumId, [FromRoute] int trackId)
        {
            _trackService.RemoveById(albumId, trackId);
            return NoContent();
        }

    }

    
}
