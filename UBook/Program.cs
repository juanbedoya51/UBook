using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UBook;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorBootstrap(); // Add this line


builder.Services.AddSingleton(new HttpClient
{
    ////BaseAddress = new Uri("http://localhost/Ubook/")
    BaseAddress = new Uri("https://ubook-php-api.000webhostapp.com/Ubook/")
});
await builder.Build().RunAsync();
