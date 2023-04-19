using Inbursa.Models;
namespace Inbursa;

public static class RifaClient
{
     private static readonly List<Rifa> rifas = new ()
    {
        new Rifa()
        {
            Num_Boleto= 1,
            Cuenta= 1,
            Fecha_Boleto= new DateTime(2008, 5, 1, 8, 30, 52),
        },
    };
    public static Rifa[] GetRifa()
    {
        return rifas.ToArray();
    }
}