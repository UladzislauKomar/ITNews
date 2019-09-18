#pragma checksum "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48c40398e8b8711e92bcc4d587260712d8e4040f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\_ViewImports.cshtml"
using ITNews.Web;

#line default
#line hidden
#line 2 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\_ViewImports.cshtml"
using ITNews.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c40398e8b8711e92bcc4d587260712d8e4040f", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24923f66bf5e09b64fabf3a26a5944ca74388d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ITNews.Domain.Contracts.ViewModels.UserViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(195, 61, true);
            WriteLiteral("\t<div class=\"card\">\r\n\t\t<div class=\"card-header\">\r\n\t\t\t<strong>");
            EndContext();
            BeginContext(257, 13, false);
#line 12 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(270, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
#line 13 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
             if (item.LockoutEnd != null)
			{

#line default
#line hidden
            BeginContext(321, 52, true);
            WriteLiteral("\t\t\t\t<span class=\"badge badge-danger\">BLOCKED (until ");
            EndContext();
            BeginContext(374, 26, false);
#line 15 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
                                                           Write(item.LockoutEnd.Value.Date);

#line default
#line hidden
            EndContext();
            BeginContext(400, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 16 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(416, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
#line 17 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
             if (!item.EmailConfirmed)
			{

#line default
#line hidden
            BeginContext(453, 57, true);
            WriteLiteral("\t\t\t\t<span class=\"badge badge-danger\">Unconfirmed</span>\r\n");
            EndContext();
#line 20 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(516, 37, true);
            WriteLiteral("\t\t\t<span class=\"badge badge-success\">");
            EndContext();
            BeginContext(554, 7, false);
#line 21 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
                                         Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(561, 59, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div class=\"card-body\">\r\n\t\t\t<h5>\r\n\t\t\t\t");
            EndContext();
            BeginContext(621, 14, false);
#line 25 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
           Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(635, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(637, 13, false);
#line 25 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
                           Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(650, 24, true);
            WriteLiteral("\r\n\t\t\t</h5>\r\n\t\t\t<p>\r\n\t\t\t\t");
            EndContext();
            BeginContext(675, 16, false);
#line 28 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(691, 34, true);
            WriteLiteral("\r\n\t\t\t</p>\r\n\t\t\t<p>\r\n\t\t\t\tBirthdate: ");
            EndContext();
            BeginContext(726, 39, false);
#line 31 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
                      Write(item.Birthdate.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(765, 23, true);
            WriteLiteral("\r\n\t\t\t</p>\r\n\t\t\t<p>\r\n\t\t\t\t");
            EndContext();
            BeginContext(789, 10, false);
#line 34 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(799, 14, true);
            WriteLiteral("\r\n\t\t\t</p>\r\n\t\t\t");
            EndContext();
            BeginContext(814, 78, false);
#line 36 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
       Write(Html.ActionLink("Profile", "Profile", "User", new { userName = item.UserName}));

#line default
#line hidden
            EndContext();
            BeginContext(892, 7, true);
            WriteLiteral(" |\r\n\t\t\t");
            EndContext();
            BeginContext(900, 57, false);
#line 37 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { userId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(957, 7, true);
            WriteLiteral(" |\r\n\t\t\t");
            EndContext();
            BeginContext(965, 61, false);
#line 38 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { userId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 21, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 41 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\Admin\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ITNews.Domain.Contracts.ViewModels.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
