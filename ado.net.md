# ADO .NET

## Basics

- ADO.NET provides connection classes for each database, for SQL Server it is SQLConnection, for Oracle it is OracleConnection
- To create a connection to the SQL Server Database use SQLConnection con = new SqlConnection("connection string")
- Use `using(SQLConnection con = new SqlConnection("xxx"))` to close the connection automatically, similar to try with resource block in java
- Once you have to connection you have to write SQL Query to do this you have to use `SqlCommand` class `SqlCommand cmd = new SqlCommand("Select * from Product", connection)`
- You have 3 types of methods to execute 
  - ExecueQuery to read resultset
  - ExecuteNonQuery for updating or deleting rows
  - ExecuteScalar if you want to receive just one value, use when you want to get count(*) from table
## Main classes

- SqlDataReader it is simialr to Resultset in Java, the SQL query returned rows are stored here similar to java you have to iterate over this object to read data from the result set
- SqlDataAdapter is similar to SqlDataReader but you dont need to keep the connection open to read data, you can just store it in memory once the query is completed it is done using DataSet class

## SQL Injection

- Similar to java if you concatenate the user inputs into the where clause in the SQL Query string which is passed to the SQLCommand it can cause SQL Injection attacks
- To prevent this add parameter names in the query and set values in the next step

```csharp
SqlCommand cmd = new SqlCommand("Select * from product where product like @ProductName", connection);
cmd.Parameters.AddWithValue("@ProductName", "Sample");
```

## Executing Stored Procedure

- If you want to execute the stored procedure mention it to the command object
- `cmd.CommandType = System.Data.CommandType.StoredProcedure`
- 