using Microsoft.EntityFrameworkCore; // Imports the Entity Framework Core library for database operations.
using BCS.JobProcessing.Host.Models; // Imports the models from the BCS.JobProcessing.Host.Models namespace.
using Microsoft.AspNetCore.Hosting;  // Imports the ASP.NET Core hosting library.
using Microsoft.AspNetCore.Server.Kestrel.Core; // Imports the Kestrel server core library.
using System.Configuration;          // Imports the System.Configuration namespace for configuration management.
using Microsoft.AspNetCore.Diagnostics; // Imports the ASP.NET Core diagnostics library for handling exceptions.
using System.Net;                       // Imports the System.Net namespace for network-related operations.
using Swashbuckle.AspNetCore;        // Imports the Swashbuckle library for Swagger integration.
using Serilog;                       // Imports the Serilog library for logging.

namespace BCS.JobProcessing.Host // Defines the namespace for the application.
{
    public class Program // Defines the Program class, which contains the entry point of the application.
    {
        public static void Main(string[] args) // The Main method is the entry point of the application.
        {
           

            try // Starts a try block to catch any exceptions that occur during application startup.
            {
                Log.Information("Starting up the application");

                var builder = WebApplication.CreateBuilder(args); // Creates a new WebApplicationBuilder instance with the specified arguments. This is used to configure and build the web application.

                // Add Serilog
                builder.Host.UseSerilog();

                // Configure Serilog
                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}")
                    .CreateLogger();


                // Configure Kestrel to use HTTP/1.1 and HTTP/2
                builder.WebHost.ConfigureKestrel(serverOptions => // Configures the Kestrel web server.
                {
                    serverOptions.ListenAnyIP(7141, listenOptions => // Listens on port 7141 for any IP address.
                    {
                        listenOptions.UseHttps(); // Enables HTTPS for the server to ensure secure communication.
                        listenOptions.Protocols = HttpProtocols.Http1AndHttp2; // Sets the server to use both HTTP/1.1 and HTTP/2 protocols for better performance and compatibility.
                    });
                });

                // Add services to the container.
                ConfigureServices(builder.Services, builder.Configuration); // Calls the ConfigureServices method to add services to the DI container.

                var app = builder.Build(); // Builds the WebApplication instance, which is used to configure the HTTP request pipeline and run the application.

                app.UseExceptionHandler(options => // Configures a global exception handler to handle exceptions that occur during request processing.
                {
                    options.Run(async context => // Defines the action to take when an exception occurs.
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.BadRequest; // Sets the response status code to 400 (Bad Request) to indicate a client error.
                        context.Response.ContentType = "application/json"; // Sets the response content type to JSON.
                        var exception = context.Features.Get<IExceptionHandlerFeature>(); // Gets the exception details from the context.
                        if (exception != null) // Checks if an exception occurred.
                        {
                            var message = $"{exception.Error.Message}"; // Gets the exception message.
                            await context.Response.WriteAsync(message).ConfigureAwait(false); // Writes the exception message to the response.
                        }
                    });
                });

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment()) // Checks if the application is in development mode.
                {
                    app.UseSwagger(); // Enables the Swagger middleware to serve the generated Swagger as a JSON endpoint.
                    app.UseSwaggerUI(c => // Enables the Swagger UI middleware to serve the Swagger UI.
                    {
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BCS.JobProcessing.Host API V1"); // Specifies the Swagger JSON endpoint.
                    });
                }

                app.UseHttpsRedirection(); // Redirects HTTP requests to HTTPS to ensure secure communication.
                app.UseAuthorization(); // Adds authorization middleware to the request pipeline to handle authorization.

                // Use CORS policy
                app.UseCors("AllowBlazorClient"); // Adds the CORS policy to the request pipeline to allow cross-origin requests from the specified origins.
                app.UseRouting(); // Adds routing middleware to the request pipeline to route requests to the appropriate endpoints.
                app.UseEndpoints(endpoints => // Configures the endpoints for the application.
                {
                    endpoints.MapControllers(); // Maps the controller endpoints to handle HTTP requests.
                });

