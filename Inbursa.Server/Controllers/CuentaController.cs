using System;
using Inbursa.Server.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudBlazor.Server.Context;
using Microsoft.AspNetCore.Mvc;
using Inbursa.Server.Models;

namespace Inbursa.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private readonly MyDbContext context;

        public CuentaController(MyDbContext context)
        {
            this.context = context;
        }
    
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cuenta>>> GetCuentas()
        {
            return await context.Cuenta.Include(c => c.cuentaUsuario).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cuenta>> GetCuentaById(int id)
        {
            var cuenta = await context.Cuenta.FirstOrDefaultAsync(c => c.Num_Cuenta == id);
 
            if (cuenta == null)
            {
                return NotFound();
            }

            return Ok(cuenta);
        }
    }
}
