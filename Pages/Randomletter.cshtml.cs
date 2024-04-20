using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class RandomletterModel : PageModel
    {
        public char RandomLetter { get; set; }
        public string RestName { get; set; }
        public void OnGet()
        {
            Random random = new Random();
            int randNumber = random.Next(0, 6);
            RandomLetter = (char)('a' + randNumber);
            RestName = GetRestaurantNameByLetter(RandomLetter);
        }
        private string GetRestaurantNameByLetter(char letter)
        {
            
            return letter switch
            {
                'a' => "Amazing Restaurant",
                'b' => "Best Bites",
                'c' => "Culinary Delights",
                'd' => "Delicious Desserts",
                'e' => "Excellent Eats",
                'f' => "Fine Food",
                'g' => "Great Gourmet",
            };
        }
    }
}
