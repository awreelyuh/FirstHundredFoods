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
    public class IndexModel : PageModel
    {
        private readonly FirstHundredFoods.Data.FirstHundredFoodsContext _context;

        public IndexModel(FirstHundredFoods.Data.FirstHundredFoodsContext context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Foods != null)
            {
                Food = await _context.Foods.ToListAsync();
            }
        }
    }
}
