using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Contaumg.Context;
using Contaumg.Models;

namespace Contaumg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodoesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PeriodoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Periodoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Periodo>>> GetPeriodo()
        {
            return await _context.Periodo.ToListAsync();
        }

        // GET: api/Periodoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Periodo>> GetPeriodo(int id)
        {
            var periodo = await _context.Periodo.FindAsync(id);

            if (periodo == null)
            {
                return NotFound();
            }

            return periodo;
        }

        // PUT: api/Periodoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriodo(int id, Periodo periodo)
        {
            if (id != periodo.PeriodoId)
            {
                return BadRequest();
            }

            _context.Entry(periodo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPeriodo", new { id = periodo.PeriodoId }, periodo);
        }

        // POST: api/Periodoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Periodo>> PostPeriodo(Periodo periodo)
        {
            _context.Periodo.Add(periodo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeriodo", new { id = periodo.PeriodoId }, periodo);
        }

        // DELETE: api/Periodoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Periodo>> DeletePeriodo(int id)
        {
            var periodo = await _context.Periodo.FindAsync(id);
            if (periodo == null)
            {
                return NotFound();
            }

            _context.Periodo.Remove(periodo);
            await _context.SaveChangesAsync();

            return Ok(id);
        }

        private bool PeriodoExists(int id)
        {
            return _context.Periodo.Any(e => e.PeriodoId == id);
        }
    }
}
