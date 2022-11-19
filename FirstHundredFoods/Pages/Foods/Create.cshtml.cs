using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FirstHundredFoods.Data;
using FirstHundredFoods.Models;

namespace FirstHundredFoods.Pages.Foods
{
    public class CreateModel : PageModel
    {
        private readonly FirstHundredFoods.Data.FirstHundredFoodsContext _context;

        public CreateModel(FirstHundredFoods.Data.FirstHundredFoodsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Food Food { get; set; }
        

        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Foods.Add(Food);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
