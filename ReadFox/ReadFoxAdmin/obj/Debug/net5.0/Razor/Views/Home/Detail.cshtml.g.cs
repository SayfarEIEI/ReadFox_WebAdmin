#pragma checksum "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7582cf6964f41321c828721465c70aa9810180ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\_ViewImports.cshtml"
using ReadFoxAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\_ViewImports.cshtml"
using ReadFoxAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7582cf6964f41321c828721465c70aa9810180ae", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b987ac0a53e22758e304b80be47a1e0434f6a4a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Books>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Black", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>\r\n        ");
#nullable restore
#line 6 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
   Write(item.productName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h1>
    <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/Mq-r7f1agv0"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
    <p>ผู้แต่: ");
#nullable restore
#line 9 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
          Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>สำนักพิมพ์ผู้ถือลิขสิทธิ์ : ");
#nullable restore
#line 10 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
                              Write(item.pubisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>เนื้อเรื่องย่อ</h2>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
  Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>ราคา: ");
#nullable restore
#line 13 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
         Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" บาท</h2>\r\n");
            WriteLiteral("    <div class=\"row\" >\r\n        <div class=\"col\" >\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7582cf6964f41321c828721465c70aa9810180ae6864", async() => {
                WriteLiteral("\r\n                           <button type=\"submit\" class=\"btn btn-primary\" name=\"bookID\"");
                BeginWriteAttribute("value", " value=", 771, "", 790, 1);
#nullable restore
#line 18 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
WriteAttributeValue("", 778, item.bookID, 778, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</button>\r\n                   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\" >\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7582cf6964f41321c828721465c70aa9810180ae9279", async() => {
                WriteLiteral("\r\n                           <button type=\"submit\" class=\"btn btn-danger\" name=\"bookID\"");
                BeginWriteAttribute("value", " value=", 1022, "", 1041, 1);
#nullable restore
#line 23 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1029, item.bookID, 1029, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 1041, "\"", 1131, 5);
                WriteAttributeValue("", 1051, "return", 1051, 6, true);
                WriteAttributeValue(" ", 1057, "confirm(\'คุณต้องการทำการลบหนังสือเล่นนี้", 1058, 41, true);
                WriteAttributeValue(" ", 1098, ":", 1099, 2, true);
#nullable restore
#line 23 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"
WriteAttributeValue(" ", 1100, item.productName, 1101, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1118, "ใช่หรือไม่\')", 1119, 13, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</button>\r\n                   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\" >\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7582cf6964f41321c828721465c70aa9810180ae12201", async() => {
                WriteLiteral("\r\n                           <button type=\"submit\" class=\"btn btn-secondary\" >Back</button>\r\n                   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\comsa\OneDrive\เดสก์ท็อป\re\ReadFox_WebAdmin\ReadFox\ReadFoxAdmin\Views\Home\Detail.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Books>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
