using AnimeApi.Models;
using AnimeApi.Services;
using AnimeApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MusicController : ControllerBase
    {
        private IMusicService _musicService;

        public MusicController(IMusicService musicService)
        {
            _musicService = musicService;
        }

        // GET: api/<MusicController>
        [HttpGet ("Name/{name}")]
        public ActionResult<IEnumerable<Music>> Get(string name)
        {
            var musics = _musicService.GetMusicAnimeName(name);
            if (musics.Any())
            {
                return Ok(musics);
            }
            else
            {
                return NotFound("No se encontraron las músicas con el nombre especificado");
            }
        }

        [HttpGet("Category/{category}")]
        public ActionResult<IEnumerable<Music>> Gett(string category)
        {
            var musics = _musicService.GetMusicAnimeCategory(category);
            if (musics.Any())
            {
                return Ok(musics);
            }
            else
            {
                return NotFound("No se encontraron las músicas con la categoria especificada");
            }
        }

        [HttpGet("Author/{author}")]
        public ActionResult<IEnumerable<Music>> Gettt(string author)
        {
            var musics = _musicService.GetMusicAnimeAuthor(author);
            if (musics.Any())
            {
                return Ok(musics);
            }
            else
            {
                return NotFound("No se encontraron las músicas con el autor especificado");
            }
        }

        [HttpDelete("Delete/{name}")]
        public ActionResult Delete(string name)
        {
            var result = _musicService.DeleteMusicAnimeName(name);
            if (result)
            {
                return Ok("Música eliminado exitosamente.");
            }
            else
            {
                return NotFound("No se encontró la música con el nombre especificado.");
            }
        }
    }
}
