#pragma checksum "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\AuthPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bee41464263257b5779edeef2556e2997f17d1e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OnlineExamer.Client.Pages.Account
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication")]
    public class AuthPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 7 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\AuthPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    [Parameter]
    public string Email { get; set; }

    protected async Task Submit()
    {
        var state = await AuthStateProvider.GetAuthenticationStateAsync();

        if (state.User.Identity.IsAuthenticated)
        {
            Console.WriteLine(state.User.Identity.Name);
        }
        else
        {
            Console.WriteLine("Курва");
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
    }
}
#pragma warning restore 1591
