#pragma checksum "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Alumno\MultiAlumno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335c7b3ad7333c090fa63cc8d136e943055b276f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumno_MultiAlumno), @"mvc.1.0.view", @"/Views/Alumno/MultiAlumno.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alumno/MultiAlumno.cshtml", typeof(AspNetCore.Views_Alumno_MultiAlumno))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335c7b3ad7333c090fa63cc8d136e943055b276f", @"/Views/Alumno/MultiAlumno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983566fb01fc5d8bc045da7ba9cfca05d180e09e", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumno_MultiAlumno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alumno>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ListaObjetosEscuela", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Alumno\MultiAlumno.cshtml"
  
    ViewData["Title"] = "Informacion Alumno";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(99, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(106, 17, false);
#line 7 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Alumno\MultiAlumno.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 48, true);
            WriteLiteral("</h1>\r\n<strong>Desde la vista Parcial</strong>\r\n");
            EndContext();
            BeginContext(171, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fb7de971095747aa992fb07943f421eb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(207, 22, true);
            WriteLiteral("</partial>\r\n<p>Fecha: ");
            EndContext();
            BeginContext(230, 17, false);
#line 10 "D:\006 PERSONAL\AUTO APRENDIZAJE\ASP.NET\ProjectAsp\Views\Alumno\MultiAlumno.cshtml"
     Write(ViewData["Fecha"]);

#line default
#line hidden
            EndContext();
            BeginContext(247, 10, true);
            WriteLiteral("</partial>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alumno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
