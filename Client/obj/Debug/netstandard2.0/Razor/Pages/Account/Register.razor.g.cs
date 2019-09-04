#pragma checksum "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bca8a090c8f87e341b53a346972226efa68867c"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Register</h1>\r\n\r\n");
#line 7 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
 if (ShowErrors)
{

#line default
#line hidden
            builder.AddContent(1, "    ");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "class", "alert alert-danger");
            builder.AddAttribute(4, "role", "alert");
            builder.AddMarkupContent(5, "\r\n");
#line 10 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
         foreach (var Error in Errors)
        {

#line default
#line hidden
            builder.AddContent(6, "            ");
            builder.OpenElement(7, "p");
            builder.AddContent(8, 
#line 12 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
                Error

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(9, "\r\n");
#line 13 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
        }

#line default
#line hidden
            builder.AddContent(10, "    ");
            builder.CloseElement();
            builder.AddMarkupContent(11, "\r\n");
#line 15 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
}

#line default
#line hidden
            builder.AddMarkupContent(12, "\r\n");
            builder.OpenComponent<OnlineExamer.Client.Components.TextField>(13);
            builder.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 17 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
                        Email

#line default
#line hidden
            ));
            builder.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Email = __value, Email))));
            builder.CloseComponent();
            builder.AddMarkupContent(16, "\r\n");
            builder.OpenComponent<OnlineExamer.Client.Components.PasswordField>(17);
            builder.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
                            Password

#line default
#line hidden
            ));
            builder.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Password = __value, Password))));
            builder.CloseComponent();
            builder.AddMarkupContent(20, "\r\n");
            builder.OpenComponent<OnlineExamer.Client.Components.PasswordField>(21);
            builder.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 19 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
                            ConfirmPassword

#line default
#line hidden
            ));
            builder.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ConfirmPassword = __value, ConfirmPassword))));
            builder.CloseComponent();
            builder.AddMarkupContent(24, "\r\n\r\n");
            builder.OpenElement(25, "input");
            builder.AddAttribute(26, "type", "submit");
            builder.AddAttribute(27, "class", "btn btn-success");
            builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 21 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
                                                        Submit

#line default
#line hidden
            ));
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 23 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\Account\Register.razor"
       

    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }

    private RegisterModel RegisterModel = new RegisterModel();
    private bool ShowErrors;
    private IEnumerable<string> Errors;

    protected async Task Submit()
    {
        RegisterModel model = new RegisterModel { Email = Email, Password = Password, ConfirmPassword = ConfirmPassword };
        var result = await this.AuthService.Register(model);

        if (result.Successful)
        {
            this.UriHelper.NavigateTo("/login");
        }
        else
        {
            ShowErrors = true;
            Errors = result.Errors;
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
