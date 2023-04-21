using Inbursa.Client.Models;


namespace Inbursa.Client;

public static class UsuarioClient
{
     private static readonly List<Usuario> usuarios = new ()
    {
        new Usuario()
        {
            CURP= "ASDASDASDAS",
            Nombre= "Diego",
            Apellido_P ="Medel",
            Apellido_M= "Nambo",
            Cumpleanos = new DateTime(2008, 5, 1, 8, 30, 52),
            Contrasena = "asda",
            Autorizada = true,
            Nom_Usuario = "Diego123"
        },
    };
    public static Usuario[] GetUsuarios()
    {
        return usuarios.ToArray();
    }
}