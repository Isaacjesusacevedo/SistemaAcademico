using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Alumnos
{
    public class EditAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno Alumnos { get; set; }
        public void OnGet(int id)
        {
            foreach (var alumno in DatosCompartidos.ListaAlumnos)
            {
                if (alumno.Id == id)
                {
                    Alumnos = alumno;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            if (DatosCompartidos.ListaAlumnos.Any(alumno => alumno.Email == Alumnos.Email && alumno.Id != Alumnos.Id))
            {
                ModelState.AddModelError("oAlumno.Email", "El correo electrónico ya está registrado.");
            }

            if (DatosCompartidos.ListaAlumnos.Any(alumno => alumno.Dni == Alumnos.Dni && alumno.Id != Alumnos.Id))
            {
                ModelState.AddModelError("oAlumno.Dni", "El DNI ya está registrado.");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach (var alumno in DatosCompartidos.ListaAlumnos)
            {
                if (alumno.Id == Alumnos.Id)
                {
                    alumno.Nombre = Alumnos.Nombre;
                    alumno.Apellido = Alumnos.Apellido;
                    alumno.Dni = Alumnos.Dni;
                    alumno.Email = Alumnos.Email;
                    alumno.FechaNacimiento = Alumnos.FechaNacimiento;
                    break;

                }
            }
            return RedirectToPage("TablaAlumnos");
        }
    }
}