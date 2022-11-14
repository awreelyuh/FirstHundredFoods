using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstHundredFoods.Models;

namespace FirstHundredFoods.Data
{
    public class FirstHundredFoodsContext : DbContext
    {
        public FirstHundredFoodsContext (DbContextOptions<FirstHundredFoodsContext> options)
            : base(options)
        {
        }

        public DbSet<FirstHundredFoods.Models.Baby> Baby { get; set; } = default!;
    }
}
