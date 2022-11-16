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
    public class IndexModel : PageModel
    {
        private readonly FirstHundredFoods.Data.FirstHundredFoodsContext _context;

        public IndexModel(FirstHundredFoods.Data.FirstHundredFoodsContext context)
        {
            _context = context;
        }

        public IList<Baby> Baby { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Babies != null)
            {
                Baby = await _context.Babies
                .Include(b => b.Parent).ToListAsync();
            }
        }
    }
}
