#pragma checksum "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\DisplayTemplates\StudentiModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c3374547e9b9159fbca468dc2a83463166529d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_StudentiModel), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/StudentiModel.cshtml")]
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
#line 2 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\_ViewImports.cshtml"
using Naloga22.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\DisplayTemplates\StudentiModel.cshtml"
using Naloga22;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c3374547e9b9159fbca468dc2a83463166529d", @"/Views/Shared/DisplayTemplates/StudentiModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294e811519202b2c58a858ac1152a1e1d564ca72", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_StudentiModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Studenti>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <td>Ime</td>\r\n            <td>Priimek</td>\r\n            <td>Vpisna_stevilka</td>\r\n        </thead>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\DisplayTemplates\StudentiModel.cshtml"
           Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\DisplayTemplates\StudentiModel.cshtml"
           Write(Model.Priimek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\DisplayTemplates\StudentiModel.cshtml"
           Write(Model.Vpisna_stevilka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Studenti> Html { get; private set; }
    }
}
#pragma warning restore 1591