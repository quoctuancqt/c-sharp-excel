# CSharp Excel

A powerful library to help you import/export excel using Dotnet Core

## Installation

```bash
Install-Package CSharpExcel -Version 1.0.0
```

## Usage

Register CSharpExcel into your project.
```c#
public void ConfigureServices(IServiceCollection services)
{
	services.UseCSharpExcel();
}
```
Create your model and use ExportInfo Attribute for exporting, Import Attribute for importing
```c#
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
```
Using IExcelCommonExportService for exporting to excel file using Export method.
```c#
var path = exportService.Export([FILE NAME], [DATA]);
```
Using IExcelService for reading data from an excel file.
```c#
var data = excelService.ReadFile<AccountInfo>([PATH TO FILE]);
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
