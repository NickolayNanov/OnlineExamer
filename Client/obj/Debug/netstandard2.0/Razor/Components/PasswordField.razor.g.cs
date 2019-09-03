#pragma checksum "D:\OnlineExamer\OnlineExamer\Client\Components\PasswordField.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d4f8eb8856127a25334ee650f9f0b8cacf1e0cc"
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
    public class PasswordField : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "form-group");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "input");
            builder.AddAttribute(4, "class", "textField");
            builder.AddAttribute(5, "type", "password");
            builder.AddAttribute(6, "name", "name");
            builder.AddAttribute(7, "value", 
#line 2 "D:\OnlineExamer\OnlineExamer\Client\Components\PasswordField.razor"
                                                                 Value

#line default
#line hidden
            );
            builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIChangeEventArgs>(this, 
#line 2 "D:\OnlineExamer\OnlineExamer\Client\Components\PasswordField.razor"
                                                                                    HandleChange

#line default
#line hidden
            ));
            builder.CloseElement();
            builder.AddMarkupContent(9, "\r\n    ");
            builder.OpenElement(10, "label");
            builder.AddContent(11, 
#line 3 "D:\OnlineExamer\OnlineExamer\Client\Components\PasswordField.razor"
            Label

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(12, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 6 "D:\OnlineExamer\OnlineExamer\Client\Components\PasswordField.razor"
       
    [Parameter] public string Label { get; set; }
    [Parameter] public string Value { get; set; }
    [Parameter] public EventCallback<string> ValueChanged { get; set; }

    protected Task HandleChange(UIChangeEventArgs uIChangeEvent)
    {
        this.Value = (string)uIChangeEvent.Value;
        return ValueChanged.InvokeAsync(this.Value);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591