using Gachlab.Consulting.Site;
using Gachlab.Consulting.Site.Localization;
using Gachlab.Consulting.Site.Options;
using Gachlab.Consulting.Site.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.Configure<SiteOptions>(
    builder.Configuration.GetSection(SiteOptions.SectionName));
builder.Services.AddSingleton<ISiteCopyProvider, SiteCopyProvider>();
builder.Services.AddScoped<UiCulture>();

await builder.Build().RunAsync();
