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
    public class ClientesController(ClientesService clienteService) : ControllerBase
    {
        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> GetClientes()
        {
            var clientes = await clienteService.GetClientes();
            return Ok(clientes);
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clientes>> GetCliente(int id)
        {
			var cliente = await clienteService.GetCliente(id);
			if (cliente == null)
			{
				return NotFound();
			}
			return Ok(cliente);
		}

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Clientes>> PostClientes(Clientes cliente)
        {
            var clienteSaved = clienteService.Save(cliente);
            return Ok(clienteSaved);
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutClientes(Clientes cliente)
        {
            var clienteUpdated = clienteService.Update(cliente);
            
            if(clienteUpdated == null)
            {
                return NotFound();
            }

            return Ok(clienteUpdated);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientes(int id)
        {
			await clienteService.Delete(id); // Esperar la eliminación del cliente

			return NoContent();
		}
    }
}
