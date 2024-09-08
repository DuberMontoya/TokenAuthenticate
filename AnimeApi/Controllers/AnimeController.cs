using AnimeApi.Models;
using AnimeApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AnimeController : ControllerBase
    {
        private IAnimeService _animeService;

        public AnimeController(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        // GET: api/<AnimeController>
        [HttpGet ("Num/{chapters}")]
        public ActionResult<IEnumerable<Anime>> Get(int chapters)
        {

            var animes = _animeService.GetAnimeNumCapcher(chapters);
            if (animes.Any())
            {
                return Ok(animes);
            }
            else
            {
                return NotFound("No se encontraron animes con el número de capitos especificado");
            }
        }

        [HttpGet("Name/{name}")]
        public ActionResult<IEnumerable<Anime>> Get(string name)
        {
            var animes = _animeService.GetAnimeName(name);
            if (animes.Any())
            {
                return Ok(animes);
            }
            else
            {
                return NotFound("No se encontraron animes con el nombre especificado");
            }
        }
        
        [HttpGet("Year/{year}")]
        public ActionResult<IEnumerable<Anime>> Gett(int year)
        {
            var animes = _animeService.GetAnimeYear(year);
            if (animes.Any())
            {
                return Ok(animes);
            }
            else
            {
                return NotFound("No se encontraron animes con el año especificado");
            }
        }

        [HttpDelete("delete/{name}")]
        public ActionResult Delete(string name)
        {
            var result = _animeService.DeleteAnimeName(name);
            if (result)
            {
                return Ok("Anime eliminado exitosamente.");
            }
            else
            {
                return NotFound("No se encontró el anime con el nombre especificado.");
            }
        }
    }
}
