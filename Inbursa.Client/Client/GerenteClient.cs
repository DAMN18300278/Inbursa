using Inbursa.Client.Models;

namespace Inbursa.Client;

public static class GerenteClient
{
     private static readonly List<Gerente> gerentes = new ()
    {
        new Gerente()
        {
            Num_Nom =1,
            Nomina= 1,
            Dias_Vacaciones=0,
        },
    };
    public static Gerente[] GetGerente()
    {
        return gerentes.ToArray();
    }
}