namespace CrudBlazor.Server.Context;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inbursa.Server.Models;

public interface IMyDbContext
{
    DbSet<Datos_Prestamos> Datos_Prestamos { get; set; }
    DbSet<Cuenta> Cuenta { get; set; }
    DbSet<Empleado> Empleado { get; set; }
    DbSet<Gerente> Gerente { get; set; }
    DbSet<Historial> Historial { get; set; }
    DbSet<Rifa> Rifa { get; set; }
    DbSet<Usuario> Usuario { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDbContext : DbContext, IMyDbContext
{
    private readonly IConfiguration config;
    public MyDbContext(IConfiguration _config)
    {
        config = _config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("banco"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    #region Tables
    public DbSet<Datos_Prestamos> Datos_Prestamos { set; get; } = null!;
    public DbSet<Cuenta> Cuenta { set; get; } = null!;
    public DbSet<Empleado> Empleado { set; get; } = null!;
    public DbSet<Gerente> Gerente { set; get; } = null!;
    public DbSet<Historial> Historial { set; get; } = null!;
    public DbSet<Rifa> Rifa { set; get; } = null!;
    public DbSet<Usuario> Usuario { set; get; } = null!;
    #endregion
}