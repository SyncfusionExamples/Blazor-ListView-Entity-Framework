# Blazor-ListView-Entity-Framework

A quick getting started project to create an Entity Framework application with Blazor ListView component. The Blazor ListView Component is a list-like interface that allows you to select an item or multiple items. It represents the data in an interactive hierarchical structure across different layouts or views.

## pre-requisites

To get started with the application, we need to ensure the following software to be installed on the machine.

* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
* [NET Core SDK 3.1.3](https://dotnet.microsoft.com/download/dotnet-core/3.1)

>Note: .NET Core SDK 3.1.3 requires Visual Studio 2019 16.6 or later.

## How to run this application?

To run this application, clone the `Blazor-ListView-Entity-Framework` repository and then open the project or solution file in the Visual Studio 2019. 

* You need to change the Database connection string in the Shared/DataAccess/DataContext.cs file.

```
 optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Blazor-ListView-Entity-Framework\Shared\App_Data\NORTHWND.MDF';Integrated Security=True;Connect Timeout=30");

```

## Running application

Now, run the project in the Visual Studio. Then you will get the following output in the browser.

![Entity Framework in ListView](./Client/wwwroot/images/EFListView.gif)

## Support

Product support is available for through following mediums.

* Creating incident in Syncfusion [Direct-trac](https://www.syncfusion.com/support/directtrac/incidents?utm_source=npm&utm_campaign=filemanager) support system or [Community forum](https://www.syncfusion.com/forums/essential-js2?utm_source=npm&utm_campaign=filemanager).
* New [GitHub issue](https://github.com/syncfusion/ej2-javascript-ui-controls/issues/new).
* Ask your query in [Stack Overflow](https://stackoverflow.com/?utm_source=npm&utm_campaign=filemanager) with tag `syncfusion` and `ej2`.

## License

Check the license detail [here](https://github.com/syncfusion/ej2-javascript-ui-controls/blob/master/license).

## Changelog

Copyright 2020 Syncfusion, Inc. All Rights Reserved. The Syncfusion Essential Studio license and copyright applies to this distribution.