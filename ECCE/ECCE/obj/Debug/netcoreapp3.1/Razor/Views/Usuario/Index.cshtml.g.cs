#pragma checksum "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56aac5c1884a16a9ee532a8be3715dd2eabb8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56aac5c1884a16a9ee532a8be3715dd2eabb8e6", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    ViewData["Title"] = "Home Page";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div >\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th><h4>Clientes</h4></th>\r\n            <th></th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">

            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome</th>
                    <th>Email</th>
                    <th>Telefone</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                   Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                   Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 914, "\"", 1031, 7);
            WriteAttributeValue("", 924, "window.location.href=\'/usuario/editaradmin?CodigoLogin=", 924, 55, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 979, item.CodigoLogin, 979, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 996, "&Tipo=", 996, 6, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1002, item.Tipo, 1002, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1012, "&Ativo=", 1012, 7, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1019, item.Ativo, 1019, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1030, "\'", 1030, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 43 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            Sem Registros!\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\danie\Documents\GitHub\Projeto-E-commerce-Em-Casa-Com-Estilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
