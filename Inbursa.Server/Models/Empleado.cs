using System.ComponentModel.DataAnnotations;

namespace Inbursa.Server.Models;

public class Empleado
{
    [Key]
    public int Nomina { get; set; }
    public String? CURP { get; set; }
}