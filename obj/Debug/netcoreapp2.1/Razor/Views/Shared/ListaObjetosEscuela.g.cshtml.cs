#pragma checksum "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Shared\ListaObjetosEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "402d9b0dc1874081a569cb1e3315340843b127e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetosEscuela), @"mvc.1.0.view", @"/Views/Shared/ListaObjetosEscuela.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ListaObjetosEscuela.cshtml", typeof(AspNetCore.Views_Shared_ListaObjetosEscuela))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402d9b0dc1874081a569cb1e3315340843b127e5", @"/Views/Shared/ListaObjetosEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983566fb01fc5d8bc045da7ba9cfca05d180e09e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetosEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ObjetoEscuelaBase>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 197, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-dark table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Id</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 12 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Shared\ListaObjetosEscuela.cshtml"
     foreach (var obj in Model)
    {

#line default
#line hidden
            BeginContext(276, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(307, 10, false);
#line 15 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Shared\ListaObjetosEscuela.cshtml"
           Write(obj.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(317, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(341, 6, false);
#line 16 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Shared\ListaObjetosEscuela.cshtml"
           Write(obj.Id);

#line default
#line hidden
            EndContext();
            BeginContext(347, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 18 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Shared\ListaObjetosEscuela.cshtml"
    }

#line default
#line hidden
            BeginContext(376, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ObjetoEscuelaBase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
