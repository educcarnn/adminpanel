#pragma checksum "D:\Projetos\C#\cproject\Views\Mensagens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f9f79f38e76a9bd9597c4639cb76fdb9fbf21f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mensagens_Index), @"mvc.1.0.view", @"/Views/Mensagens/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mensagens/Index.cshtml", typeof(AspNetCore.Views_Mensagens_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f9f79f38e76a9bd9597c4639cb76fdb9fbf21f", @"/Views/Mensagens/Index.cshtml")]
    public class Views_Mensagens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mensagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 170, true);
            WriteLiteral("\r\n<h2>Mensagens</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Conteúdo</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 13 "D:\Projetos\C#\cproject\Views\Mensagens\Index.cshtml"
         foreach (var mensagem in Model)
        {

#line default
#line hidden
            BeginContext(246, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(285, 17, false);
#line 16 "D:\Projetos\C#\cproject\Views\Mensagens\Index.cshtml"
               Write(mensagem.Conteudo);

#line default
#line hidden
            EndContext();
            BeginContext(302, 69, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 371, "\"", 398, 1);
#line 18 "D:\Projetos\C#\cproject\Views\Mensagens\Index.cshtml"
WriteAttributeValue("", 386, mensagem.Id, 386, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(399, 57, true);
            WriteLiteral(">Editar</a> |\r\n                    <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 456, "\"", 483, 1);
#line 19 "D:\Projetos\C#\cproject\Views\Mensagens\Index.cshtml"
WriteAttributeValue("", 471, mensagem.Id, 471, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(484, 56, true);
            WriteLiteral(">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 22 "D:\Projetos\C#\cproject\Views\Mensagens\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(551, 68, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a asp-action=\"Create\">Nova Mensagem</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mensagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
