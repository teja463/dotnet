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

## Namespaces

- To use any namespace `using namesapce`
- Classes should be placed in some namespace, like java classes should be put in a package

> Check `Employee.cs` for example

## Classes

- Default constructor
- Parameterized Constructor
- Static Constructor (similar to static blocks in java)
- Destructor
- `this()` to other constructors

> Check `Employee.cs` for examples

## Inheritance

- To call super class constructors use `base()`

> Check `Inheritance.cs` for examples

## Polymorphism

- **Method hiding** when you have the same public method in parent and child class e.g. `PrintName` and when you call `Employee e = new FulltimeEmployee()` and `e.PrintName()` it will always call the method in the parent class, even when you override that method in child class, but the compiler will show warning, to get rid of that warning you can use new keyword `public new void PrintName()`
- **Overriding** in the above case if you want to call child class PrintName method you have to change variable reference to Child class so it will be `FulltimeEmployee e = new FulltimeEmployee()`. But what if you want to child class print method if it exists and call parent method if there is no overiride method then you an use `virtual` keyword in parent class and `override` keyword in child class.

> Check `Polymorphism.cs`

## Properties

- Get and Set
- Readonly, Writeonly

## Structs

- Similar to class but classes are reference types and structs are object types like primitive data types
- Since structs are not reference types values are stored in stack, they behave similar to primitive data types

## Interfaces

- Everything similar to Java
- Explicit interfaces 

> Check `Interface.cs` for examples

## Delegates

- They are similar to Functional Interfaces, similar to how you can create a function interface and pass it as method parameter, you can do same using Delegates
- In java they provide out of the box funtional interfaces for common tasks like Predicate, BiPredicate etc, but here you have to create your own that matches method signature
- You can also use lambda expressions instead of creating the delegates

> Check `Delegates.cs` for examples