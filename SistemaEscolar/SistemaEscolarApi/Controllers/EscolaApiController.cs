using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEscolarApi;
using business;

namespace SistemaEscolarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EscolaApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EscolaApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Escola>>> GetEscola()
        {
            return await _context.Escola.ToListAsync();
        }

        // GET: api/EscolaApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Escola>> GetEscola(int id)
        {
            var escola = await _context.Escola.FindAsync(id);

            if (escola == null)
            {
                return NotFound();
            }

            return escola;
        }

        // PUT: api/EscolaApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEscola(int id, Escola escola)
        {
            if (id != escola.Id)
            {
                return BadRequest();
            }

            _context.Entry(escola).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EscolaExists(id))
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

        // POST: api/EscolaApi
        [HttpPost]
        public async Task<ActionResult<Escola>> PostEscola(Escola escola)
        {
            _context.Escola.Add(escola);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEscola", new { id = escola.Id }, escola);
        }

        // DELETE: api/EscolaApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Escola>> DeleteEscola(int id)
        {
            var escola = await _context.Escola.FindAsync(id);
            if (escola == null)
            {
                return NotFound();
            }

            _context.Escola.Remove(escola);
            await _context.SaveChangesAsync();

            return escola;
        }

        private bool EscolaExists(int id)
        {
            return _context.Escola.Any(e => e.Id == id);
        }
    }
}
