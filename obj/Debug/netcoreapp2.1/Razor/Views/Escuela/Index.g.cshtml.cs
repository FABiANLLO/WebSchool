#pragma checksum "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059188502035365068e69e51c4cbc31d0b8b24d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\_ViewImports.cshtml"
using ProjectAsp;

#line default
#line hidden
#line 2 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\_ViewImports.cshtml"
using ProjectAsp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"059188502035365068e69e51c4cbc31d0b8b24d2", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983566fb01fc5d8bc045da7ba9cfca05d180e09e", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Informacion Escuela";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(95, 15, true);
            WriteLiteral("\r\n<h1>Escuela: ");
            EndContext();
            BeginContext(111, 17, false);
#line 7 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
        Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(128, 19, true);
            WriteLiteral("</h1>\r\n<h2>Nombre: ");
            EndContext();
            BeginContext(148, 12, false);
#line 8 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(160, 29, true);
            WriteLiteral(" </h2>\r\n<h3>Tipo de Escuela: ");
            EndContext();
            BeginContext(190, 17, false);
#line 9 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(207, 36, true);
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Direccion: ");
            EndContext();
            BeginContext(244, 15, false);
#line 11 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(259, 24, true);
            WriteLiteral(" </p>\r\n    <p>Pais:     ");
            EndContext();
            BeginContext(284, 10, false);
#line 12 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
            Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(294, 24, true);
            WriteLiteral(" </p>\r\n    <p>Ciudad:   ");
            EndContext();
            BeginContext(319, 12, false);
#line 13 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
            Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(331, 46, true);
            WriteLiteral(" </p>\r\n</address>\r\n<p><strong>Anio Fundacion: ");
            EndContext();
            BeginContext(378, 19, false);
#line 15 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
                      Write(Model.AñoDeCreación);

#line default
#line hidden
            EndContext();
            BeginContext(397, 22, true);
            WriteLiteral(" </strong></p>\r\n<p><i>");
            EndContext();
            BeginContext(420, 24, false);
#line 16 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Escuela\Index.cshtml"
 Write(ViewData["CosaDinamica"]);

#line default
#line hidden
            EndContext();
            BeginContext(444, 8, true);
            WriteLiteral("</i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
