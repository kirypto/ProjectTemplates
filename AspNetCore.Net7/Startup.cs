using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace kirypto.Template.AspNetCore.Net7;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // Add any services your application requires
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        if (env.IsDevelopment()) {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints => {
            endpoints.MapGet("/", async context => await context.Response.WriteAsync("Hello World!"));
        });
    }
}
