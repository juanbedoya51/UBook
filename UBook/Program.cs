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
    //BaseAddress = new Uri("http://localhost/Ubook/")
    BaseAddress = new Uri("https://juanbedoya51-001-site1.itempurl.com/")
});
await builder.Build().RunAsync();
