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
#line 3 "E:\Projekty_Blazor\TodoList\TodoList\Pages\TaskList\Register.razor"
using TodoList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projekty_Blazor\TodoList\TodoList\Pages\TaskList\Register.razor"
using DatabaseAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "E:\Projekty_Blazor\TodoList\TodoList\Pages\TaskList\Register.razor"
       
    private RegistrationModel newForm = new RegistrationModel();

    private bool exists;

    private void InsertUser()
    {
        exists = _db.DoesUserExists(newForm.Username);
        Console.WriteLine(exists);
        if (exists == false)
        {
            UserData usr = new UserData
            {
                Username = newForm.Username,
                Password = newForm.Password,
                EmailAddress = newForm.EmailAddress
            };
            _db.InsertUser(usr);
            newForm = new RegistrationModel();

            NavManager.NavigateTo("/Data/Login");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserHandler _db { get; set; }
    }
}
#pragma warning restore 1591