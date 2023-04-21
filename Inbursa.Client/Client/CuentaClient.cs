using Inbursa.Client.Models;

namespace Inbursa.Client;

public static class CuentaClient
{
     private static readonly List<Cuenta> cuentas = new ()
    {
        new Cuenta()
        {
            Usuario= "ASDASD",
            Saldo= 23,
            Num_Cuenta =1,
            Prestamo_Activo= true,
        },
    };
    public static Cuenta[] GetCuenta()
    {
        return cuentas.ToArray();
    }
}