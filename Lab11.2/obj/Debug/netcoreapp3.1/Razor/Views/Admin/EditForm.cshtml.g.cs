#pragma checksum "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38e13338b9395e82dcbd75f0f856d2400378dac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditForm), @"mvc.1.0.view", @"/Views/Admin/EditForm.cshtml")]
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
#line 1 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\_ViewImports.cshtml"
using Lab11._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\_ViewImports.cshtml"
using Lab11._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38e13338b9395e82dcbd75f0f856d2400378dac2", @"/Views/Admin/EditForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e2f099adacbc8f2812b5ead639467522eaee51e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml"
  
    ViewData["Title"] = "EditForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EditForm</h1>\r\n\r\n\r\n\r\n<h2>");
#nullable restore
#line 10 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38e13338b9395e82dcbd75f0f856d2400378dac24341", async() => {
                WriteLiteral("\r\n\r\n    Name: <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 196, "\"", 215, 1);
#nullable restore
#line 14 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 204, Model.name, 204, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    Description: <input type=\"text\" name=\"description\"");
                BeginWriteAttribute("value", " value=\"", 283, "\"", 309, 1);
#nullable restore
#line 16 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 291, Model.description, 291, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    Price: <input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 365, "\"", 385, 1);
#nullable restore
#line 18 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 373, Model.price, 373, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    Category: <input type=\"text\" name=\"category\"");
                BeginWriteAttribute("value", " value=\"", 447, "\"", 470, 1);
#nullable restore
#line 20 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 455, Model.category, 455, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 518, "\"", 535, 1);
#nullable restore
#line 22 "C:\Users\callen6\source\repos\Lab11.2\Lab11.2\Lab11.2\Views\Admin\EditForm.cshtml"
WriteAttributeValue("", 526, Model.id, 526, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <input type=\"submit\" />\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
