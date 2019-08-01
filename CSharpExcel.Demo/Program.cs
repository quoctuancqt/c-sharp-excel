namespace CSharpExcel.Demo
{
    using Bogus;
    using CSharpExcel.Services;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Hosting.Internal;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddHttpContextAccessor();
            services.AddSingleton<IHostingEnvironment>(new HostingEnvironment { WebRootPath = AppDomain.CurrentDomain.BaseDirectory });
            services.UseCSharpExcel();

            var serviceProvider = services.BuildServiceProvider();

            var excelService = serviceProvider.GetService<IExcelService>();
            var exportService = serviceProvider.GetService<IExcelCommonExportService>();

            Console.WriteLine("Fake data to export");
            var accountFaker = new Faker<AccountInfo>()
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Email, f => f.Internet.Email());

            var accounts = accountFaker.Generate(10);

            Console.WriteLine("Process export");
            var path = exportService.Export("demo.xlsx", accounts.ToArray());

            Console.WriteLine($"File has been exported at {path}");

            Console.WriteLine("Process import file");
            var importData = excelService.ReadFile<AccountInfo>(path);

            foreach (var data in importData)
            {
                Console.WriteLine($"First Name: {data.FirstName}, Last Name: {data.LastName}");
            }

            Console.ReadKey();
        }
    }
}
