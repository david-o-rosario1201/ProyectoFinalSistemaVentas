using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Models.Models;
using SistemaVentas.Context.DAL;
using SistemaVentas.Services;

namespace SistemaVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController(ProveedoresService proveedorService) : ControllerBase
    {
        // GET: api/Proveedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proveedores>>> GetProveedores()
        {
            var proveedores = await proveedorService.GetProveedores();

            if (proveedores == null)
            {
                return NotFound();
            }

            return Ok(proveedores);
        }

        // GET: api/Proveedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proveedores>> GetProveedor(int id)
        {
            var proveedor = await proveedorService.GetProveedor(id);

            if(proveedor == null)
            {
                return NotFound();
            }

            return Ok(proveedor);
        }

		// POST: api/Proveedores
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Proveedores>> PostClientes(Proveedores proveedor)
		{
			var clienteSaved = await proveedorService.Save(proveedor);

			if (clienteSaved == null)
			{
				return NotFound();
			}

			return Ok(clienteSaved);
		}

		// PUT: api/Proveedores/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
        public async Task<IActionResult> PutProveedores(Proveedores proveedor)
        {
            var proveedorUpdated = await proveedorService.Update(proveedor);
            return Ok(proveedorUpdated);
        }

        //DELETE: api/Proveedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProveedores(short id)
        {
            var proveedorDeleted = await proveedorService.Delete(id);
            return Ok(proveedorDeleted);
        }
    }
}
