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
    public class DeleteModel : PageModel
    {
        private readonly FirstHundredFoods.Data.FirstHundredFoodsContext _context;

        public DeleteModel(FirstHundredFoods.Data.FirstHundredFoodsContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Baby Baby { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Baby == null)
            {
                return NotFound();
            }

            var baby = await _context.Baby.FirstOrDefaultAsync(m => m.ID == id);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Baby == null)
            {
                return NotFound();
            }
            var baby = await _context.Baby.FindAsync(id);

            if (baby != null)
            {
                Baby = baby;
                _context.Baby.Remove(Baby);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
