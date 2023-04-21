using System.ComponentModel.DataAnnotations;

namespace Inbursa.Server.Models;

public class Gerente
{
    [Key]
    public int Num_Nom { get; set; }
    public int Nomina { get; set; }
    public int Dias_Vacaciones { get; set; }
}