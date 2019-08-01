namespace CSharpExcel.Services
{
    public abstract class BaseExportService : IBaseExportService
    {
        protected abstract string ExecuteExport<T>(string fileName, T[] models) where T : class;

        public virtual string Export<T>(string fileName, T[] models) where T :class
        {
            return ExecuteExport(fileName, models);
        }
    }
}
