using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre no puede estar vacio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido no puede estar vacio")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "El DNI no puede estar vacio")]
        [Display(Name = "Numero de DNI")]
        public int? Dni { get; set; }

        [Required(ErrorMessage = "El email no puede estar vacio")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento no puede estar vacia")]
        [Display(Name = "Fecha de nacimiento")]
        public DateOnly? FechaNacimiento { get; set; }
    }
}