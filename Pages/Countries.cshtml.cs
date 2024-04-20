using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CountriesModel : PageModel
    {
        public List<string> Countries { get; set; }

        public void OnGet()
        {
            Countries = new List<string> {"USA", "UK", "Germany", "France", "Italy"};
        }
    }
}
