# Blazor ListView with Entity Framework

## Project Overview
The purpose of this project is to help developers understand how to build a **data‑driven Blazor application** using Entity Framework in combination with the Syncfusion [Blazor ListView](https://www.syncfusion.com/blazor-components/blazor-listview) component. It serves as a reference for binding database content to ListView controls and displaying it in an interactive UI.

## Features
- Integration of **Syncfusion Blazor ListView**
- Data access using **Entity Framework**
- Database‑driven list rendering
- Support for single and multiple item selection
- Hierarchical data presentation in ListView
- Blazor‑based application structure

## Prerequisites
Ensure the following requirements are met before running this project:
- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework
- SQL Server LocalDB (for the sample database)

## Installation

### Clone the Repository
Clone the repository and navigate to the project directory:
```bash
git clone https://github.com/SyncfusionExamples/Blazor-ListView-Entity-Framework.git
```

### Configure Database Connection
Update the database connection string in the following file:
```bash
Shared/DataAccess/DataContext.cs
```
Example connection string:
```C#
optionsBuilder.UseSqlServer(
  @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename='D:\Blazor-ListView-Entity-Framework\Shared\App_Data\NORTHWND.MDF';
    Integrated Security=True;
    Connect Timeout=30");
```
Ensure the database file path matches your local environment.

### Running the Application
**Visual Studio 2022**

1. Open the solution file:

   `EFListView.sln`

2. Restore the NuGet packages by rebuilding the solution.
3. Set the startup project to:

   `EFListView.Server`

4. Build the solution.
5. Run the application using `Ctrl+F5`.
6. Open the application URL displayed by Visual Studio after launch.
7. Verify that the ListView displays product records retrieved through Entity Framework and the Web API.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the server project directory:

```bash
cd Server
```

4. Restore the NuGet packages:

```bash
dotnet restore
```

5. Run the project:

```bash
dotnet run
```

6. Open the local URL displayed in the terminal after the application starts.
7. Verify that the ListView displays product records retrieved through Entity Framework and the Web API.

## Project Structure

- `Client/Pages/Index.razor` — Renders the ListView and handles product loading, selection, addition, and deletion.
- `Server/Controllers/ProductsController.cs` — Provides the Web API operations for retrieving, adding, and deleting products.
- `Shared/DataAccess/DataContext.cs` — Configures the Entity Framework context and SQL Server LocalDB connection.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation: [Blazor ListView getting started documentation](https://blazor.syncfusion.com/documentation/listview/getting-started)

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.