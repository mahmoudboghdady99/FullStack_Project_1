using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace FirstApp2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			var app = builder.Build();

			if(!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();
			app.UseAuthorization();

			

			app.UseEndpoints(endpoints =>
			{
                endpoints.MapControllerRoute(
				 name: "admin",
				 pattern: "{area:exists}/{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                name: "LandingPages",
                pattern: "{area:exists}/{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employees}/{action=List}/{id?}");

                endpoints.MapControllerRoute(
                name: "ali",
                pattern: "ali/{controller=Home}/{action=Index}/{id?}");


            });



	
		

			app.Run();
		}
	}
}
