// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WarehouseManger.Client.Shared.Components
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using MudBlazor

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using Blazored.FluentValidation

#nullable disable
    ;
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Account

#nullable disable
    ;
#nullable restore
#line 19 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Authentication

#nullable disable
    ;
#nullable restore
#line 20 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Roles

#nullable disable
    ;
#nullable restore
#line 21 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.RoleClaims

#nullable disable
    ;
#nullable restore
#line 22 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Users

#nullable disable
    ;
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Preferences

#nullable disable
    ;
#nullable restore
#line 24 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Interceptors

#nullable disable
    ;
#nullable restore
#line 25 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Product

#nullable disable
    ;
#nullable restore
#line 26 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Brand

#nullable disable
    ;
#nullable restore
#line 27 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Dashboard

#nullable disable
    ;
#nullable restore
#line 28 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Communication

#nullable disable
    ;
#nullable restore
#line 29 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Audit

#nullable disable
    ;
#nullable restore
#line 30 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.Document

#nullable disable
    ;
#nullable restore
#line 31 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.DocumentType

#nullable disable
    ;
#nullable restore
#line 34 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Shared.Constants.Permission

#nullable disable
    ;
#nullable restore
#line 35 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Components

#nullable disable
    ;
#nullable restore
#line 37 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client

#nullable disable
    ;
#nullable restore
#line 38 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared

#nullable disable
    ;
#nullable restore
#line 39 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Dialogs

#nullable disable
    ;
#nullable restore
#line 40 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Settings

#nullable disable
    ;
#nullable restore
#line 42 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Application.Requests.Identity

#nullable disable
    ;
#nullable restore
#line 44 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Pages.Authentication

#nullable disable
    ;
#nullable restore
#line 46 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Authentication

#nullable disable
    ;
#nullable restore
#line 47 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Extensions

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
 using WarehouseManger.Shared.Constants.Localization

#nullable disable
    ;
    #line default
    #line hidden
#nullable restore
#line 49 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable

    #nullable restore
    public partial class LanguageSelector : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
 
    private async Task ChangeLanguageAsync(string languageCode)
    {
        var result = await _clientPreferenceManager.ChangeLanguageAsync(languageCode);
        if (result.Succeeded)
        {
            _snackBar.Add(result.Messages[0], Severity.Success);
            _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
        }
        else
        {
            foreach (var error in result.Messages)
            {
                _snackBar.Add(error, Severity.Error);
            }
        }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 62 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 62 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_jsRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 61 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
ILocalStorageService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 61 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_localStorage

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 60 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
IUserManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 60 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_userManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 59 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
ClientPreferenceManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 59 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_clientPreferenceManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 58 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
IHttpInterceptorManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 58 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_interceptor

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 57 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
HttpClient

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 57 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_httpClient

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 56 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
IDialogService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 56 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_dialogService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 55 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
ISnackbar

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 55 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_snackBar

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 54 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
IAuthorizationService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 54 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_authorizationService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 53 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
BlazorHeroStateProvider

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 53 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_stateProvider

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 52 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 52 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_navigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 51 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
IAccountManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 51 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_accountManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 50 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
IAuthenticationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 50 "C:\Users\Admin\OneDrive\Documentos\GitHub\WarehouseManger\src\Client\_Imports.razor"
_authenticationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
