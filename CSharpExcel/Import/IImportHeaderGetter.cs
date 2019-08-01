namespace CSharpExcel.Import
{
    using System.Reflection;

    public interface IImportHeaderGetter
    {
        PropertyInfo[] Get<T>();
    }
}
