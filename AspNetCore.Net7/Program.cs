using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace kirypto.Template.AspNetCore.Net7;

public static class Program {
    public static void Main(string[] args) {
        Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                .Build()
                .Run();
    }
}
