namespace CSharpExcel.Demo
{
    using CSharpExcel.Attributes;

    public class AccountInfo
    {
        [ExportInfo(Header = "First Name")]
        [Import]
        public string FirstName { get; set; }
        [ExportInfo(Header = "Last Name")]
        [Import]
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}