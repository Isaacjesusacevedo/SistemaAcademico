using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Alumnos
{
    public class AlumnosModel : PageModel
    {
        public List<Alumno> listaAlumnosMotrar = new List<Alumno>();
        public void OnGet()
        {
            listaAlumnosMotrar = DatosCompartidos.ListaAlumnos;
        }
    }
}