#pragma checksum "D:\pacientesPessoas-master\Views\Home\Teste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd6a7e340f715b3c19f417d9c7b179ad2735f6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Teste), @"mvc.1.0.view", @"/Views/Home/Teste.cshtml")]
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
#line 1 "D:\pacientesPessoas-master\Views\_ViewImports.cshtml"
using pacientesPessoas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pacientesPessoas-master\Views\_ViewImports.cshtml"
using pacientesPessoas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd6a7e340f715b3c19f417d9c7b179ad2735f6b", @"/Views/Home/Teste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb2b0022aa12070552521201df2448190654bce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Teste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pacientesPessoas.Models.Pacientes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
  
    ViewData["Title"] = "Teste";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>Fazendo um teste.</p>\n\n<div class=\"container\">\n    <table class=\"table\">\n        <tr>\n            <th>");
#nullable restore
#line 12 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 13 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
           Write(Html.DisplayNameFor(model => model.idPessoa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 14 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
           Write(Html.DisplayNameFor(model => model.data_entrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 15 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
           Write(Html.DisplayNameFor(model => model.comorbidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 16 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
           Write(Html.DisplayNameFor(model => model.grau));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        </tr>\n");
#nullable restore
#line 18 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 21 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
               Write(Html.DisplayFor(modelItem => item.idPessoa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
               Write(Html.DisplayFor(modelItem => item.data_entrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
               Write(Html.DisplayFor(modelItem => item.comorbidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
               Write(Html.DisplayFor(modelItem => item.grau));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 27 "D:\pacientesPessoas-master\Views\Home\Teste.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<pacientesPessoas.Models.Pacientes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
