using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditCarreraModel : PageModel
    {
        public List<string> Modalidades = new List<string>();
        [BindProperty]
        public Carrera CarreraCur { get; set; }
        public void OnGet(int id)
        {
            Modalidades = OpcionesModalidad.lista;

            foreach (var carrera in DatosCompartidos.ListCarreras)
            {
                if (carrera.Id == id)
                {
                    CarreraCur = carrera;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach (var carrera in DatosCompartidos.ListCarreras)
            {
                if (carrera.Id == CarreraCur.Id)
                {
                    carrera.Nombre = CarreraCur.Nombre;
                    carrera.Modalidad = CarreraCur.Modalidad;
                    carrera.DuracionAnios = CarreraCur.DuracionAnios;
                    carrera.TituloOtorgado = CarreraCur.TituloOtorgado;
                    break;
                }
            }
            return RedirectToPage("TablaCarreras");
        }

    }
}