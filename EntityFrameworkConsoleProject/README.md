# Notes

- There are two approaches for creating the Entities Entity Framework. 
- First one is Entity first approach. First you create the entities along with relationship between them using the navigation classes and then use the commands `Add-Migration` to create the migration file where you can review the sql script that is going to be created once you are fine then execute `Update-Database` to create the tables on the SQL Server
- Second approach is to create the entities based on the existing database schema,

> Have the local SQL Server Database up and running

## First Approach

> Create a Schema with the name *ContosoPizza* for the project to run

- Tools -> NuGet Package Manger -> Package Manger Console and execute below command
	`Add-Migration give-desired-name-here` this is to create the SQL script for the DB classes, it will be generated in Migrations folder. Verify the tables and execute `Update-Database` command
- This will create the tables on the DB server configured in the data source url. Data source URL is configured in `MyDBContext.cs`
- `Update-Database` command to create the tables on the server


## Second Approach

