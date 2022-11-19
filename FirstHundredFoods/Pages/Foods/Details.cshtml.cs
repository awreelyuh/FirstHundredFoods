using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstHundredFoods.Data;
using FirstHundredFoods.Models;

namespace FirstHundredFoods.Pages.Foods
{
    public class DetailsModel : PageModel
    {
        private readonly FirstHundredFoods.Data.FirstHundredFoodsContext _context;

        public DetailsModel(FirstHundredFoods.Data.FirstHundredFoodsContext context)
        {
            _context = context;
        }

      public Food Food { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Foods == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.FirstOrDefaultAsync(m => m.ID == id);
            if (food == null)
            {
                return NotFound();
            }
            else 
            {
                Food = food;
            }
            return Page();
        }
    }
}
