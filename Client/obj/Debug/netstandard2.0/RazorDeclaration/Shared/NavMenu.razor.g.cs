#pragma checksum "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12593eb8b3eb6d91cc13fd17ba61709b1d720449"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OnlineExamer.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#line 3 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client;

#line default
#line hidden
#line 7 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client.Shared;

#line default
#line hidden
#line 8 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Shared.Models;

#line default
#line hidden
#line 9 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client.Components;

#line default
#line hidden
#line 10 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client.Services.Contracts;

#line default
#line hidden
#line 11 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 54 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
