using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Context.DAL;
using SistemaVentas.Models.Models;
using SistemaVentas.Services;

namespace SistemaVentas.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriasController(CategoriasService categoriasService) : ControllerBase
	{
		// GET: api/Categorias
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Categorias>>> GetCategorias()
		{
			var categorias = await categoriasService.GetCategorias();

			if (categorias == null)
			{
				return NotFound();
			}

			return Ok(categorias);
		}

		// GET: api/Categorias/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Categorias>> GetCategorias(int id)
		{
			var categoria = await categoriasService.GetCategoria(id);
			if (categoria == null)
			{
				return NotFound();
			}
			return Ok(categoria);
		}

		// PUT: api/Categorias/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCategorias(Categorias categoria)
		{
			var categoriaUpdated = categoriasService.Update(categoria);

			if (categoriaUpdated == null)
			{
				return NotFound();
			}

			return Ok(categoriaUpdated);
		}

		// POST: api/Categorias
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Categorias>> PostCategorias(Categorias categoria)
		{
			var categoriaSaved = await categoriasService.Save(categoria);

			if (categoriaSaved == null)
			{
				return NotFound();
			}

			return Ok(categoriaSaved);
		}

		// DELETE: api/Categorias/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCategorias(int id)
		{
			await categoriasService.Delete(id);

			return NoContent();
		}
	}
}