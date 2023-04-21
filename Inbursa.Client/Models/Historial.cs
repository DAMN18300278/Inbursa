using System.ComponentModel.DataAnnotations;

namespace Inbursa.Client.Models;

public class Historial
{
    public int Num_Historial { get; set; }
    public float Cantidad { get; set; }
    public int Pago_Realizados { get; set; }
    public int Pago_Pendientes { get; set; }
    public int Num_Cuenta { get; set; }
    public int Nomina_Encargado { get; set; }
    public bool Estado { get; set; }
}