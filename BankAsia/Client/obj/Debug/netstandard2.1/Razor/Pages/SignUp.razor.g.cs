#pragma checksum "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97f2e629fe5909f30ee4225475cc3e7a1e261c5f"
// <auto-generated/>
#pragma warning disable 1591
namespace BankAsia.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using BankAsia.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using BankAsia.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LANVIN\source\repos\BankAsia\BankAsia\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\n    <br><br><br><br><br>\n</div>\n");
            __builder.AddMarkupContent(1, "<div>\n    <h3 style=\"font-weight:bold; color:purple\">Book Stores Register</h3>\n</div>\n");
            __builder.AddMarkupContent(2, "<div>\n    <br>\n</div>\n");
            __builder.AddMarkupContent(3, "<div class=\"col-12 row\">\n    <input class=\"form-control col-12\" @*@bind=\"user.EmailAddress\"*@ placeholder=\"email address\">\n</div>\n<br>\n");
            __builder.AddMarkupContent(4, "<div class=\"col-12 row\">\n    <input type=\"password\" class=\"form-control col-12\" @*@bind=\"user.Password\"*@ placeholder=\"password\">\n</div>\n<br>\n");
            __builder.AddMarkupContent(5, "<div class=\"col-12 row\">\n    <input type=\"password\" class=\"form-control col-12\" @*@bind=\"user.ConfirmPassword\"*@ placeholder=\"confirm password\">\n</div>\n<br>\n");
            __builder.AddMarkupContent(6, "<div class=\"col-12 row\">\n    <span class=\"col-12\"></span>\n    <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Sign up\">\n    <a href=\"/\" class=\"col-6\">Already an user?</a>\n</div>\n<br>\n");
            __builder.AddMarkupContent(7, "<div class=\"col-12 row\" style=\"text-align:left; font-weight:bold\">\n    <span class=\"col-12\"></span>\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
