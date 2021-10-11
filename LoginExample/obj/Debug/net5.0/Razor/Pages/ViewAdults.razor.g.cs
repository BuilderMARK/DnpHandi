#pragma checksum "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa086ba1cfb51929f70ad4c1ad3dfa96011f08cc"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdults")]
    public partial class ViewAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ViewAdults</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Search by adult id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                                         (arg) => FilterByAdultId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n    Search by first name: ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                                         (arg) => FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width:200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "\r\n    Filter by sex:\r\n    ");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "class", "form-control selectpicker");
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                                           (arg) => FilterBySex(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "style", "width:100px");
            __builder.OpenElement(21, "option");
            __builder.AddContent(22, "Any");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "option");
            __builder.AddContent(25, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
 if (allAdults == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<p><em>Loading...</em></p>");
#nullable restore
#line 29 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
} else if (!allAdults.Any()) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<p><em>No adults in the list. Please add some.</em></p>");
#nullable restore
#line 33 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(31);
            __builder.AddAttribute(32, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(33, "table");
                __builder2.AddAttribute(34, "class", "table");
                __builder2.AddMarkupContent(35, @"<thead><tr><th>ID</th>
                    <th>First name</th>
                    <th>Last name</th>
                    <th>Job title</th>
                    <th>Hair color</th>
                    <th>Eye color</th>
                    <th>Age</th>
                    <th>Weight</th>
                    <th>Height</th>
                    <th>Sex</th></tr></thead>
                ");
                __builder2.OpenElement(36, "tbody");
#nullable restore
#line 52 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                 foreach (var item in showAdults)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(37, "tr");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 55 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 56 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 57 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenElement(47, "td");
                __builder2.AddContent(48, 
#nullable restore
#line 58 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.Jobtitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                        ");
                __builder2.OpenElement(50, "td");
                __builder2.AddContent(51, 
#nullable restore
#line 59 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "td");
                __builder2.AddContent(54, 
#nullable restore
#line 60 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.OpenElement(56, "td");
                __builder2.AddContent(57, 
#nullable restore
#line 61 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "td");
                __builder2.AddContent(60, 
#nullable restore
#line 62 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.OpenElement(62, "td");
                __builder2.AddContent(63, 
#nullable restore
#line 63 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.Hight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.OpenElement(65, "td");
                __builder2.AddContent(66, 
#nullable restore
#line 64 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             item.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 66 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(67, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(68, "table");
                __builder2.AddAttribute(69, "class", "table");
                __builder2.AddMarkupContent(70, @"<thead><tr><th>ID</th>
                                <th>First name</th>
                                <th>Last name</th>
                                <th>Job title</th>
                                <th>Hair color</th>
                                <th>Eye color</th>
                                <th>Age</th>
                                <th>Weight</th>
                                <th>Height</th>
                                <th>Sex</th>
                                <th>Remove</th></tr></thead>
                            ");
                __builder2.OpenElement(71, "tbody");
#nullable restore
#line 88 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                             foreach (var item in showAdults)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(72, "tr");
                __builder2.OpenElement(73, "td");
                __builder2.AddContent(74, 
#nullable restore
#line 91 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                    ");
                __builder2.OpenElement(76, "td");
                __builder2.AddContent(77, 
#nullable restore
#line 92 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                    ");
                __builder2.OpenElement(79, "td");
                __builder2.AddContent(80, 
#nullable restore
#line 93 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                    ");
                __builder2.OpenElement(82, "td");
                __builder2.AddContent(83, 
#nullable restore
#line 94 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.Jobtitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                    ");
                __builder2.OpenElement(85, "td");
                __builder2.AddContent(86, 
#nullable restore
#line 95 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                                    ");
                __builder2.OpenElement(88, "td");
                __builder2.AddContent(89, 
#nullable restore
#line 96 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                                    ");
                __builder2.OpenElement(91, "td");
                __builder2.AddContent(92, 
#nullable restore
#line 97 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                    ");
                __builder2.OpenElement(94, "td");
                __builder2.AddContent(95, 
#nullable restore
#line 98 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                                    ");
                __builder2.OpenElement(97, "td");
                __builder2.AddContent(98, 
#nullable restore
#line 99 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.Hight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                                    ");
                __builder2.OpenElement(100, "td");
                __builder2.AddContent(101, 
#nullable restore
#line 100 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                         item.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                                    ");
                __builder2.OpenElement(103, "td");
                __builder2.OpenElement(104, "button");
                __builder2.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                                                            () => RemoveAdult(item.id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(106, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 107 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 112 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> showAdults;

    private int? id;
    private string firstName;
    private string sex;
    
    
    private void FilterByAdultId(ChangeEventArgs eventArgs)
    {
        id = null;
        try
        {
            id = int.Parse(eventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByFirstName(ChangeEventArgs changeEventArgs)
    {
        firstName = null;
        try
        {
            firstName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }
    
    private void FilterBySex(ChangeEventArgs changeEventArgs)
    {
        sex = null;
        try
        {
            if (changeEventArgs.Value.ToString().Equals("Male"))
            {
                sex = "M";
            }
            else if (changeEventArgs.Value.ToString().Equals("Female"))
            {
                sex = "F";
            }
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        showAdults = allAdults.Where(a => (id!=null && a.id == id || id == null) &&
                                            (firstName != null && a.FirstName.Contains(firstName, StringComparison.OrdinalIgnoreCase) || firstName == null || firstName.Length == 0) &&
                                            (sex!=null && a.Sex == sex || sex == null) ).ToList();
    }
    
    protected override async Task OnInitializedAsync()
    {
        allAdults = Persistence.ReadAllAdults();
        showAdults = allAdults;
    }

    private void RemoveAdult(int adultID)
    {
        Adult removeAdult = allAdults.First(a => a.id == adultID);
        Persistence.DeleteAdult(removeAdult);
        allAdults.Remove(removeAdult);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService Persistence { get; set; }
    }
}
#pragma warning restore 1591
