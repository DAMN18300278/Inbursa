using System.ComponentModel.DataAnnotations;

namespace Inbursa.Models;

public class Datos_Prestamos
{
    public int Num_Folio { get; set; }
    public DateTime Fecha_Solicitud { get; set; }
    public DateTime Fecha_Aprobacion { get; set; }
    public DateTime Fecha_Liquidacion { get; set; }
    public DateTime Fecha_Limite { get; set; }
    public int Num_Historial { get; set; }
}