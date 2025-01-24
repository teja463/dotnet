# ASP.NET Core

## Intro

- Till ASP.NET 4.xx .NET apps can only be run on Windows
- Microsoft overhauled .NET framework and made it open source, which can run on any OS
- They call it ASP.NET Core, and they released version 1.0, 2.0 etc
- Earlier .NET Framework runs only on IIS, but this .NET Core can run on IIS, Apache, Docker etc, making it more modular

## Installation

- You have to install .NET SDK, the latest version is 9.0
- If you just want to run the .NET apps then you  can just install the .NET Runtime instead of full SDK, similar to JDK vs JRE
- You can develop apps using either VS Code or Visual Studio 2022

## Creating a Web Application

- You can create different type of ASP.NET Core projects
- Class Library -> for set of classes
- ASP.NET Core empyt -> if you want to set up everything from scratch
- ASP.NET Core Web MVC -> For using MVC model, project comes with controllers, views, wwwroot other folders etc
- ASP.NET Core Razor Pages -> For page centric design you can use this project type

## ASP.NET Core Project File

- When you create a project it creates a file with `.csproj` all settings can be found here
- If you want to edit this file from VS right click on the project and click Edit Project File

## Main Method

- .NET Core web app starts as a console app and then we add configuration to make to work like a web app
- This is why you see the Program.cs which is the starting point of the app
  
## In Process Hosting

- App is hosted within the IIS, for Development it will be IIS express, for production it is IIS

## Out Of Process Hosting

- You can host it outside of IIS also, by default if you runt he app from command line then it will be OutOfProcess Hosting
- This will run on a server called **Kestral**
- You can change the behavior by right clicking on the project -> edit project file and write below 

```
  <AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
  <AspNetCoreHostingModel>OutOfProcess</AspNetCoreHostingModel>
```

## Launchsettings.json

- Has the information about launch configuration of the project like configuring launch profiles like which port to use etc
- We can also configure environment variables in this file
- This is only for Development not used in build and deployment

## appsettings.json

- Similar to application.properties in SpringBoot
- You can have .env like appsettings.Development.json specific to each environment
- Similar to SpringBoot you can pass and override values in appsettings.json by passing values from below in following order
  - appsettings.json
  - User Secrets
  - Environment variables
  - Command Line
- The values can be read from `IConfiguration` class like autowire the `IConfiguration config` then use `config["mykey"]
- To override the values form commnad like use `dotnet run MyKey="From CMD"`

## Middleware in ASP.NET Core

