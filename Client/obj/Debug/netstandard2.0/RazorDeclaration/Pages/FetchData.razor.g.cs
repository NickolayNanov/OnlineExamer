#pragma checksum "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff817f3c526dcb5a0dcf1072cb3137128650d71"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OnlineExamer.Client.Pages
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
#line 2 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\FetchData.razor"
using OnlineExamer.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 39 "D:\OnlineExamer\OnlineExamer\OnlineExamer\Client\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;
    ApiResponse<WeatherForecast[]> response;

    protected override async Task OnInitializedAsync()
    {
        response = await ApiService.GetForecastAsync();
        forecasts = response.Data;
        this.StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiService ApiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
