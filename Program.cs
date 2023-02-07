using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Keyboard_Cats.Data;
using Keyboard_Cats.Areas.Identity.Data;
using Keyboard_Cats.Models;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Keyboard_CatsContextConnection") ?? throw new InvalidOperationException("Connection string 'Keyboard_CatsContextConnection' not found.");

builder.Services.AddDbContext<Keyboard_CatsContext>(options =>
    options.UseSqlServer(connectionString));

//services builder for multiple roles.
/*builder.Services.AddIdentity<Keyboard_CatsUser, IdentityRole>().AddEntityFrameworkStores<Keyboard_CatsContext>().AddDefaultTokenProviders();*/

//initial services builder
builder.Services.AddDefaultIdentity<Keyboard_CatsUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Keyboard_CatsContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();



static void Main(string[] args)

{
    // Generate Authorize Access Token to authenticate REST Web API.  
   // string oAuthInfo = Program.GetAuthorizeToken().Result;

    // Process response access token info.  

    // Call REST Web API method with authorize access token.  
  //  string responseObj = Program.GetInfo(obj.access_token).Result;

    // Process Result. 


    // IWebHost webHost =  WebHostBuilder(args).Build();

    //CallSomeRemoteService(webHost.Services);

    //  webHost.Run();

}

static void CallSomeRemoteService(IServiceProvider serviceProvider)

{

    var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();

    var httpClient = httpClientFactory.CreateClient("OpenBreweryDb");

    var response = httpClient.GetAsync("?by_state=Massachusetts&by_name=night").Result;

    if (response.IsSuccessStatusCode)

    {

        var breweries = response.Content.ReadAsAsync<List<Cat>>().Result;

    }

    static async Task<string> GetAuthorizeToken()
    {
        // Initialization.  
        string responseObj = string.Empty;
        
            // Posting.  
            using (var client = new HttpClient())
        {
            // Setting Base address.  
            client.BaseAddress = new Uri("http://localhost:3097/");

            // Setting content type.  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
                // Initialization.  
                HttpResponseMessage response = new HttpResponseMessage();
            List<KeyValuePair<string, string>> allIputParams = new List<KeyValuePair<string, string>>();

            // Convert Request Params to Key Value Pair.  
             
                // URL Request parameters.  
                HttpContent requestParams = new FormUrlEncodedContent(allIputParams);

            // HTTP POST  
            response = await client.PostAsync("Token", requestParams).ConfigureAwait(false);

            // Verification  
            if (response.IsSuccessStatusCode)
            {
                // Reading Response.  
                
                }
        }

        return responseObj;
    }

    static async Task<string> GetInfo(string authorizeToken)
    {
        // Initialization.  
        string responseObj = string.Empty;

        // HTTP GET.  
        using (var client = new HttpClient())
        {
            // Initialization  
            string authorization = authorizeToken;

            // Setting Authorization.  
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authorization);

            // Setting Base address.  
            client.BaseAddress = new Uri("http://www.api.petfinder.com/v2");

            // Setting content type.  
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Initialization.  
            HttpResponseMessage response = new HttpResponseMessage();

            // HTTP GET  
            response = await client.GetAsync("api/WebApi").ConfigureAwait(false);

            // Verification  
            if (response.IsSuccessStatusCode)
            {
                // Reading Response.  
                  
                }
        }

        return responseObj;
    }



}