using System.ComponentModel.DataAnnotations;

namespace Inbursa.Client.Models;

public class Rifa
{
    public int Num_Boleto { get; set; }
    public int Cuenta { get; set; }
    public DateTime Fecha_Boleto { get; set; }
}