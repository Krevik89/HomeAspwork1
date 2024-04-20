using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class RestaurantModel : PageModel
    {
        public string RestaurantName { get; private set; }
        public string CuisineType { get; private set; }

        public void OnGet()
        {
            RestaurantName = "Peperonina";
            CuisineType = "Italian";
        }
    }
}
