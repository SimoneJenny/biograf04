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
    public class ZipCodesController : ControllerBase
    {
        private readonly BlogDbContext _context;

        public ZipCodesController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: api/ZipCodes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZipCode>>> GetzipCode()
        {
            var ZipCodeList = await _context.zipCode.Include(zipcode => zipcode).ToListAsync(); //include = mange til mange tabel //theninclude = ligger her
            return ZipCodeList;
        }

        // GET: api/ZipCodes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZipCode>> GetZipCode(int id)
        {
            var exit = await _context.zipCode.FindAsync(id);

            if (exit == null)
            {
                return NotFound();
            }

            return exit;
        }

        // PUT: api/ZipCodes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZipCode(int id, ZipCode zipCode)
        {
            if (id != zipCode.zipcodeId)
            {
                return BadRequest();
            }

            _context.Entry(zipCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZipCodeExists(id))
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

        // POST: api/ZipCodes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ZipCode>> PostZipCode(ZipCode zipCode)
        {
            _context.zipCode.Add(zipCode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZipCode", new { id = zipCode.zipcodeId }, zipCode);
        }

        // DELETE: api/ZipCodes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ZipCode>> DeleteZipCode(int id)
        {
            var zipCode = await _context.zipCode.FindAsync(id);
            if (zipCode == null)
            {
                return NotFound();
            }

            _context.zipCode.Remove(zipCode);
            await _context.SaveChangesAsync();

            return zipCode;
        }

        private bool ZipCodeExists(int id)
        {
            return _context.zipCode.Any(e => e.zipcodeId == id);
        }
    }
}
