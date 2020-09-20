using System;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeManagement.App.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = new Uri("https://localhost:44310/"));
            builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client => client.BaseAddress = new Uri("https://localhost:44310/"));
            builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client => client.BaseAddress = new Uri("https://localhost:44310/"));

            await builder.Build().RunAsync();
        }
    }
}
