#pragma checksum "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\CommentLike\Like.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20cac8f2aeb56c990507aaac277be184e0dbe27e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CommentLike_Like), @"mvc.1.0.view", @"/Views/CommentLike/Like.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CommentLike/Like.cshtml", typeof(AspNetCore.Views_CommentLike_Like))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20cac8f2aeb56c990507aaac277be184e0dbe27e", @"/Views/CommentLike/Like.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24923f66bf5e09b64fabf3a26a5944ca74388d00", @"/Views/_ViewImports.cshtml")]
    public class Views_CommentLike_Like : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITNews.Domain.Contracts.ViewModels.CommentLikeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 97, true);
            WriteLiteral("\r\n<button type=\"button\" id=\"like\" class=\"btn btn-primary btn-sm likeClass\">\r\n\tLike\r\n</button>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(179, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\CommentLike\Like.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITNews.Domain.Contracts.ViewModels.CommentLikeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
