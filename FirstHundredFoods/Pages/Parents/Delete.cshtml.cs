using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstHundredFoods.Data;
using FirstHundredFoods.Models;

namespace FirstHundredFoods.Pages.Parents
{
    public class DeleteModel : PageModel
    {
        private readonly FirstHundredFoods.Data.FirstHundredFoodsContext _context;

        public DeleteModel(FirstHundredFoods.Data.FirstHundredFoodsContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Parent Parent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }

            var parent = await _context.Parents.FirstOrDefaultAsync(m => m.ID == id);

            if (parent == null)
            {
                return NotFound();
            }
            else 
            {
                Parent = parent;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }
            var parent = await _context.Parents.FindAsync(id);

            if (parent != null)
            {
                Parent = parent;
                _context.Parents.Remove(Parent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
