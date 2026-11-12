# Blazor-ListView-Entity-Framework

**Repository Description**
This repository contains a quick getting-started Blazor sample that demonstrates how to integrate the Syncfusion **Blazor ListView** component with **Entity Framework**.

The Blazor ListView component is a list-like UI component that allows users to select single or multiple items and display data in an interactive structure across different layouts and views. This project shows how database-driven data can be retrieved using Entity Framework and presented using the Blazor ListView component.

## Project Overview
The purpose of this project is to help developers understand how to build a **data-driven Blazor application** using Entity Framework in combination with the Syncfusion Blazor ListView component. It serves as a reference for binding database content to ListView controls and displaying it in an interactive UI.

## Features
- Integration of **Syncfusion Blazor ListView**
- Data access using **Entity Framework**
- Database-driven list rendering
- Support for single and multiple item selection
- Add and delete items through the ListView UI
- Blazor WebAssembly hosted application structure (.NET 10)

## Prerequisites
Ensure the following requirements are met before running this project:
- Visual Studio Code or Visual Studio 2022 (with the .NET 10 workload)
- .NET 10 SDK
- SQL Server LocalDB (for the sample database)
- Syncfusion Blazor packages
- Valid Syncfusion license key (if required)

## Installation and Running the Application

### Clone and Open the Project
1. Clone the repository.
2. Open the solution file (EFListView.sln) in Visual Studio 2022 or Visual Studio Code.

### Configure the Database Connection
Update the database connection string in the following file:
`EFListView/Shared/DataAccess/DataContext.cs`
Example connection string:
```csharp
optionsBuilder.UseSqlServer(
  @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename='D:\Blazor-ListView-Entity-Framework\EFListView\Shared\App_Data\NORTHWND.MDF';
    Integrated Security=True;
    Connect Timeout=30");
```

### Run the Application
1. Build the solution.
2. Run the Server project.
3. Open the application in the browser to view the ListView rendered with data from the database.

## Usage
Run the application to explore how data from Entity Framework is displayed using the Blazor ListView. You can click a list item to select it, use the **Add** button to insert a new product into the database, and use the **Delete the selected item** button to remove the selected product.

## Documentation
- General Syncfusion documentation:
https://help.syncfusion.com/
- Blazor Introduction:
https://blazor.syncfusion.com/documentation/introduction
- Blazor ListView Getting Started:
https://blazor.syncfusion.com/documentation/listview/getting-started

## Troubleshooting
- Ensure the database file path in the connection string is valid.
- Verify that SQL Server LocalDB is installed and accessible.
- Rebuild the solution if Entity Framework or ListView components fail to load.
- Check browser and application logs for runtime errors.

## Support
For detailed API references, configuration options, and advanced usage examples, refer to the Syncfusion Blazor ListView documentation links provided above.