#pragma checksum "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bdb24c4ef7930cf60069c75bbd29abb9d2cf01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminP_Views_Sale_RecivedSales), @"mvc.1.0.view", @"/Areas/AdminP/Views/Sale/RecivedSales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminP/Views/Sale/RecivedSales.cshtml", typeof(AspNetCore.Areas_AdminP_Views_Sale_RecivedSales))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41bdb24c4ef7930cf60069c75bbd29abb9d2cf01", @"/Areas/AdminP/Views/Sale/RecivedSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1af942e1a030faae5a37f4c29917522a6ef5de9", @"/Areas/AdminP/Views/_ViewImports.cshtml")]
    public class Areas_AdminP_Views_Sale_RecivedSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SaleVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecivedSales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-google mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/AdminP/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(131, 28, true);
            WriteLiteral("\r\n<h2>Sales Archive</h2>\r\n\r\n");
            EndContext();
            BeginContext(159, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dde6b9d982b447b4b160e5ff758beb99", async() => {
                BeginContext(216, 21, true);
                WriteLiteral("\r\n    Recived Sales\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 804, true);
            WriteLiteral(@"

<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""table-responsive pt-3"">
                <table class=""table table-dark"">
                    <thead>
                        <tr>

                            <th>
                                FullName
                            </th>

                            <th>
                                Email
                            </th>
                            <th>
                                Date
                            </th>

                            <th>
                                Settings
                            </th>
                        </tr>
                    </thead>
                    <tbody>

");
            EndContext();
#line 41 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml"
                         foreach (SaleVM sale in Model)
                        {

                            if (sale.isRecived)
                            {

#line default
#line hidden
            BeginContext(1211, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1332, 13, false);
#line 48 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml"
                                   Write(sale.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1475, 10, false);
#line 52 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml"
                                   Write(sale.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1615, 9, false);
#line 56 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml"
                                   Write(sale.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1753, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c511cb8883fc44f799d1115cd8b4c56e", async() => {
                BeginContext(1824, 11, true);
                WriteLiteral("Detail Sale");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml"
                                                                 WriteLiteral(sale.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Areas\AdminP\Views\Sale\RecivedSales.cshtml"

                            }

                        }

#line default
#line hidden
            BeginContext(1985, 116, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SaleVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
