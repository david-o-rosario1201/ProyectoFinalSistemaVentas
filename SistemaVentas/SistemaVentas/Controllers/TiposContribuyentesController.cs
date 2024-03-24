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
    public class TiposContribuyentesController(TiposContribuyenteService tiposContribuyenteService) : ControllerBase
    {
        // GET: api/TiposContribuyentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposContribuyente>>> GetTiposContribuyente()
        {
            var tiposContribuyentes = await tiposContribuyenteService.GetTiposContribuyentes();

            if(tiposContribuyentes == null)
            {
                return NotFound();
            }

            return Ok(tiposContribuyentes);
        }
	}
}
