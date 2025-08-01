using BCS.JobProcessing.Client.Models;
using BCS.JobProcessing.Client.Services;
using BCS.JobProcessing.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json; // Add this using directive
using MudBlazor;
using MudBlazor.Services;
internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");

        // Register HttpClient as a scoped service with the base address set to the job.processing.host web app
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7141") });

        // Register OdsService as a scoped service
        builder.Services.AddScoped<OdsService>();

        builder.Services.AddMudServices();
        // Build and run the WebAssemblyHost instance
        await builder.Build().RunAsync();
    }
   
}
