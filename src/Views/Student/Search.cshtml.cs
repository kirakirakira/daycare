using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Daycare.Models;

namespace Daycare.Views
{
    public class SearchModel : PageModel
    {
        private readonly Context _context;

        public SearchModel(Context context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
    }
}
