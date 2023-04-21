using System;
using Inbursa.Server.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudBlazor.Server.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
namespace Inbursa.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Cuenta : ControllerBase
    {
        public IEnumerable<Cuenta> Get()
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Cuenta.ToList();
            }
        }
        public Cuenta Get(int id)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                return dbContext.Cuenta.FirstOrDefault(e => e.Num_Cuenta == id);
            }
        }
    }
}
