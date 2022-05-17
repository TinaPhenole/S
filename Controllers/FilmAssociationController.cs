using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SFF_Komplettering;
using SFF_Komplettering.Data;

namespace SFF_Komplettering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmAssociationController : ControllerBase
    {
        private readonly SFFDbContext _context;

        public FilmAssociationController(SFFDbContext context)
        {
            _context = context;
        }

        // GET: api/FilmAssociation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmAssociation>>> GetFilmAssociation()
        {
            return await _context.FilmAssociation.ToListAsync();
        }

        // GET: api/FilmAssociation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmAssociation>> GetFilmAssociation(int id)
        {
            var filmAssociation = await _context.FilmAssociation.FindAsync(id);

            if (filmAssociation == null)
            {
                return NotFound();
            }

            return filmAssociation;
        }

        // PUT: api/FilmAssociation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmAssociation(int id, FilmAssociation filmAssociation)
        {
            if (id != filmAssociation.Id)
            {
                return BadRequest();
            }

            _context.Entry(filmAssociation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmAssociationExists(id))
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

        // POST: api/FilmAssociation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FilmAssociation>> PostFilmAssociation(FilmAssociation filmAssociation)
        {
            _context.FilmAssociation.Add(filmAssociation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmAssociation", new { id = filmAssociation.Id }, filmAssociation);
        }

        // DELETE: api/FilmAssociation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmAssociation(int id)
        {
            var filmAssociation = await _context.FilmAssociation.FindAsync(id);
            if (filmAssociation == null)
            {
                return NotFound();
            }

            _context.FilmAssociation.Remove(filmAssociation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmAssociationExists(int id)
        {
            return _context.FilmAssociation.Any(e => e.Id == id);
        }
    }
}
