#pragma checksum "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41650cdb10aed60b0c777c518f646f41eb64fc20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invullen_InvullenVoeding), @"mvc.1.0.view", @"/Views/Invullen/InvullenVoeding.cshtml")]
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
#line 1 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\_ViewImports.cshtml"
using GetHealthy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\_ViewImports.cshtml"
using GetHealthy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41650cdb10aed60b0c777c518f646f41eb64fc20", @"/Views/Invullen/InvullenVoeding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bd0c9836a1208c180f09e3317f7a78168973f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Invullen_InvullenVoeding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("InvullenVoeding"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
  
    ViewData["Title"] = "InvullenVoeding";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Wat heeft u vandaag gegeten?</h2>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41650cdb10aed60b0c777c518f646f41eb64fc205133", async() => {
                WriteLiteral("\r\n    <input type=\"search\" />\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 10 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
      
        foreach (GetHealthy.Models.ProductViewModel item in Model.ListA)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 322, "\"", 337, 1);
#nullable restore
#line 13 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
WriteAttributeValue("", 327, item.naam, 327, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Product\"");
                BeginWriteAttribute("value", " value=\"", 353, "\"", 371, 1);
#nullable restore
#line 13 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
WriteAttributeValue("", 361, item.naam, 361, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <label");
                BeginWriteAttribute("for", " for=\"", 393, "\"", 409, 1);
#nullable restore
#line 14 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
WriteAttributeValue("", 399, item.naam, 399, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
                               Write(item.naam);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 15 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n    <br />\r\n    <select name=\"hoeveelheid\" value=\"Hoeveelheid\" id=\"hoeveelheid\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41650cdb10aed60b0c777c518f646f41eb64fc207905", async() => {
                    WriteLiteral("Gram");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41650cdb10aed60b0c777c518f646f41eb64fc209134", async() => {
                    WriteLiteral("Milliliter");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </select>\r\n    <label for=\"hoeveelheid\">Hoeveel heeft u van dit product op?</label>\r\n    <br />\r\n    <br />\r\n    <input type=\"submit\" value=\"Toevoegen\"/>\r\n    <br />\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<input type=\"button\" value=\"Zelf toevoegen\" />\r\n<br />\r\n<br />\r\n<input type=\"button\" value=\"Berekenen\"");
            BeginWriteAttribute("onclick", " onclick=\"", 925, "\"", 998, 5);
            WriteAttributeValue("", 935, "window.location.href", 935, 20, true);
            WriteAttributeValue(" ", 955, "=", 956, 2, true);
            WriteAttributeValue(" ", 957, "\'", 958, 2, true);
#nullable restore
#line 33 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
WriteAttributeValue("", 959, Url.Action("Uitkomst", "Berekening"), 959, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 996, "\';", 996, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n<br />\r\n<br />\r\n<h5>Uw toegevoegde producten:</h5>\r\n<br />\r\n");
#nullable restore
#line 38 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
  
    foreach (GetHealthy.Controllers.Product item in Model.ListB)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a>");
#nullable restore
#line 41 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
      Write(item.naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <br />\r\n");
#nullable restore
#line 43 "C:\Users\Beheerder\OneDrive - Office 365 Fontys\Semester 2\Software redo\GetHealthyGit\GetHealthy\GetHealthy\Views\Invullen\InvullenVoeding.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
