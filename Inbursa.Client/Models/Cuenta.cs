using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inbursa.Client.Models;

public class Cuenta
{
    public String? Usuario { get; set; }
    public double Saldo { get; set; }
    [Key]
    public int Num_Cuenta { get; set; }
    public bool Prestamo_Activo { get; set; }

    [ForeignKey("Usuario")]
    public virtual Usuario cuentaUsuario { get; set; }
}