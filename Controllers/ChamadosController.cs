using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiChamados.Data;
using ApiChamados.Models;

namespace ApiChamados.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChamadosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ChamadosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Chamados.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Chamado chamado)
        {
            _context.Chamados.Add(chamado);
            await _context.SaveChangesAsync();
            return Ok(chamado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            var chamado = await _context.Chamados.FindAsync(id);
            if (chamado == null) return NotFound();

            chamado.Status = status;
            await _context.SaveChangesAsync();
            return Ok(chamado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var chamado = await _context.Chamados.FindAsync(id);
            if (chamado == null) return NotFound();

            _context.Chamados.Remove(chamado);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
