using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using biograf01.Model;
using Microsoft.AspNetCore.Cors;

namespace biograf01.Controllers
{
    [EnableCors("MyAllowSpecificOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        private readonly BlogDbContext _context;

        public ShowsController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: api/Shows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Show>>> GetShow()
        {
        var list = await _context.Show.Include(sh => sh.movie).ToListAsync();  
            //return list;
            //1 til mange relation
          

            return list;

            //return await _context.Show.Include(s => s.movie)
            //    .Include(a => a.theater)
            //    .ThenInclude(m => m.Theatersseats).ToListAsync();

            //var MovieList = await _context.Movies.Include(movieList => movieList.Moviegenre).ThenInclude(a => a.genre).Include(show => show.shows).ToListAsync();
            //return await _context.Show.Include(s => s.theater).ToListAsync(); //Include Movie.
        }

        // GET: api/Shows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Show>> GetShow(int id)
        {
            var show = await _context.Show.FindAsync(id);

            if (show == null)
            {
                return NotFound();
            }

            return show;
        }

        [HttpGet("movie/{movieid}")]
        //mindre end
        public async Task<ActionResult<IEnumerable<Show>>> GetMovieShow(int movieid)
        {
            var show = await _context.Show.Where(s=>s.movie.MovieId==movieid).ToListAsync();

            if (show == null)
            {
                return NotFound();
            }
            return show;
        }

        // PUT: api/Shows/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShow(int id, Show show)
        {
            if (id != show.showId)
            {
                return BadRequest();
            }

            _context.Entry(show).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShowExists(id))
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

        // POST: api/Shows
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Show>> PostShow(Show show)
        {
            _context.Show.Add(show);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShowExists(show.showId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShow", new { id = show.showId }, show);
        }

        // DELETE: api/Shows/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Show>> DeleteShow(int id)
        {
            var show = await _context.Show.FindAsync(id);
            if (show == null)
            {
                return NotFound();
            }

            _context.Show.Remove(show);
            await _context.SaveChangesAsync();

            return show;
        }

        private bool ShowExists(int id)
        {
            return _context.Show.Any(e => e.showId == id);
        }
    }
}
