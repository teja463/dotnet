# Notes

## Data types

- Data types int, float, double, string, bool
- You can't assign null values to the built in types 
  - e.g. `int a = null` will give compilation error
  - You have to use the ? after data type to denote that the type accepts null values like `int? a = null`
- `??` is null coalescing operator to assign a different value if the value is null `int b = a?? 20`. b value will be 20 if a is null else b value will be a

## Parameters

- `out` params to return multiple values from a function
- `ref` param to pass by reference
- `params` is similar to `varargs` in java
  
> Check `OutParams, PassByRef` methods in `Program.cs`

## Namesapces

- To use any namespace `using namesapce`
- Classes should be placed in some namespace, like java classes should be put in a package

> Check `Employee.cs` file for example

## Classes

- Default constructor
- Parameterized Constructor
- Static Constructor (similar to static blocks in java)
- Destructor

> Check `Employee.cs` file for examples
