#pragma checksum "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\BookCategory\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ce9ed5a9b8a23b4a422bd59b98c4b4c579dd21d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminP_Views_BookCategory_Detail), @"mvc.1.0.view", @"/Areas/AdminP/Views/BookCategory/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminP/Views/BookCategory/Detail.cshtml", typeof(AspNetCore.Areas_AdminP_Views_BookCategory_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ce9ed5a9b8a23b4a422bd59b98c4b4c579dd21d", @"/Areas/AdminP/Views/BookCategory/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1af942e1a030faae5a37f4c29917522a6ef5de9", @"/Areas/AdminP/Views/_ViewImports.cshtml")]
    public class Areas_AdminP_Views_BookCategory_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookCategory>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-inverse-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\BookCategory\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/AdminP/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(128, 74, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <h3>");
            EndContext();
            BeginContext(203, 18, false);
#line 9 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\BookCategory\Detail.cshtml"
           Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(221, 22, true);
            WriteLiteral("</h3>\r\n            <p>");
            EndContext();
            BeginContext(244, 27, false);
#line 10 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\BookCategory\Detail.cshtml"
          Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(271, 61, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(332, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70620578b13946049992877fc9f1d240", async() => {
                BeginContext(388, 39, true);
                WriteLiteral("\r\n                Go Back\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(431, 28, true);
            WriteLiteral("\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591