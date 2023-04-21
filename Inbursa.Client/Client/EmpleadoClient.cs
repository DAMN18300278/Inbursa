using Inbursa.Client.Models;

namespace Inbursa.Client;

public static class EmpleadoClient
{
     private static readonly List<Empleado> empleados = new ()
    {
        new Empleado()
        {
            Nomina= 1,
            CURP= "ASDASDSAD",
        },
    };
    public static Empleado[] GetEmpleado()
    {
        return empleados.ToArray();
    }
}