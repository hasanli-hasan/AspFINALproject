#pragma checksum "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\AuthorAbout\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6d1a5411ddd0a6b3f74a262f990cf7d4b98d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminP_Views_AuthorAbout_Detail), @"mvc.1.0.view", @"/Areas/AdminP/Views/AuthorAbout/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminP/Views/AuthorAbout/Detail.cshtml", typeof(AspNetCore.Areas_AdminP_Views_AuthorAbout_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6d1a5411ddd0a6b3f74a262f990cf7d4b98d30", @"/Areas/AdminP/Views/AuthorAbout/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1af942e1a030faae5a37f4c29917522a6ef5de9", @"/Areas/AdminP/Views/_ViewImports.cshtml")]
    public class Areas_AdminP_Views_AuthorAbout_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorAbout>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 200, true);
            WriteLiteral("\r\n<style>\r\n    .detail {\r\n        margin-top: 20px;\r\n        width: 500px;\r\n    }\r\n\r\n    img {\r\n        width: 100px;\r\n        height: 120px;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n    <div class=\"detail\">\r\n        ");
            EndContext();
            BeginContext(220, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "748763443cba45cabbb7797625dfcddc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 230, "~/img/", 230, 6, true);
#line 18 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\AuthorAbout\Detail.cshtml"
AddHtmlAttributeValue("", 236, Model.Image, 236, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(252, 50, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"detail\">\r\n        ");
            EndContext();
            BeginContext(303, 17, false);
#line 22 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\AuthorAbout\Detail.cshtml"
   Write(Model.NameSurname);

#line default
#line hidden
            EndContext();
            BeginContext(320, 69, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"detail\">\r\n        <p>  \r\n            ");
            EndContext();
            BeginContext(390, 16, false);
#line 27 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\AuthorAbout\Detail.cshtml"
       Write(Model.FrontTitle);

#line default
#line hidden
            EndContext();
            BeginContext(406, 108, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <h2>About Author</h2>\r\n    <div class=\"detail\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(515, 11, false);
#line 34 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\AuthorAbout\Detail.cshtml"
       Write(Model.About);

#line default
#line hidden
            EndContext();
            BeginContext(526, 108, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <h2>Author Books</h2>\r\n    <div class=\"detail\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(635, 14, false);
#line 41 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\AuthorAbout\Detail.cshtml"
       Write(Model.BookInfo);

#line default
#line hidden
            EndContext();
            BeginContext(649, 28, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591
