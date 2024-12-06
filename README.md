
# Dotnet Basics

## .NET Framework Vs .NET Core

- .NET Framework is a legacy once which can run only on Windows
- To make .net run on other Operating Systems project Mono was created by open source community
- To make .NET run on other OS Microsoft came up with .NET Core
- Last version of the .NET Framework is 4.8, they stopped development in 2019 and it will receive only security updates
- .NET Core has yearly releases

> [Reddit Explanation](https://www.reddit.com/r/csharp/comments/11oom0f/net_framework_vs_net_core/) [Video Explanation](https://www.youtube.com/watch?v=OkeM7XVwEdA)


## Application Execution

- Similar to Java .NET compiles the code into an Intermediate Language(IL) (byte code in Java) and this IL is execute by Common Language Runtime (CLR) (similar to JVM in Java)
- When you install .NET Framework (like Java) it comes with .NET Framework Class Libraries, which are usefull predefined set of classes to use .NET, like Console.WriteLine, Threads, List etc
- Another component is the and the Common Language Runtime *CLR* . It is like JVM which helps to run these assemblies
- Assemblies are .dll or .exe files, when you create a project you can configure the output type to be .exe or .dll
- CLR also has Garbage Collection for memory management

## ILDASM

- Intermediate Language Dis Assembler (ILDASM) it is a tool to de compile the generated assemblies (.dll or .exe). It is similar to Java Decompiler (JD Gui)
- To use dis assembler, click windows -> goto Visual Studio Folder in start menu click on Developer command prompt for VS 2022 and enter ildasm.exe
- It will open the window now you can select any .dll file you want to de compile
- You can dump the whole file to a text using using Dump option from File menu

## ILASM

- Intermediate Language Assembler (ILASM)
- You can construct the .dll file from the dump file you created using ILDASM
- Open Developer command prompt and type ilasm.exe c:\tes\test.il, it will generate the .dll file from the .il file

## Strong naming an assembly

- When you create a class library and you want to share the assembly globally then you have to install that assembly into GAC Global Assembly Cache
- GAC is located at `C:\Windows\Microsoft.NET\assembly\GAC_MSIL`, you can install the assembly into gac using command `gacutil.exe -i example.dll`
- The assembly which you are going to install into gac must be a strong named assembly
- First you have to generate the privte, public key pair using command `sn.exe -k c:\test\strongname.snk`
- Once you generate right click on the assembly in visual studio -> properties -> build -> strong naming and browse the .snk file you created
- Now you can install the assembly into gac using `gacutil.exe -i assemblyname.dll`
- You can install same assembly multiple times using different versions, this is called *Side by Side execution*
- To uninstall a assembly use `gacutil.exe -u assemblyname`
- All the above command should be run from VS 2022 developer command prompt

## How .NET Loads assemblies

- When you build the ConsoleApp2 Solution it keeps the ProjectA dll file also in the build folder, this is because we have added ProjectA as a dependency to ConsoleApp2
- Now if you delete the ProjectA dll and try to run the console app exe file it throws error because it couldn't find the dependency
- But you make the projecta libraray signed with a strong name key and deploy it to GAC then exe will work fine
- First if the dependent dll is signed then it will check in GAC, if it finds then it uses it, if it doesn't it will look in the config if there is any path specified for dll location
- If there is no path then it looks for current folder and load the dll file.


# C Sharp Basics

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

- Similar to class but classes are reference types and structs are value types like primitive data types
- Since structs are value types they are stored in stack, they behave similar to primitive data types

## Interfaces

- Everything similar to Java
- Explicit interfaces 

> Check `Interface.cs` for examples

## Delegates

- They are similar to Functional Interfaces, similar to how you can create a function interface and pass it as method parameter, you can do same using Delegates
- In java they provide out of the box funtional interfaces for common tasks like Predicate, BiPredicate etc, but here you have to create your own that matches method signature
- You can also use lambda expressions instead of creating the delegates

> Check `Delegates.cs` for examples

## Exception Handling

- Same as Java
- InnerExceptions is new
- CustomException

- > Check `Exceptions.cs`
- 
## Enums

- Same as Java, but you can't have String values assigned to enums like `Male("M")`

- > Check `Enums.cs`

## Access Modifiers

- Classes can have only 2 modifiers _public_ and _internal_, if you dont specify modifier default is **internal**
- For properties and methods _public_, _private_, _protected_, _internal_ and _protected internal_, if no modifier is mentioned default is **private**

> Check `AccessModifiers.cs`

## Attributes

- These are same as `Annotations` in Java
- You can use them witt the notation `[]` e.g. to mark a method as obselete use `[Obselete]`

## Reflection

- Similar to Java you can use reflection to get information about class, its methods, construtors, properties etc
- You can also create the class dynamically using Reflection and also invoke the methods and change property values
- This way of creating a class using Reflection is called Late Binding

## Generics, Hascode, Equals, ToString

- Same as in Java

## Partial Classes and Methods

- You can physically write code in two different files using `partial` keyword and compiler will treat it as single file during run time

## Indexes

- Special methods created using `this` keyword, you can also overload them and create multiple methods using different method signature
- Used for using classes as object to store some values without needing to call extra methods

> Check `Indexers.cs`

## Default and Params in Methods

- You can pass any number of arguments to methods using the `params` keyword,it is similar to varargs in java `String...args`
- You can also assign default values to method params similar to JavaScript

## Collections

- List, Dictionar (map in java), Stack Queue
- We can use generic types like Java
- Iterating over collections, etc same
- You can return ReadOnly Collections using a class to prevent modifications

> Check `ListAndDictionary.cs`

## Multithreading

- Threads are represented by `Thread` class, you can pass a method a s parameter to the thread class to run that method in a separate thread
- You can also use Lambda expressions to the Thread constructor
- You can use `Async Await` keywords to run the code in a separate thread and return results when its done, to return result you should wrap return in `Task` class

> Check `Threads.cs`

