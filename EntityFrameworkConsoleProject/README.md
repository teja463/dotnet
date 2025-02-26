# Entity Framework

> [Video Tutorial for all this solution](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oX7uTkjYwvCJDG2qhcSzwZ6)

- There are two approaches for creating the Entities Entity Framework. 
- First one is Entity first approach. First you create the entities along with relationship between them using the navigation classes and then use the commands `Add-Migration` to create the migration file where you can review the sql script that is going to be created once you are fine then execute `Update-Database` to create the tables on the SQL Server
- Second approach is to create the entities based on the existing database schema,

> Have the local SQL Server Database up and running

## Console Project Examples

### First Approach

> Create a Schema with the name *ContosoPizza* for the project to run

- Create the entity classes and their navigation entities, create the DBContext class.
- Once you have all the entities mapping ready then use the `Add-Migration` command to create the migration script and use the `Update-Database` command to create the actual tables on the SQL server
- Tools -> NuGet Package Manger -> Package Manger Console and execute below command
	`Add-Migration give-desired-name-here` this is to create the SQL script for the DB classes, it will be generated in Migrations folder. Verify the tables and execute `Update-Database` command
- This will create the tables on the DB server configured in the data source url. Data source URL is configured in `MyDBContext.cs`
- `Update-Database` command to create the tables on the server


### Second Approach

- In this approach you create the DB tables first, using DBeaver SQL Management studio
- Once you have the tables ready we can use the below script to create the entities and DBContext class automatically using Scaffolding
- Tools -> NuGet Package Manger -> Package Manger Console, from the default project dropdown select the project you want to have entities created and execute below command
`Scaffold-DbContext "Data Source=.;Initial Catalog=ContosoPizza2;Integrated Security=True;TrustServerCertificate=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -Verbose`
- This will create the entities and DBContext class
- By Default it will add the column metadata and entity one-one or one-many mapping inside the DbContext class, but if you want to have them inside the entity class itself pass the argument `-DataAnnotations` at the end


## Razor Pages Project with EF Core

- Create an Razor Pages project
- Make sure the schema and tables are created in the DB
- Use the Second Approach method to create the entities and the DBContext class
- Move the hardcoded SQL Query string from OnConfigure in DBContext class to the appsettings.json and inject it in Program.cs via config
- Now we will use the Razor Pages Crud Scaffolding option to generate the CRUD pages for User entity
- Create a UserCrud Folder inside Pages rolder, right click on that folder -> Add -> Scaffold Items -> Razor Pages -> Razor Pages Crud -> Select User Entity
- Now this will create the CRUD pages for user entity automatically
- Now we have linked the EF Core with Razoar pages

