#pragma checksum "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Studenti\efms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6c07d0faaec7b11a2ddf2f0553e230af0fa234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Studenti_efms), @"mvc.1.0.view", @"/Views/Studenti/efms.cshtml")]
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
#line 1 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Studenti\efms.cshtml"
using Naloga22;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6c07d0faaec7b11a2ddf2f0553e230af0fa234", @"/Views/Studenti/efms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294e811519202b2c58a858ac1152a1e1d564ca72", @"/Views/_ViewImports.cshtml")]
    public class Views_Studenti_efms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Studenti>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Studenti\efms.cshtml"
  
    ViewData["Title"] = "Vnesi studente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Studenti\efms.cshtml"
Write(Html.EditorForModel("StudentiModel"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Studenti> Html { get; private set; }
    }
}
#pragma warning restore 1591
