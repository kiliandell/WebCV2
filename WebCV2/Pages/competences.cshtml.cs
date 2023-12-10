using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCV2.Controllers;
using WebCV2.models;

namespace WebCV.Pages
{
    public class competencesModel : PageModel
    {
        private readonly DBManagement _context;

        public competencesModel(DBManagement context)
        {
            _context = context;
        }

        public List<CompetencesModel> Competences { get; set; }

        public async Task OnGet()
        {
            Competences = await _context.GetAllCompetences();
        }
    }
}
