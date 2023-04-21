using System.ComponentModel.DataAnnotations;

namespace Inbursa.Server.Models;

public class Cuenta
{
    public String? Usuario { get; set; }
    public float Saldo { get; set; }
    [Key]
    public int Num_Cuenta { get; set; }
   public bool Prestamo_Activo { get; set; }
}