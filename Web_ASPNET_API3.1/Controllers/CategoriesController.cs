using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_ASPNET_Core3._1.Models;

namespace Web_ASPNET_API3._1.Controllers
{
    public class CategoriesController
    {
        public CategoriesController(Context @object)
        {
        }

        [Route("api/[controller]")]
        [ApiController]
        public class CategoriasController : ControllerBase
        {
            private readonly Context _context;

            public CategoriasController(Context context)
            {
                _context = context;
            }

            // GET: api/Categorias
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Category>>> GetCategorias()
            {
                return await _context.Categories.ToListAsync();
            }

            // GET: api/Categorias/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Category>> GetCategoria(int id)
            {
                var categoria = await _context.Categories.FindAsync(id);

                if (categoria == null)
                {
                    return NotFound();
                }

                return categoria;
            }

            // PUT: api/Categorias/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            [HttpPut("{id}")]
            public async Task<IActionResult> PutCategoria(int id, Category categoria)
            {
                if (id != categoria.Id)
                {
                    return BadRequest();
                }

                _context.SetModified(categoria);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaExists(id))
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

            // POST: api/Categorias
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            [HttpPost]
            public async Task<ActionResult<Category>> PostCategoria(Category categoria)
            {
                _context.Categories.Add(categoria);

                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCategoria", new { id = categoria.Id }, categoria);
            }

            // DELETE: api/Categorias/5
            [HttpDelete("{id}")]
            public async Task<ActionResult<Category>> DeleteCategoria(int id)
            {
                var categoria = await _context.Categories.FindAsync(id);
                if (categoria == null)
                {
                    return NotFound();
                }

                _context.Categories.Remove(categoria);
                await _context.SaveChangesAsync();

                return categoria;
            }

            private bool CategoriaExists(int id)
            {
                return _context.Categories.Any(e => e.Id == id);
            }
        }

        public Task GetCategoria(int v)
        {
            throw new NotImplementedException();
        }
    }
}    
