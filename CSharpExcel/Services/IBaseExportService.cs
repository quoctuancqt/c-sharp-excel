﻿namespace CSharpExcel.Services
{
    public interface IBaseExportService
    {
        string Export<T>(string fileName, T[] models) where T : class;
    }
}
