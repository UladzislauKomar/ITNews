#pragma checksum "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58c64ff613c76b48be906042453c8aaa660917b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Index.cshtml", typeof(AspNetCore.Views_News_Index))]
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
#line 1 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58c64ff613c76b48be906042453c8aaa660917b", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24923f66bf5e09b64fabf3a26a5944ca74388d00", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ITNews.Domain.Contracts.ViewModels.NewsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(197, 101, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-8\">\r\n\t\t\t<div class=\"row\">\r\n");
            EndContext();
#line 13 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
            BeginContext(339, 39, true);
            WriteLiteral("\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 378, "\"", 405, 2);
#line 16 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
WriteAttributeValue("", 383, item.NewsId, 383, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 395, "-news-body", 395, 10, true);
            EndWriteAttribute();
            BeginContext(406, 158, true);
            WriteLiteral(" class=\"card bg-light mb-3\" style=\"margin-bottom:16px;\">\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-12\">\r\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(564, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f58c64ff613c76b48be906042453c8aaa660917b6242", async() => {
                BeginContext(651, 8, true);
                WriteLiteral("<strong>");
                EndContext();
                BeginContext(660, 18, false);
#line 20 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                                  Write(item.User.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(678, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(681, 23, false);
#line 20 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                                                       Write(item.User.Likes.Count());

#line default
#line hidden
                EndContext();
                BeginContext(704, 10, true);
                WriteLiteral(")</strong>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                              WriteLiteral(item.User.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(718, 26, true);
            WriteLiteral("<span class=\"text-muted\"> ");
            EndContext();
            BeginContext(745, 14, false);
#line 20 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                                                                                                                       Write(ViewData["At"]);

#line default
#line hidden
            EndContext();
            BeginContext(759, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(761, 12, false);
#line 20 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                                                                                                                                       Write(item.Created);

#line default
#line hidden
            EndContext();
            BeginContext(773, 100, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-12\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"badge badge-danger\">");
            EndContext();
            BeginContext(874, 17, false);
#line 23 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                    Write(item.Section.Name);

#line default
#line hidden
            EndContext();
            BeginContext(891, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 24 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                         foreach (var tag in item.Tags)
										{

#line default
#line hidden
            BeginContext(956, 45, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(1002, 12, false);
#line 26 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                         Write(tag.Tag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 27 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
										}

#line default
#line hidden
            BeginContext(1036, 75, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-12\">\r\n\t\t\t\t\t\t\t\t\t\t<h4>\r\n\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1112, 68, false);
#line 31 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                       Write(Html.ActionLink(item.Title, "Details", new { newsId = item.NewsId }));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 96, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</h4>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<img class=\"rounded\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1276, "\"", 1299, 1);
#line 36 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
WriteAttributeValue("", 1282, item.Description, 1282, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1300, "\"", 1322, 2);
#line 36 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
WriteAttributeValue("", 1306, item.NewsId, 1306, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1318, "-img", 1318, 4, true);
            EndWriteAttribute();
            BeginContext(1323, 56, true);
            WriteLiteral(" style=\"width:100%; height:auto;\" />\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n");
            EndContext();
#line 39 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                 if (item.Ratings.Count() > 0)
								{
									var rating = (int)(item.Ratings.Select(x => x.Rating).Average() * 100);

#line default
#line hidden
            BeginContext(1512, 118, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<div class=\"progress\" style=\"width:100%;\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"progress-bar bg-success\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1630, "\"", 1653, 3);
            WriteAttributeValue("", 1638, "width:", 1638, 6, true);
#line 43 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
WriteAttributeValue(" ", 1644, rating, 1645, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 1652, "%", 1652, 1, true);
            EndWriteAttribute();
            BeginContext(1654, 39, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\">");
            EndContext();
            BeginContext(1694, 6, false);
#line 43 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                                                         Write(rating);

#line default
#line hidden
            EndContext();
            BeginContext(1700, 26, true);
            WriteLiteral("%</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 45 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
								}

#line default
#line hidden
            BeginContext(1737, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                 if (item.User.UserName == User.Identity.Name || User.IsInRole("admin"))
								{
									

#line default
#line hidden
            BeginContext(1842, 82, false);
#line 49 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                               Write(Html.ActionLink(ViewData["Edit"].ToString(), "Edit", new { newsId = item.NewsId }));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 27, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<span> | </span>\r\n");
            EndContext();
            BeginContext(1963, 86, false);
#line 51 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                               Write(Html.ActionLink(ViewData["Delete"].ToString(), "Delete", new { newsId = item.NewsId }));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                           
								}

#line default
#line hidden
            BeginContext(2062, 42, true);
            WriteLiteral("\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 56 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(2111, 50, true);
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(2161, 534, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f58c64ff613c76b48be906042453c8aaa660917b17385", async() => {
                BeginContext(2167, 257, true);
                WriteLiteral(@"
				<div class=""card bg-light mb-3"" style=""max-width: 20rem;"">
					<div class=""card-body"">
						<div class=""row"">
							<div class=""col-md-6 col-sm-4 col-lg-8"" style=""padding-right:0; width:inherit;"">
								<input class=""form-control"" type=""text""");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2424, "\"", 2457, 1);
#line 65 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
WriteAttributeValue("", 2438, ViewData["Search"], 2438, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2458, 143, true);
                WriteLiteral(" name=\"searchString\">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-md-6 col-sm-4 col-lg-4\">\r\n\t\t\t\t\t\t\t\t<button class=\"btn btn-secondary\" type=\"submit\">");
                EndContext();
                BeginContext(2602, 18, false);
#line 68 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                           Write(ViewData["Search"]);

#line default
#line hidden
                EndContext();
                BeginContext(2620, 68, true);
                WriteLiteral("</button>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2695, 94, true);
            WriteLiteral("\r\n\t\t\t<div class=\"card bg-light mb-3\" style=\"max-width: 20rem;\">\r\n\t\t\t\t<div class=\"card-header\">");
            EndContext();
            BeginContext(2790, 29, false);
#line 75 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                    Write(ViewData["TopOfTheLast7Days"]);

#line default
#line hidden
            EndContext();
            BeginContext(2819, 37, true);
            WriteLiteral("</div>\r\n\t\t\t\t<div class=\"card-body\">\r\n");
            EndContext();
#line 77 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                     foreach (var item in Model.Where(x => x.Ratings.Count() > 0 && ((DateTime.Now.Date - x.Created).Days < 7)).OrderByDescending(x => x.Ratings.Average(rate => rate.Rating)).Take(5))
					{

#line default
#line hidden
            BeginContext(3050, 18, true);
            WriteLiteral("\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3068, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f58c64ff613c76b48be906042453c8aaa660917b21195", async() => {
                BeginContext(3146, 8, true);
                WriteLiteral("<strong>");
                EndContext();
                BeginContext(3155, 10, false);
#line 80 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                             Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3165, 9, true);
                WriteLiteral("</strong>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-newsId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                WriteLiteral(item.NewsId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["newsId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-newsId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["newsId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3178, 34, true);
            WriteLiteral(" <span class=\"badge badge-danger\">");
            EndContext();
            BeginContext(3213, 17, false);
#line 80 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                                                                       Write(item.Section.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3230, 29, true);
            WriteLiteral("</span> <span>-</span> <span>");
            EndContext();
            BeginContext(3261, 54, false);
#line 80 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                                                                                                                                                                                       Write((int)(item.Ratings.Average(rate => rate.Rating) * 100));

#line default
#line hidden
            EndContext();
            BeginContext(3316, 36, true);
            WriteLiteral("%</span>\r\n\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t<hr />\r\n");
            EndContext();
#line 83 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(3360, 115, true);
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card bg-light mb-3\" style=\"max-width: 20rem;\">\r\n\t\t\t\t<div class=\"card-header\">");
            EndContext();
            BeginContext(3476, 20, false);
#line 87 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                    Write(ViewData["TagCloud"]);

#line default
#line hidden
            EndContext();
            BeginContext(3496, 37, true);
            WriteLiteral("</div>\r\n\t\t\t\t<div class=\"card-body\">\r\n");
            EndContext();
#line 89 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                     foreach (var item in (Dictionary<string, int>)ViewData["tagSize"])
					{

#line default
#line hidden
            BeginContext(3615, 11, true);
            WriteLiteral("\t\t\t\t\t\t<span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3626, "\"", 3659, 3);
            WriteAttributeValue("", 3634, "font-size:", 3634, 10, true);
#line 91 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
WriteAttributeValue("", 3644, item.Value, 3644, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3657, "px", 3657, 2, true);
            EndWriteAttribute();
            BeginContext(3660, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3662, 8, false);
#line 91 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
                                                           Write(item.Key);

#line default
#line hidden
            EndContext();
            BeginContext(3670, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 92 "C:\Users\komar\source\repos\ITNews\ITNews.Web\Views\News\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(3687, 52, true);
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ITNews.Domain.Contracts.ViewModels.NewsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591