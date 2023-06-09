using System.ComponentModel.DataAnnotations;

namespace Inbursa.Server.Models;

public class Historial
{
    [Key]
    public int Num_Historial { get; set; }
    public float Cantidad { get; set; }
    public int Pago_Realizados { get; set; }
    public int Pago_Pendientes { get; set; }
    public int Num_Cuenta { get; set; }
    public int Nomina_Encargado { get; set; }
    public bool Estado { get; set; }
}