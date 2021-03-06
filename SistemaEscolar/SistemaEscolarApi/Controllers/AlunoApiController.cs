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
    public class AlunoApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlunoApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AlunoApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAluno()
        {
            return await _context.Aluno.ToListAsync();
        }

        // GET: api/AlunoApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAluno(int id)
        {
            var aluno = await _context.Aluno.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return aluno;
        }

        // PUT: api/AlunoApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAluno([FromBody] Aluno aluno)
        {

            _context.Entry(aluno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunoExists(aluno.Id))
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

        // POST: api/AlunoApi
        [HttpPost]
        public async Task<ActionResult<Aluno>> PostAluno([FromBody]Aluno aluno)
        {
            _context.Aluno.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAluno", new { id = aluno.Id }, aluno);
        }

        // DELETE: api/AlunoApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Aluno>> DeleteAluno(int id)
        {
            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }

            _context.Aluno.Remove(aluno);
            await _context.SaveChangesAsync();

            return aluno;
        }

        private bool AlunoExists(int id)
        {
            return _context.Aluno.Any(e => e.Id == id);
        }
    }
}
