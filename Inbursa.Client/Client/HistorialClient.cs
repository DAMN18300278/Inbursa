using Inbursa.Models;

namespace Inbursa;

public static class HistorialClient
{
     private static readonly List<Historial> historiales = new ()
    {
        new Historial()
        {
            Num_Historial= 1,
            Cantidad= 23,
            Pago_Realizados =2,
            Pago_Pendientes= 5,
            Num_Cuenta = 1,
            Nomina_Encargado = 1,
            Estado = true,
        },
    };
    public static Historial[] GetHistorial()
    {
        return historiales.ToArray();
    }
}