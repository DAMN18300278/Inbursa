using System.ComponentModel.DataAnnotations;

namespace Inbursa.Server.Models;

public class Usuario
{
    [Key]
    public String? CURP { get; set; }
    public String? Nombre { get; set; }
    public String? Apellido_P { get; set; }
   public String? Apellido_M { get; set; }
   public DateTime Cumpleanos  { get; set; }
   public String? Contrasena {get; set;}
   public bool Autorizada {get; set;}
   public String? Nom_Usuario {get; set;}
}