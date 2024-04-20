using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeAspwork1.Pages;

public class IndexModel : PageModel
{
    
    public int CurrentDayOfYear { get; set; }

    public void OnGet()
    {
        CurrentDayOfYear = DateTime.Now.DayOfYear;
    }
}
