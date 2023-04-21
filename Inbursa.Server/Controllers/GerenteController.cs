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
    public class GerenteController : ControllerBase
    {
        private readonly MyDbContext context;

        public GerenteController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gerente>>> GetGerentes()
        {
            return await context.Gerente.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Gerente>> GetGerenteById(int id)
        {
            var gerente = await context.Gerente.FirstOrDefaultAsync(g => g.Nomina == id);

            if (gerente == null)
            {
                return NotFound();
            }

            return Ok(gerente);
        }
    }
}
