#pragma checksum "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d47cf82c87c6af8a2b20109d3e91e19525ebce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registracija4), @"mvc.1.0.view", @"/Views/Home/Registracija4.cshtml")]
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
#line 1 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\_ViewImports.cshtml"
using Naloga22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\_ViewImports.cshtml"
using Naloga22.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d47cf82c87c6af8a2b20109d3e91e19525ebce", @"/Views/Home/Registracija4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294e811519202b2c58a858ac1152a1e1d564ca72", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registracija4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Registracija4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
  
    ViewData["Title"] = "Registracija4";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Uspešna registracija!</h1>\r\n    <p>Vaši podatki: </p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d47cf82c87c6af8a2b20109d3e91e19525ebce4346", async() => {
                WriteLiteral("\r\n        <label>Ime: ");
#nullable restore
#line 10 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
               Write(TempData["Ime"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Priimek: ");
#nullable restore
#line 11 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                   Write(TempData["Priimek"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Datum rojstva: ");
#nullable restore
#line 12 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                         Write(TempData["Datum rojstva"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>EMŠO: ");
#nullable restore
#line 13 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                Write(TempData["EMSO"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Starost: ");
#nullable restore
#line 14 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                   Write(TempData["Starost"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Naslov: ");
#nullable restore
#line 15 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                  Write(TempData["Naslov"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Poštna številka: ");
#nullable restore
#line 16 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                           Write(TempData["Postna_stevilka"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Pošta: ");
#nullable restore
#line 17 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                 Write(TempData["Posta"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Države: ");
#nullable restore
#line 18 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                  Write(TempData["Drzava"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>E-pošta: ");
#nullable restore
#line 19 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                   Write(TempData["E-posta"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n        <label>Geslo: ");
#nullable restore
#line 20 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Home\Registracija4.cshtml"
                 Write(TempData["Geslo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> <br />\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
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
