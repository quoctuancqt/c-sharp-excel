namespace CSharpExcel.Export
{
    using CSharpExcel.Attributes;
    using System.Collections.Generic;

    public interface IExportHeaderGetter
    {
        Dictionary<string, ExportInfoAttribute> Get<T>();
    }
}
