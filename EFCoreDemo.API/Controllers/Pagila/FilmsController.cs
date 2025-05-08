using System.Reflection.Metadata.Ecma335;
using EFCoreDemo.API.Data;
using EFCoreDemo.API.Models;
using Microsoft.AspNetCore.Mvc;
using EFCoreDemo.API.DTO;
using Microsoft.EntityFrameworkCore;
namespace EFCoreDemo.API.Controllers
{
    [ApiController]
    [Route("api/films")]
    public class FilmsController : ControllerBase
    {
        private readonly dvdrentalContext _context;

        public FilmsController(dvdrentalContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FilmDTO>> GetFilm(int id)
        {
            var film = await _context.Films
         .Where(f => f.FilmId == id)
         .Select(f => new FilmDTO
         {
             FilmId = f.FilmId,
             Title = f.Title
         })
         .FirstOrDefaultAsync();

            if (film == null)
                return NotFound();

            return film;

        }
    }
}
