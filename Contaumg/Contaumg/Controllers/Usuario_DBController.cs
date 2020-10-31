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
    public class Usuario_DBController : ControllerBase
    {
        private readonly AppDbContext _context;

        public Usuario_DBController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuario_DB
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario_DB>>> GetUsuario()
        {
            return await _context.Usuario.ToListAsync();
        }

        // GET: api/Usuario_DB/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario_DB>> GetUsuario_DB(int id)
        {
            var usuario_DB = await _context.Usuario.FindAsync(id);

            if (usuario_DB == null)
            {
                return NotFound();
            }

            return usuario_DB;
        }

        // PUT: api/Usuario_DB/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario_DB(int id, Usuario_DB usuario_DB)
        {
            if (id != usuario_DB.id_usuario)
            {
                return BadRequest();
            }

            _context.Entry(usuario_DB).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Usuario_DBExists(id))
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

        // POST: api/Usuario_DB
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Usuario_DB>> PostUsuario_DB(Usuario_DB usuario_DB)
        {
            _context.Usuario.Add(usuario_DB);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario_DB", new { id = usuario_DB.id_usuario }, usuario_DB);
        }

        // DELETE: api/Usuario_DB/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuario_DB>> DeleteUsuario_DB(int id)
        {
            var usuario_DB = await _context.Usuario.FindAsync(id);
            if (usuario_DB == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario_DB);
            await _context.SaveChangesAsync();

            return usuario_DB;
        }

        [HttpGet("{username}/{Contraseña}")]
        public ActionResult<List<Usuario_DB>> GetIniciarSesion(string username, string Contraseña)
        {
            var usuario_DB = _context.Usuario.Where(usuario => usuario.username.Equals(username) && usuario.contraseña.Equals(Contraseña)).ToList();

            if (usuario_DB == null)
            {
                return NotFound();
            }

            return usuario_DB;
        }



        private bool Usuario_DBExists(int id)
        {
            return _context.Usuario.Any(e => e.id_usuario == id);
        }
    }
}
