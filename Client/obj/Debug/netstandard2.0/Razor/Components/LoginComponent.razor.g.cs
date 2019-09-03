#pragma checksum "D:\OnlineExamer\OnlineExamer\Client\Components\LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5df9bedb40772aed3b7ee5494e0a9b3db394b51"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineExamer.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#line 3 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client;

#line default
#line hidden
#line 7 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client.Shared;

#line default
#line hidden
#line 8 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Shared.Models;

#line default
#line hidden
#line 9 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client.Components;

#line default
#line hidden
#line 11 "D:\OnlineExamer\OnlineExamer\Client\_Imports.razor"
using OnlineExamer.Client.Services.Contracts;

#line default
#line hidden
    public class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddMarkupContent(1, "\r\n    ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.AuthorizeView>(2);
            builder.AddAttribute(3, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(4, "\r\n            ");
                builder2.AddMarkupContent(5, "<text>...</text>\r\n        ");
            }
            ));
            builder.AddAttribute(6, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.AuthenticationState>)((context) => (builder2) => {
                builder2.AddMarkupContent(7, "\r\n            <img src=\"img/user.svg\">\r\n            ");
                builder2.OpenElement(8, "div");
                builder2.AddMarkupContent(9, "\r\n                ");
                builder2.OpenElement(10, "span");
                builder2.AddAttribute(11, "class", "username");
                builder2.AddContent(12, 
#line 11 "D:\OnlineExamer\OnlineExamer\Client\Components\LoginComponent.razor"
                                        context.User.Identity.Name

#line default
#line hidden
                );
                builder2.CloseElement();
                builder2.AddMarkupContent(13, "\r\n                ");
                builder2.OpenElement(14, "button");
                builder2.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 12 "D:\OnlineExamer\OnlineExamer\Client\Components\LoginComponent.razor"
                                  Submit

#line default
#line hidden
                ));
                builder2.AddContent(16, "Logout");
                builder2.CloseElement();
                builder2.AddMarkupContent(17, "\r\n            ");
                builder2.CloseElement();
                builder2.AddMarkupContent(18, "\r\n        ");
            }
            ));
            builder.AddAttribute(19, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.AuthenticationState>)((context) => (builder2) => {
                builder2.AddMarkupContent(20, "\r\n            ");
                builder2.AddMarkupContent(21, "<a class=\"sign-in\" href=\"login\">Sign in</a>\r\n        ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(22, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 21 "D:\OnlineExamer\OnlineExamer\Client\Components\LoginComponent.razor"
      
    protected async Task Submit()
    {
        await this.AuthService.Logout();
        this.uriHelper.NavigateTo("/");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
