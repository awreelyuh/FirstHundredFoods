using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstHundredFoods.Data;
using FirstHundredFoods.Models;

namespace FirstHundredFoods.Pages.Babies
{
    public class DetailsModel : PageModel
    {
        private readonly FirstHundredFoods.Data.FirstHundredFoodsContext _context;

        public DetailsModel(FirstHundredFoods.Data.FirstHundredFoodsContext context)
        {
            _context = context;
        }

      public Baby Baby { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Babies == null)
            {
                return NotFound();
            }

            var baby = await _context.Babies.FirstOrDefaultAsync(m => m.ID == id);
            if (baby == null)
            {
                return NotFound();
            }
            else 
            {
                Baby = baby;
            }
            return Page();
        }
    }
}
