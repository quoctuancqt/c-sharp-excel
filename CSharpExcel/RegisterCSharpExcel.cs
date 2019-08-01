namespace CSharpExcel
{
    using CSharpExcel.Export;
    using CSharpExcel.Import;
    using CSharpExcel.Services;
    using Microsoft.Extensions.DependencyInjection;

    public static class RegisterCSharpExcel
    {
        public static IServiceCollection UseCSharpExcel(this IServiceCollection services)
        {
            services.AddSingleton<IFileManager, FileManager>();

            services.AddSingleton<IExcelService, ExcelService>();

            services.AddSingleton<IExcelCommonExportService, ExcelCommonExportService>();

            services.AddSingleton<IExportHeaderGetter, ExportHeaderGetter>();

            services.AddSingleton<IImportHeaderGetter, ImportHeaderGetter>();

            return services;
        }
    }
}
