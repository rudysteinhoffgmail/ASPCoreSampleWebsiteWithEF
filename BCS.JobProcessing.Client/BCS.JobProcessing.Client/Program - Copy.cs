//using BCS.JobProcessing.Client;
//using BCS.JobProcessing.Client.Services;

//using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using MudBlazor.Services;

//internal class Program
//{
//    private static void Main(string[] args)
//    {


//        // Create a new WebApplicationBuilder instance
//        var builder = WebAssemblyHostBuilder.CreateDefault(args);
//        var app = builder.Build();
//        builder.RootComponents.Add<App>("#app");

//        // Add MudBlazor services to the service collection
//        builder.Services.AddMudServices();

//        // Add Razor Components services to the service collection
//        builder.Services.AddRazorComponents()
//            .AddInteractiveServerComponents() // Add support for interactive server components
//            .AddInteractiveWebAssemblyComponents(); // Add support for interactive WebAssembly components

//        // Register HttpClient as a scoped service with the base address set to the application's base URI
//        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(sp.GetRequiredService<NavigationManager>().BaseUri) });

//        // Register OdsvsGutService and LoadingService as scoped services
//        builder.Services.AddScoped<OdsService>();
//        // builder.Services.AddScoped<LoadingService>();
//        //BCS.JobProcessing.Client.Services.
//        // Build the WebApplication instance
        

//        // Add custom error handling middleware to the request pipeline
//        //app.UseMiddleware<ErrorHandlingMiddleware>();

//        // Add custom CSRF logging middleware to the request pipeline
//        //app.UseMiddleware<CsrfLoggingMiddleware>();

//        // Configure the HTTP request pipeline based on the environment
//        if (app.Environment.IsDevelopment())
//        {
//            // Enable WebAssembly debugging in development environment
//            app.UseWebAssemblyDebugging();
//        }
//        else
//        {
//            // Use exception handler and HSTS in production environment
//            //app.UseExceptionHandler("/Error", createScopeForErrors: true);
//            //app.UseHsts();
//        }

//        //// Redirect HTTP requests to HTTPS
//        //app.UseHttpsRedirection();

//        // Enable antiforgery protection
//        //app.UseAntiforgery();

//        // Map static assets
//        //app.MapStaticAssets();

//        // Map Razor components with support for interactive server and WebAssembly render modes
//        app.MapRazorComponents<App>()
//        .AddInteractiveServerRenderMode()
//        .AddInteractiveWebAssemblyRenderMode();
//        //.AddAdditionalAssemblies(typeof(BCS.JobProcessing.Client._Imports).Assembly);

//        // Run the application
//        await builder.Build().RunAsync();
//    }
//}