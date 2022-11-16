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

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<FirstHundredFoodsContext>();
                context.Database.EnsureCreated();
                // DbInitializer.Initialize(context);
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}