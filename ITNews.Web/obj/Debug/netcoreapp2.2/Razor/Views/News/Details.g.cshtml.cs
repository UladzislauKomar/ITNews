#pragma checksum "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a667baef65ff13334feb31407374bbe8759c6d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Details.cshtml", typeof(AspNetCore.Views_News_Details))]
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
#line 1 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
#line 2 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
using ITNews.Domain.Contracts.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
using ITNews.Data.Contracts.Entities;

#line default
#line hidden
#line 4 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a667baef65ff13334feb31407374bbe8759c6d6", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24923f66bf5e09b64fabf3a26a5944ca74388d00", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITNews.Domain.Contracts.ViewModels.NewsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../NewsRating/Rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Comment/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Comment/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(259, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
  
	ViewData["Title"] = Model.Title;
	Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(353, 54, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n\t<div class=\"card-body\">\r\n\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 407, "\"", 435, 2);
#line 15 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
WriteAttributeValue("", 412, Model.NewsId, 412, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 425, "-news-body", 425, 10, true);
            EndWriteAttribute();
            BeginContext(436, 99, true);
            WriteLiteral(">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-12\">\r\n\t\t\t\t\t<div class=\"panel-heading\">\r\n\t\t\t\t\t\t<strong>");
            EndContext();
            BeginContext(536, 19, false);
#line 19 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                           Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(555, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(558, 24, false);
#line 19 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                                                 Write(Model.User.Likes.Count());

#line default
#line hidden
            EndContext();
            BeginContext(582, 36, true);
            WriteLiteral(")</strong><span class=\"text-muted\"> ");
            EndContext();
            BeginContext(619, 20, false);
#line 19 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                                                                                                              Write(ViewData["PostedAt"]);

#line default
#line hidden
            EndContext();
            BeginContext(639, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(641, 13, false);
#line 19 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                                                                                                                                    Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(654, 48, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t<span class=\"badge badge-danger\">");
            EndContext();
            BeginContext(703, 18, false);
#line 20 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                                                    Write(Model.Section.Name);

#line default
#line hidden
            EndContext();
            BeginContext(721, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 21 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                         foreach (var tag in Model.Tags)
						{

#line default
#line hidden
            BeginContext(779, 41, true);
            WriteLiteral("\t\t\t\t\t\t\t<span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(821, 12, false);
#line 23 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                                                         Write(tag.Tag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(833, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 24 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
						}

#line default
#line hidden
            BeginContext(851, 63, true);
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"panel-body\">\r\n\t\t\t\t\t\t<h4>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(915, 70, false);
#line 28 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                       Write(Html.ActionLink(Model.Title, "Details", new { newsId = Model.NewsId }));

#line default
#line hidden
            EndContext();
            BeginContext(985, 64, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</h4>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<h5>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1050, 39, false);
#line 34 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
           Write(Markdown.ParseHtmlString(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 35, true);
            WriteLiteral("\r\n\t\t\t</h5>\r\n\t\t\t<img class=\"rounded\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1124, "\"", 1148, 1);
#line 36 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
WriteAttributeValue("", 1130, Model.Description, 1130, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1149, "\"", 1172, 2);
#line 36 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
WriteAttributeValue("", 1155, Model.NewsId, 1155, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1168, "-img", 1168, 4, true);
            EndWriteAttribute();
            BeginContext(1173, 38, true);
            WriteLiteral(" style=\"width:100%; height:auto;\" />\r\n");
            EndContext();
#line 37 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
             if (Model.User.UserName == User.Identity.Name || User.IsInRole("admin"))
			{
				

#line default
#line hidden
            BeginContext(1300, 83, false);
#line 39 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
           Write(Html.ActionLink(ViewData["Edit"].ToString(), "Edit", new { newsId = Model.NewsId }));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 22, true);
            WriteLiteral("\t\t\t\t<span> | </span>\r\n");
            EndContext();
            BeginContext(1412, 87, false);
#line 41 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
           Write(Html.ActionLink(ViewData["Delete"].ToString(), "Delete", new { newsId = Model.NewsId }));

#line default
#line hidden
            EndContext();
#line 41 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                                                                                                        
			}

#line default
#line hidden
            BeginContext(1507, 94, true);
            WriteLiteral("\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-md-12\">\r\n\t\t\t\t\t<span class=\"text-hide\" id=\"newsId\">");
            EndContext();
            BeginContext(1602, 12, false);
#line 46 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                                                   Write(Model.NewsId);

#line default
#line hidden
            EndContext();
            BeginContext(1614, 34, true);
            WriteLiteral("</span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n");
            EndContext();
#line 50 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
             if (User.Identity.IsAuthenticated && userManager.GetUserAsync(User).Result.EmailConfirmed)
			{
				if (Model.Ratings.SingleOrDefault(x => x.User.UserName == User.Identity.Name) == null)
				{

#line default
#line hidden
            BeginContext(1849, 5, true);
            WriteLiteral("\t\t\t\t\t");
            EndContext();
            BeginContext(1854, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a667baef65ff13334feb31407374bbe8759c6d612644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new NewsRatingViewModel();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1927, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
				}
			}

#line default
#line hidden
            BeginContext(1942, 20, true);
            WriteLiteral("\r\n\t\t\t<hr />\r\n\t\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1962, "\"", 1989, 2);
#line 59 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
WriteAttributeValue("", 1967, Model.NewsId, 1967, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1980, "-comments", 1980, 9, true);
            EndWriteAttribute();
            BeginContext(1990, 18, true);
            WriteLiteral(">\r\n\t\t\t\t<h5>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(2009, 20, false);
#line 61 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
               Write(ViewData["Comments"]);

#line default
#line hidden
            EndContext();
            BeginContext(2029, 41, true);
            WriteLiteral("\r\n\t\t\t\t</h5>\r\n\t\t\t\t<div id=\"commentList\">\r\n");
            EndContext();
#line 64 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                     if (Model.Comments.Count() > 0)
					{

#line default
#line hidden
            BeginContext(2117, 6, true);
            WriteLiteral("\t\t\t\t\t\t");
            EndContext();
            BeginContext(2123, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a667baef65ff13334feb31407374bbe8759c6d615750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 66 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Comments.OrderByDescending(x => x.Created);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2215, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 67 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(2244, 35, true);
            WriteLiteral("\t\t\t\t\t\t<h5 id=\"noComments\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2280, 22, false);
#line 71 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                       Write(ViewData["NoComments"]);

#line default
#line hidden
            EndContext();
            BeginContext(2302, 15, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</h5>\r\n");
            EndContext();
#line 73 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
					}

#line default
#line hidden
            BeginContext(2325, 12, true);
            WriteLiteral("\t\t\t\t</div>\r\n");
            EndContext();
#line 75 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
                 if (User.Identity.IsAuthenticated && userManager.GetUserAsync(User).Result.EmailConfirmed)
				{

#line default
#line hidden
            BeginContext(2441, 5, true);
            WriteLiteral("\t\t\t\t\t");
            EndContext();
            BeginContext(2446, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a667baef65ff13334feb31407374bbe8759c6d618700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 77 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new CommentViewModel();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2513, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 78 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Details.cshtml"
				}

#line default
#line hidden
            BeginContext(2522, 40, true);
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UserEntity> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITNews.Domain.Contracts.ViewModels.NewsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591