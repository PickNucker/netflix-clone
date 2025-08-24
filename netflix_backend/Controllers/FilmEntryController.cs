using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netflix_backend.Data;
using netflix_backend.models;

namespace netflix_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmEntryController : ControllerBase
    {
        private readonly NetflixCloneDbContext _context;

        public FilmEntryController(NetflixCloneDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmEntry>>> GetFilmEntries()
        {
            try
            {
                var filmEntries = await _context.FilmEntries.ToListAsync();
                return Ok(filmEntries);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error = {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FilmEntry>> GetFilmEntry(int id)
        {
            try
            {
                var filmEntry = await _context.FilmEntries.FindAsync(id);

                if (filmEntry == null)
                {
                    return NotFound();
                }

                return Ok(filmEntry);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error = {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<FilmEntry>> PostFilmEntry(FilmEntry filmEntry)
        {
            try
            {
                filmEntry.Id = 0;

                _context.FilmEntries.Add(filmEntry);

                await _context.SaveChangesAsync();

                var resourceUrl = Url.Action(nameof(GetFilmEntry), new { id = filmEntry.Id });

                return Created(resourceUrl, filmEntry);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error = {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutFilmEntry(int id, [FromBody] FilmEntry filmEntry)
        {
            if (id != filmEntry.Id)
            {
                return BadRequest("ID in URL does not match ID in body.");
            }

            _context.Entry(filmEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmEntryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error = {ex.Message}");
            }
        }

        bool FilmEntryExists(int id) => _context.FilmEntries.Any(e => e.Id == id);

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmEntry(int id)
        {
            try
            {
                var film = await _context.FilmEntries.FindAsync(id);
                if (film == null) return NotFound();

                _context.FilmEntries.Remove(film);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error = {ex.Message}");
            }
        }


    }
}