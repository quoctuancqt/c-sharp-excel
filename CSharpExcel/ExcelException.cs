namespace CSharpExcel
{
    using System;

    public class ExcelException : Exception
    {
        public ExcelException(string message) : base(message)
        {
        }

        public ExcelException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
