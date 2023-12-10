using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCV2.Controllers;
using WebCV2.models;

namespace WebCV.Pages
{
    public class experiencesModel : PageModel
    {
        private readonly DBManagement _context;

        public experiencesModel(DBManagement context)
        {
            _context = context;
        }

        public List<ExperiencesModel> Experiences { get; set; }

        public async Task OnGet()
        {
            Experiences = await _context.GetAllExperiences();
        }
    }
}
