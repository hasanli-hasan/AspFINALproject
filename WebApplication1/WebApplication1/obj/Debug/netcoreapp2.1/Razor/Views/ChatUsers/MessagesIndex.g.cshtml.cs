#pragma checksum "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edec3226918b7f9b204286aad35d99bd487a9941"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChatUsers_MessagesIndex), @"mvc.1.0.view", @"/Views/ChatUsers/MessagesIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChatUsers/MessagesIndex.cshtml", typeof(AspNetCore.Views_ChatUsers_MessagesIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edec3226918b7f9b204286aad35d99bd487a9941", @"/Views/ChatUsers/MessagesIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1af942e1a030faae5a37f4c29917522a6ef5de9", @"/Views/_ViewImports.cshtml")]
    public class Views_ChatUsers_MessagesIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessagesIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("removeA"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChatUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveConversation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("showAllMessages"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MessageList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
  
    ViewData["Title"] = "MessagesIndex";
    Layout = "~/Views/Shared/_MessageChat.cshtml";
    Conversation conv;

#line default
#line hidden
            BeginContext(142, 119, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"users-messageChat-main-container\">\r\n\r\n        <div class=\"users-search-header-row\">\r\n            ");
            EndContext();
            BeginContext(261, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31d1d6a8d34f4d18b87881018e22ee2c", async() => {
                BeginContext(267, 91, true);
                WriteLiteral("\r\n                <input id=\"userSrcForMsg\" type=\"text\" placeholder=\"Search\">\r\n            ");
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
            BeginContext(365, 266, true);
            WriteLiteral(@"
            <i id=""timesSearch"" class=""fas fa-search""></i>
            <i id=""timesCircle"" class=""fas fa-times-circle""></i>
            <span id=""searchSpinner"" class=""spinner"">Loading...</span>

            <div class=""message-chat-iconSet"">
                ");
            EndContext();
            BeginContext(631, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3d4d5645c564fa4a8b66b239ce5ba67", async() => {
                BeginContext(675, 67, true);
                WriteLiteral("\r\n                    <i class=\"fas fa-home\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(746, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(766, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae3045d0c15a4263bb38a41649b522ff", async() => {
                BeginContext(796, 74, true);
                WriteLiteral("\r\n                    <i class=\"fas fa-paper-plane\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(874, 60, true);
            WriteLiteral("\r\n\r\n                <div class=\"message-chatUserImageRow\">\r\n");
            EndContext();
#line 31 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                     if (@ViewBag.ExistImage == null)
                    {

#line default
#line hidden
            BeginContext(1012, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1036, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b49cf42e2a0f43e9867e83fa20da3ffc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1075, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1149, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1173, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0256fca5796a46c7be83e1ae91e3d6ba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1183, "~/img/", 1183, 6, true);
#line 37 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
AddHtmlAttributeValue("", 1189, ViewBag.ExistImage, 1189, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                    }

#line default
#line hidden
            BeginContext(1242, 461, true);
            WriteLiteral(@"
                </div>
            </div>


            <!--seacrh zamani gelen userlar start-->
            <div class=""SearchUserApend-row"">

            </div>
            <!--seacrh zamani gelen userlar end-->
        </div>

        <div class=""usersAll-listMessages-container"">

            <div class=""userAll-list-row"">
                <div class=""existUserName-header-row"">
                    <h1>
                        <a href="""">");
            EndContext();
            BeginContext(1704, 18, false);
#line 56 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                              Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1722, 125, true);
            WriteLiteral("</a>\r\n                    </h1>\r\n                </div>\r\n\r\n                <div class=\"existuser-messagesOtherUsers-row\">\r\n\r\n");
            EndContext();
#line 62 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                     foreach (var user in Model.Users)
                    {
                        if (User.Identity.Name != user.UserName)
                        {


#line default
#line hidden
            BeginContext(2021, 129, true);
            WriteLiteral("                            <div class=\"messagesOtherUsers-row\">\r\n                                <div class=\"OtherUser-image\">\r\n");
            EndContext();
#line 69 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                     if (user.Image == null)
                                    {

#line default
#line hidden
            BeginContext(2251, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2291, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32136938d2614a5d945e509a83c446be", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2330, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 72 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                        if (user.ConnectionId != null)
                                        {

#line default
#line hidden
            BeginContext(2447, 75, true);
            WriteLiteral("                                            <i class=\"fas fa-circle\"></i>\r\n");
            EndContext();
#line 75 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                        }
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2685, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2725, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84fc14cf27684919a6e5631062992d9b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2735, "~/img/", 2735, 6, true);
#line 79 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
AddHtmlAttributeValue("", 2741, user.Image, 2741, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2761, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                        if (user.ConnectionId != null)
                                        {

#line default
#line hidden
            BeginContext(2878, 75, true);
            WriteLiteral("                                            <i class=\"fas fa-circle\"></i>\r\n");
            EndContext();
#line 83 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(3035, 74, true);
            WriteLiteral("                                </div>\r\n\r\n                                ");
            EndContext();
            BeginContext(3109, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54c20427b2b649e8bd5fa619cf5be889", async() => {
                BeginContext(3208, 125, true);
                WriteLiteral("\r\n                                    <i id=\"rmvUserOther\" class=\"fas fa-times-circle\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                                                                             WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3337, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3371, 2295, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e73d03ac460e462fa1fc730f867ea0a3", async() => {
                BeginContext(3444, 116, true);
                WriteLiteral("\r\n                                    <div class=\"OtherUser-Name-row\">\r\n                                        <h4>");
                EndContext();
                BeginContext(3561, 13, false);
#line 92 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                       Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(3574, 9, true);
                WriteLiteral("</h4>\r\n\r\n");
                EndContext();
#line 95 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                         foreach (var item in Model.EachConv)
                                        {
                                            if (item.AcceptorId == user.Id || item.SenderId == user.Id)
                                            {
                                                conv = item;

                                                

#line default
#line hidden
#line 101 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                 foreach (var m in Model.Messages.Where(x => x.ConversationId == conv.Id).OrderByDescending(x => x.Id).Take(1))
                                                {
                                                    if (m.AppUserId == user.Id && m.IsRead == false)
                                                    {

#line default
#line hidden
                BeginContext(4392, 170, true);
                WriteLiteral("                                                        <div id=\"andUserLastMessage\">\r\n                                                            <b style=\"color:black\">");
                EndContext();
                BeginContext(4563, 9, false);
#line 106 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                                              Write(m.Content);

#line default
#line hidden
                EndContext();
                BeginContext(4572, 187, true);
                WriteLiteral("</b>\r\n                                                        </div>\r\n                                                        <time style=\"font-weight:100; color:#b4b3b3;\" class=\"timeago\"");
                EndContext();
                BeginWriteAttribute("datetime", " datetime=\"", 4759, "\"", 4810, 1);
#line 108 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
WriteAttributeValue("", 4770, m.dateTime.ToString("MM dd yyyy HH:mm"), 4770, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4811, 10, true);
                WriteLiteral("></time>\r\n");
                EndContext();
#line 109 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
                BeginContext(4989, 150, true);
                WriteLiteral("                                                        <div id=\"andUserLastMessage\">\r\n                                                            <p>");
                EndContext();
                BeginContext(5140, 9, false);
#line 113 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                          Write(m.Content);

#line default
#line hidden
                EndContext();
                BeginContext(5149, 71, true);
                WriteLiteral(" </p>\r\n                                                        </div>\r\n");
                EndContext();
                BeginContext(5222, 100, true);
                WriteLiteral("                                                        <time class=\"timeago\" style=\"color:#b4b3b3;\"");
                EndContext();
                BeginWriteAttribute("datetime", " datetime=\"", 5322, "\"", 5373, 1);
#line 116 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
WriteAttributeValue("", 5333, m.dateTime.ToString("MM dd yyyy HH:mm"), 5333, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5374, 10, true);
                WriteLiteral("></time>\r\n");
                EndContext();
#line 117 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                    }

                                                }

#line default
#line hidden
#line 119 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                 

                                            }
                                        }

#line default
#line hidden
                BeginContext(5584, 78, true);
                WriteLiteral("\r\n                                    </div>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"
                                                                                   WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5666, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 127 "C:\Users\Hasan\Desktop\final-p-asp\WebApplication1\WebApplication1\Views\ChatUsers\MessagesIndex.cshtml"

                        }
                    }

#line default
#line hidden
            BeginContext(5756, 433, true);
            WriteLiteral(@"
                </div>
            </div>

            <div class=""ExistUser-rigthMessages-Info-row"">


                <div class=""sendMessageicon"">
                    <i class=""far fa-paper-plane""></i>
                </div>
                <p>Your Messages</p>
                <p style=""margin-top:35px;"">Admin: <span style=""color:orangered;"">hasan-hasanli</span></p>
            </div>
        </div>

    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatVM> Html { get; private set; }
    }
}
#pragma warning restore 1591