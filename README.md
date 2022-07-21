# Dino Daycare

Keep in touch with your little one while they are learning and growing at Dino Daycare.

## Technologies Used
- .NET Core 6.0
- SQlite
- Entity Framework Core
- ASP.NET

## Patterns Used
- MVC
- Code first database creation
- CRUD

## How to run
1. Clone
1. Navigate to where you cloned the project
1. Navigate to `src/` by doing `cd src/`
1. Run `dotnet build`
1. Run `dotnet run`
1. Open link in browser
1. (If you need to update the database: `dotnet ef database update` (To install EF CLI tool: https://docs.microsoft.com/en-us/ef/core/cli/dotnet))

## Requirements
1. You must create at least one class, then create at least one object of that class and populate it with data. You must use or display the data in your application.
   - [Student Model](src/Models/Student.cs) & [Populating it with data](https://github.com/kirakirakira/daycare/blob/ee35f50d2aa8fc7efb9ef4b47f7ce8db145b7dea/src/Controllers/StudentController.cs#L23)
1. Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application.
   - [Student Controller methods](src/Controllers/StudentController.cs)
   - [Daily Report Controller methods](src/Controllers/DailyReportController.cs)
1. Create 3 or more unit tests for your application.
   - [Tests](tests/)
1. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.
   - [Index method with search string](https://github.com/kirakirakira/daycare/blob/29cc1053525edcb020d2c062bb68270895178be6/src/Controllers/DailyReportController.cs#L21-L34)
1. Use a LINQ query to retrieve information from a data structure (such as a list or array) or file
   - [Searching for student](https://github.com/kirakirakira/daycare/blob/e6953ac5c6624558c7e6ba0e7e00ed4f1a21fbcb/src/Controllers/StudentController.cs#L31)

## Features
1. CRUD - Create, read, update, delete student daily reports

## To Do
See Issues tab.
