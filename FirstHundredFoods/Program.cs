using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FirstHundredFoods.Data;
namespace FirstHundredFoods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<FirstHundredFoodsContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("FirstHundredFoodsContextSQLite") ?? 
                throw new InvalidOperationException("Connection string 'FirstHundredFoodsContextSQLite' not found.")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}