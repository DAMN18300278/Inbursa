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
    public class EmpleadoController : ControllerBase
    {
        private readonly MyDbContext context;

        public EmpleadoController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleados()
        {
            return await context.Empleado.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleadoById(int id)
        {
            var empleado = await context.Empleado.FirstOrDefaultAsync(e => e.Nomina == id);

            if (empleado == null)
            {
                return NotFound();
            }

            return Ok(empleado);
        }
    }
}
