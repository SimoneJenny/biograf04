using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using biograf01.Model;

namespace biograf01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatersController : ControllerBase
    {
        private readonly BlogDbContext _context;
        public TheatersController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: api/Theaters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Theater>>> GetTheater()
        {
            var TheaterList = await _context.Theater.Include(theaters => theaters.Theatersseats).ThenInclude(s => s.seat).ToListAsync(); //include = mange til mange tabel //theninclude = ligger her
            return TheaterList;

            //foreach (var movie in MovieList)
            //{
            //    foreach (var moviegenre in movie.Moviegenre)
            //    {
            //        moviegenre.genre.moviegenre = null;
            //    }
            //}
            //return MovieList;


        }

        // GET: api/Theaters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Theater>> GetTheater(int id)
        {
            var exit = await _context.Theater.FindAsync(id);

            if (exit == null)
            {
                return NotFound();
            }

            return exit;
        }

        // PUT: api/Theaters/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheater(int id, Theater theater)
        {
            if (id != theater.TheaterId)
            {
                return BadRequest();
            }

            _context.Entry(theater).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TheaterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Theaters
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Theater>> PostTheater(Theater theater)
        {
            _context.Theater.Add(theater);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheater", new { id = theater.TheaterId }, theater);
        }

        // DELETE: api/Theaters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Theater>> DeleteTheater(int id)
        {
            var theater = await _context.Theater.FindAsync(id);
            if (theater == null)
            {
                return NotFound();
            }

            _context.Theater.Remove(theater);
            await _context.SaveChangesAsync();

            return theater;
        }

        private bool TheaterExists(int id)
        {
            return _context.Theater.Any(e => e.TheaterId == id);
        }
    }
}
