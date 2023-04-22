using System.ComponentModel.DataAnnotations;

namespace Inbursa.Client.Models;

public class Usuario
{
    [Required][StringLength (19)]
    [RegularExpression(@"^[A-Z]{4}\d{6}[H,M][A-Z]{5}[0-9,A-Z]\d$", ErrorMessage = "El CURP no es valido")]
    public String CURP { get; set; }

    [Required][StringLength (200)]
    public String Nombre { get; set; }

    [Required][StringLength (30)]
    public String Apellido_P { get; set; }

    [Required][StringLength (30)]
    public String Apellido_M { get; set; }

    [Required]
    [datevalidation]
    public DateTime Cumpleanos  { get; set; }

    [StringLength (20)]
    public String Contrasena {get; set;}

    public int Autorizada {get; set;}

    public String Nom_Usuario {get; set;}
    
    public String TipoDeUsuario {get; set;}
}

public class datevalidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        value = (DateTime)value;
        DateTime dt = new DateTime(1962, 1, 1, 12, 0, 0);

        if (dt.CompareTo(value) < 0)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult("No se aceptan nacimientos antes de 1961");
        }
    }
}