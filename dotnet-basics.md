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
