// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoList.Pages.TaskList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projekty_Blazor\TodoList\TodoList\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projekty_Blazor\TodoList\TodoList\Pages\TaskList\Todo.razor"
using DatabaseAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projekty_Blazor\TodoList\TodoList\Pages\TaskList\Todo.razor"
using TodoList.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Todo/{user}")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "E:\Projekty_Blazor\TodoList\TodoList\Pages\TaskList\Todo.razor"
       
    [Parameter]
    public string user { get; set; }
    private UserData userData;

    private TaskModel newTask = new TaskModel();
    private List<TaskData> tasks;

    protected override void OnInitialized()
    {
        userData = usrHandler.GetUser(user);
        tasks = tskHandler.GetUserTasks(userData.userId);
        Console.WriteLine(tasks);
    }

    private void AddTask()
    {
        TaskData task = new TaskData();
        task.UserId = userData.userId;
        task.Topic = newTask.Topic;
        task.Description = newTask.Description;
        task.Date = newTask.Date;
        task.Finished = false;

        tskHandler.InsertTask(task);
        tasks.Add(task);

        Console.WriteLine("Task added");
    }

    private void RemoveTask()
    {
        tasks = tskHandler.RemoveFinishedTasks(tasks);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskHandler tskHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserHandler usrHandler { get; set; }
    }
}
#pragma warning restore 1591
