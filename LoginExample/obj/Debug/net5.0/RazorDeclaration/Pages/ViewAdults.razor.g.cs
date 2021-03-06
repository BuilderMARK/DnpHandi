// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
using ToDo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdults")]
    public partial class ViewAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\Bent\RiderProjects\LoginExample\LoginExample\Pages\ViewAdults.razor"
       
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
        allAdults = await Persistence.ReadAllAdults();
        showAdults = allAdults;
    }

    private void RemoveAdult(int adultID)
    {
        Adult removeAdult = allAdults.First(a => a.id == adultID);
        Persistence.DeleteAdult(adultID);
        allAdults.Remove(removeAdult);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService Persistence { get; set; }
    }
}
#pragma warning restore 1591
