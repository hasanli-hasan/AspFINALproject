#pragma checksum "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b0d488c2fc009b1c0e110de3c85ff34df3fb4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Footer/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Footer_Default))]
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
#line 1 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#line 2 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.View_Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b0d488c2fc009b1c0e110de3c85ff34df3fb4d", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1af942e1a030faae5a37f4c29917522a6ef5de9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(14, 460, true);
            WriteLiteral(@"
<div class=""footer-container"">
    <div class=""footer-logo footer-childs"">
        <h1>Pandora</h1>
        <p>Book Store</p>
        <p>2020</p>
    </div>
    <div class=""footer-all-links footer-childs"">
        <h1><a href="""">Books</a></h1>
        <h1><a href="""">Blogs</a></h1>
        <h1><a href="""">Authors</a></h1>
        <h1><a href="""">Shopping Cart</a></h1>
    </div>
    <div class=""footer-contact footer-childs"">
        <h1>E-mail:");
            EndContext();
            BeginContext(475, 11, false);
#line 17 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
              Write(Model.email);

#line default
#line hidden
            EndContext();
            BeginContext(486, 25, true);
            WriteLiteral("</h1>\r\n        <h1>Phone:");
            EndContext();
            BeginContext(512, 12, false);
#line 18 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
             Write(Model.number);

#line default
#line hidden
            EndContext();
            BeginContext(524, 28, true);
            WriteLiteral("</h1>\r\n        <h1>Address: ");
            EndContext();
            BeginContext(553, 13, false);
#line 19 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
                Write(Model.address);

#line default
#line hidden
            EndContext();
            BeginContext(566, 94, true);
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"footer-sosial-icons footer-childs\">\r\n        <p><a href=\"\">");
            EndContext();
            BeginContext(661, 15, false);
#line 22 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
                 Write(Model.instagram);

#line default
#line hidden
            EndContext();
            BeginContext(676, 32, true);
            WriteLiteral("</a></p>\r\n        <p><a href=\"\">");
            EndContext();
            BeginContext(709, 15, false);
#line 23 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
                 Write(Model.pinterest);

#line default
#line hidden
            EndContext();
            BeginContext(724, 32, true);
            WriteLiteral("</a></p>\r\n        <p><a href=\"\">");
            EndContext();
            BeginContext(757, 13, false);
#line 24 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
                 Write(Model.behance);

#line default
#line hidden
            EndContext();
            BeginContext(770, 32, true);
            WriteLiteral("</a></p>\r\n        <p><a href=\"\">");
            EndContext();
            BeginContext(803, 14, false);
#line 25 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
                 Write(Model.facebook);

#line default
#line hidden
            EndContext();
            BeginContext(817, 32, true);
            WriteLiteral("</a></p>\r\n        <p><a href=\"\">");
            EndContext();
            BeginContext(850, 13, false);
#line 26 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\Shared\Components\Footer\Default.cshtml"
                 Write(Model.twitter);

#line default
#line hidden
            EndContext();
            BeginContext(863, 28, true);
            WriteLiteral("</a></p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
