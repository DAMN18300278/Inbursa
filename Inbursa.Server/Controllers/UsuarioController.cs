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
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly MyDbContext context;

        public UsuarioController(MyDbContext context)
        {
            this.context = context;
        }
    
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await context.Usuario.ToListAsync();
        }

        [HttpGet("{CURP}")]
        public async Task<ActionResult<Usuario>> GetUsuarioById(String CURP)
        {
            var usuario = await context.Usuario.FirstOrDefaultAsync(c => c.CURP == CURP);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpPost("Add")]
        public async Task<ActionResult> AgregarUsuario(Usuario usuario)
        {
            try
            {
                Cuenta cuenta = new (){
                    Usuario = usuario.CURP,
                    Saldo = 0,
                    Num_Cuenta = 0,
                    Prestamo_Activo = false
                };

                String newNombre = usuario.CURP.Substring(0, 4);

                usuario.Nom_Usuario = newNombre;

                usuario.Contrasena = usuario.Cumpleanos.Day.ToString() + "-" + usuario.Cumpleanos.Month.ToString() + "-" + usuario.Cumpleanos.Year.ToString();

                // Agregar el usuario a la base de datos
                await context.Usuario.AddAsync(usuario);

                // Guardar los cambios en la base de datos
                await context.SaveChangesAsync();

                // Agregar la cuenta a la base de datos
                await context.Cuenta.AddAsync(cuenta);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status302Found, ex.Message);
            }
        }
    }
}