using System.ComponentModel.DataAnnotations;

namespace ModeladoTTHH.Models;

public class UsuarioDto
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "El campo Usuario es requerido")]
    [MinLength(4, ErrorMessage = "El campo Usuario debe tener 4 caracteres")]
    [RegularExpression("^[0-9]+$", ErrorMessage = "El campo Usuario debe contener solo números")]
    public string Usuario { get; set; }
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "El campo Contraseña es requerido")]
    public string Password { get; set; }
}