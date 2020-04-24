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
    public class seatsController : ControllerBase
    {
        private readonly BlogDbContext _context;

        public seatsController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: api/seats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<seats>>> Getseats()
        {
            var SeatList = await _context.seats.Include(Seat => Seat.seats1).ToListAsync(); //include = mange til mange tabel //theninclude = ligger her
            return SeatList;
        }

        // GET: api/seats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<seats>> Getseats(int id)
        {
            var exist = await _context.seats.FindAsync(id);

            if (exist == null)
            {
                return NotFound();
            }
            return exist;
        }

        // PUT: api/seats/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putseats(int id, seats seats)
        {
            if (id != seats.seatsId)
            {
                return BadRequest();
            }

            _context.Entry(seats).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!seatsExists(id))
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

        // POST: api/seats
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<seats>> Postseats(seats seats)
        {
            _context.seats.Add(seats);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getseats", new { id = seats.seatsId }, seats);
        }

        // DELETE: api/seats/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<seats>> Deleteseats(int id)
        {
            var seats = await _context.seats.FindAsync(id);
            if (seats == null)
            {
                return NotFound();
            }

            _context.seats.Remove(seats);
            await _context.SaveChangesAsync();

            return seats;
        }

        private bool seatsExists(int id)
        {
            return _context.seats.Any(e => e.seatsId == id);
        }
    }
}
