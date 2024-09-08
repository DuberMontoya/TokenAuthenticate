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
    public class CharapterController : ControllerBase
    {
        private ICharapterService _chapterService;
        public CharapterController(ICharapterService chapterService)
        {
            _chapterService = chapterService;
        }

        // GET: api/<CharapterController>
        [HttpGet("Name/{name}")]
        public ActionResult<IEnumerable<Charapter>> Get(string name)
        {
            var charapters = _chapterService.GetCharacterName(name);
            if (charapters.Any())
            {
                return Ok(charapters);
            }
            else
            {
                return NotFound("No se encontraron personajes con el nombre especificado");
            }
        }

        [HttpGet("Age/{age}")]
        public ActionResult<IEnumerable<Charapter>> Get(int age)
        {
            var charapters = _chapterService.GetCharacterAge(age);
            if (charapters.Any())
            {
                return Ok(charapters);
            }
            else
            {
                return NotFound("No se encontraron personajes con la edad especificada");
            }
        }

        [HttpGet("Bueno/Malo/{moodBad}")]
        public ActionResult<IEnumerable<Charapter>> Gett(string moodBad)
        {
            var charapters = _chapterService.GetCharapterMoodOrBad(moodBad);
            if (charapters.Any())
            {
                return Ok(charapters);
            }
            else
            {
                return NotFound("No se encontraron personajes con el dato especificado");
            }
        }

        [HttpDelete("Delete/{name}")]
        public ActionResult Delete(string name)
        {
            var result = _chapterService.DeleteCharacterName(name);
            if (result)
            {
                return Ok("Personaje eliminado exitosamente.");
            }
            else
            {
                return NotFound("No se encontró el personaje con el nombre especificado.");
            }
        }
    }
}
