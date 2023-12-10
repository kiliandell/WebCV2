using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCV2.Controllers;
using WebCV2.models;

namespace WebCV.Pages
{
    public class formationsModel : PageModel
    {
        private readonly DBManagement _context;

        public formationsModel(DBManagement context)
        {
            _context = context;
        }

        public List<FormationsModel> Formations { get; set; }

        public async Task OnGet()
        {
            Formations = await _context.GetAllFormations();
        }
    }
}
