#pragma checksum "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e31a7e6698cfe238718252b60e45fd6b541dda3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_c), @"mvc.1.0.view", @"/Views/Shared/c.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e31a7e6698cfe238718252b60e45fd6b541dda3", @"/Views/Shared/c.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294e811519202b2c58a858ac1152a1e1d564ca72", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_c : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Studenti>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Student</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Ime</th>\r\n        <th>Priimek</th>\r\n        <th>Vpisna_stevilka</th>\r\n    </tr>\r\n");
#nullable restore
#line 11 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
           Write(student.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
           Write(student.Priimek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
           Write(student.Vpisna_stevilka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
 using (Html.BeginForm("Delete", "Izpis", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Izbrisi po vpisni stevilki</h4>\r\n        <hr />\r\n\r\n        <input type=\"text\" id=\"Vpisna_Stevilka\" name=\"Vpisna_Stevilka\"><br><br>\r\n\r\n        <input id=\"Submit\" type=\"Submit\" value=\"Delete\" />\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
 if (TempData["msg_Vide"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        alert(\'");
#nullable restore
#line 39 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
          Write(Html.Raw(TempData["msg_Vide"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n    </script>\r\n");
#nullable restore
#line 41 "C:\Users\mihah\OneDrive\Desktop\2.letnik\2.Semester\DSR\Naloga6\Naloga22\Naloga22\Views\Shared\c.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Studenti>> Html { get; private set; }
    }
}
#pragma warning restore 1591
