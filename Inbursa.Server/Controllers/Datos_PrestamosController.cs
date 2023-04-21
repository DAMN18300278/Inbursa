using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudBlazor.Server.Context;
using Inbursa.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inbursa.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Datos_PrestamosController : ControllerBase
    {
        private readonly MyDbContext context;

        public Datos_PrestamosController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Datos_Prestamos>>> GetDatos_Prestamos()
        {
            return await context.Datos_Prestamos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Datos_Prestamos>> GetDatos_PrestamosById(int id)
        {
            var datos_prestamos = await context.Datos_Prestamos.FirstOrDefaultAsync(c => c.Num_Folio == id);

            if (datos_prestamos == null)
            {
                return NotFound();
            }

            return Ok(datos_prestamos);
        }
    }
}
