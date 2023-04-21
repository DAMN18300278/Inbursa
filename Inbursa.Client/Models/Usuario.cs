using System.ComponentModel.DataAnnotations;

namespace Inbursa.Client.Models;

public class Usuario
{
    public String CURP { get; set; }
    public String Nombre { get; set; }
    public String Apellido_P { get; set; }
    public String Apellido_M { get; set; }
    public DateTime Cumpleanos  { get; set; }
    public String Contrasena {get; set;}
    public bool Autorizada {get; set;}
    public String Nom_Usuario {get; set;}
}