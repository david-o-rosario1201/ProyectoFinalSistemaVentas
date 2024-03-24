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
    public class ContactosController(ContactosService contactoService) : ControllerBase
    {
        // GET: api/Contactos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contactos>>> GetContactos()
        {
            var contactos = await contactoService.GetContactos();

            if(contactos == null)
            {
                return NotFound();
            }

            return Ok(contactos);
        }
    }
}
