namespace Keyboard_Cats
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpClient("CatDb", client =>
            {
                client.BaseAddress = new Uri("https://api.petfinder.com/v2/oauth2/token");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);
            // APIKey = Configuration("Products:https://www.petfinder.com/");
            // Console.WriteLine(APIKey);
            //services.AddControllers();
        }
    }
}