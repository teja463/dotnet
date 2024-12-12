# ASP.NET

## ASP.NET VS ASP.NET MVC

### ASP.NET (Web Forms)

- ASP.NET was actually ASP.NET Web Forms
- This version was mostly resembles how we create Desktop Apps using .NET
- You have a .aspx file and a code behind file with .aspx.cs extention
- All the controls you can include are .NET control which replicates HTML controls
- Lets say when you add button you are actually adding a server side button component, and you have to double click on that button to write what happens when the button clicked, and then this gets converted to HTML button.
- This is event driven, you write code for events like button clicked, text entered etc, this is similar to how desktop apps were written
- The problem is HTTP is stateless and in order to maintain state, ASP.NET maintains the state of all the feilds in a single VIEWSTATE object which is sent as a hidden field in the html.
- This all process is not testable and scalable, here we are emulating web development using desktop development approach

### ASP.NET MVC

- ASP.NET MVC was released to overcome challenges faced in Web Forms
- Here you just write normal HTMl code use HTMl controls, not the ASP.NET Server Side Input, or Button controls
- This is similar to Spring MVC where you have a Controller, Model and a View to render
- Below are great articles to describe the difference and uses
- [Comparing Web Forms and MVC](https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/brownfield/dino-esposito-on-comparing-web-forms-with-asp-net-mvc)
- [ASP.NET MVC In a Nutshell](https://learn.microsoft.com/en-us/archive/msdn-magazine/2008/march/asp-net-mvc-building-web-apps-without-web-forms)

### ASP.NET Razor

- In the MVC project type you have a controller and view separatley
- When you create a razor type project there is no controller class separatlye, the .cshtml file itself act as a view and a controller
- It is done by using the code behind .cs file where you can write the code
- [Good notes on the MVC vs Razor Comparison](https://www.reddit.com/r/csharp/comments/18met8r/what_is_the_difference_between_mvc_and_razor/)