                app.Run(); // Runs the application and starts listening for incoming HTTP requests.
                Log.Information("Host Started"); // Logs the message "Host Started" after the application has started successfully.

            }
            catch (Exception ex) // Catches any exceptions that occur during application startup.
            {
                Log.Fatal(ex, "Application start-up failed");
                throw; // Rethrows the exception to terminate the application.
            }
            finally
            {
                Log.CloseAndFlush(); // Ensures that all log events are flushed and the logger is properly closed.
            }
        }

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration) // Configures the services for the application.
        {
            services.AddCors(options => // Adds CORS services to the DI container to handle cross-origin requests.
            {
                options.AddPolicy("AllowBlazorClient", // Defines a CORS policy named "AllowBlazorClient".
                    builder =>
                    {
                        var allowedOrigins = configuration.GetSection("CorsSettings:AllowedOrigins").Get<string[]>(); // Gets the allowed origins from the configuration.
                        if (allowedOrigins == null || allowedOrigins.Length == 0) // Checks if the allowed origins are null or empty.
                        {
                            throw new InvalidOperationException("AllowedOrigins configuration is missing or empty."); // Throws an exception if the allowed origins are missing or empty.
                        }
                        builder.WithOrigins(allowedOrigins) // Sets the allowed origins for the CORS policy to enable cross-origin requests from these origins.
                               .AllowAnyHeader() // Allows any header in the CORS policy to enable requests with any headers.
                               .AllowAnyMethod(); // Allows any method in the CORS policy to enable requests with any HTTP methods (GET, POST, etc.).
                    });
            });

            services.AddControllers(); // Adds controller services to the DI container to handle HTTP requests.
            services.AddOpenApi(); // Adds OpenAPI services to the DI container to provide API documentation and testing.
            services.AddDbContext<OdsRev2025Context>( // Adds the DbContext for the application to handle database operations.
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))); // Configures the DbContext to use SQL Server with the specified connection string from the configuration.

            // Add Swagger services
            services.AddSwaggerGen(); // Adds Swagger services to the DI container without using OpenApiInfo.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // Configures the application.
        {
            app.UseCors("AllowBlazorClient"); // Adds the CORS policy to the request pipeline to allow cross-origin requests from the specified origins.

            app.UseRouting(); // Adds routing middleware to the request pipeline to route requests to the appropriate endpoints.
            app.UseEndpoints(endpoints => // Configures the endpoints for the application.
            {
                endpoints.MapControllers(); // Maps the controller endpoints to handle HTTP requests.
            });
        }
    }
}

/*
 * Key Concepts and Keywords
 * 

•	WebApplication.CreateBuilder(args): Creates a new instance of the WebApplicationBuilder class, which is used to configure and build the web application.
•	Kestrel: A cross-platform web server for ASP.NET Core.
•	ConfigureServices: A method used to add services to the dependency injection (DI) container.
•	IServiceCollection: Represents a collection of service descriptors.
•	IConfiguration: Represents a set of key/value application configuration properties.
•	WebApplication: Represents the web application and provides methods to configure and run it.
•	UseExceptionHandler: Adds middleware to handle exceptions globally.
•	UseHttpsRedirection: Adds middleware to redirect HTTP requests to HTTPS.
•	UseAuthorization: Adds middleware to handle authorization.
•	UseCors: Adds middleware to handle Cross-Origin Resource Sharing (CORS).
•	UseRouting: Adds middleware to route requests.
•	UseEndpoints: Adds middleware to configure endpoints.
•	MapControllers: Maps controller endpoints.
•	AddCors: Adds CORS services to the DI container.
•	AddControllers: Adds controller services to the DI container.
•	AddOpenApi: Adds OpenAPI services to the DI container.
•	AddDbContext: Adds a DbContext to the DI container.
•	UseSqlServer: Configures the DbContext to use SQL Server.

*/