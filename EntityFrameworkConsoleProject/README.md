# Notes


## Setup

* Have the local SQL Server Database up and running
* Create a Schema with the name *ContosoPizza* for the project to run

## Creating the DB SCript

* Tools -> NuGet Package Manger -> Package Manger Console and execute below command
	`Add-Migration give-desired-name-here` this is to create the SQL script for the DB classes, it will be generated in Migrations folder. Verify the tables and execute `Update-Database` command
* This will create the tables on the DB server configured in the data source url. Data source URL is configured in `MyDBContext.cs`
* `Update-Database` command to create the tables on the server