#pragma checksum "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93742201dcd2d2a3fa8ecfbeb9690e917354fc4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminP_Views_Book_Detail), @"mvc.1.0.view", @"/Areas/AdminP/Views/Book/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminP/Views/Book/Detail.cshtml", typeof(AspNetCore.Areas_AdminP_Views_Book_Detail))]
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
#line 1 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#line 2 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\_ViewImports.cshtml"
using WebApplication1.View_Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93742201dcd2d2a3fa8ecfbeb9690e917354fc4a", @"/Areas/AdminP/Views/Book/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1af942e1a030faae5a37f4c29917522a6ef5de9", @"/Areas/AdminP/Views/_ViewImports.cshtml")]
    public class Areas_AdminP_Views_Book_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px; height:170px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-inverse-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/AdminP/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(120, 57, true);
            WriteLiteral("\r\n<h2>Book</h2>\r\n\r\n<div class=\"align-items-center\">\r\n    ");
            EndContext();
            BeginContext(177, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dbf9dc8b37c24dfa99a67a292b911111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 187, "~/img/", 187, 6, true);
#line 10 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml"
AddHtmlAttributeValue("", 193, Model.BookImage, 193, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(248, 10, true);
            WriteLiteral("\r\n    <h3>");
            EndContext();
            BeginContext(259, 14, false);
#line 11 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml"
   Write(Model.BookName);

#line default
#line hidden
            EndContext();
            BeginContext(273, 15, true);
            WriteLiteral("</h3>\r\n    <h4>");
            EndContext();
            BeginContext(289, 23, false);
#line 12 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml"
   Write(Model.Author.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(312, 14, true);
            WriteLiteral("</h4>\r\n    <p>");
            EndContext();
            BeginContext(327, 15, false);
#line 13 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml"
  Write(Model.BookPrice);

#line default
#line hidden
            EndContext();
            BeginContext(342, 14, true);
            WriteLiteral("</p>\r\n    <h5>");
            EndContext();
            BeginContext(357, 31, false);
#line 14 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml"
   Write(Model.BookCategory.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(388, 39, true);
            WriteLiteral("</h5>\r\n</div>\r\n<div class=\"mt-4\">\r\n    ");
            EndContext();
            BeginContext(428, 15, false);
#line 17 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Book\Detail.cshtml"
Write(Model.AboutBook);

#line default
#line hidden
            EndContext();
            BeginContext(443, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(453, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca9187a153524099969f1d3d45da5bfb", async() => {
                BeginContext(504, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(515, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
