using Inbursa.Client.Models;

namespace Inbursa.Client;

public static class Datos_PrestamosClient
{
     private static readonly List<Datos_Prestamos> Datos_Prestamosos = new ()
    {
        new Datos_Prestamos()
        {
            Num_Folio= 1,
            Fecha_Solicitud= new DateTime(2008, 5, 1, 8, 30, 52),
            Fecha_Aprobacion =new DateTime(2008, 5, 1, 8, 30, 52),
            Fecha_Liquidacion= new DateTime(2008, 5, 1, 8, 30, 52),
            Fecha_Limite = new DateTime(2008, 5, 1, 8, 30, 52),
            Num_Historial = 1,
        },
    };
    public static Datos_Prestamos[] GetDatos_Prestamos()
    {
        return Datos_Prestamosos.ToArray();
    }
}