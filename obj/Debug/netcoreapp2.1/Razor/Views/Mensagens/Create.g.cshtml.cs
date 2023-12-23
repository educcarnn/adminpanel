#pragma checksum "D:\Projetos\C#\cproject\Views\Mensagens\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb6e5a1dc530153a1d6278efcbdf0a695baa948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mensagens_Create), @"mvc.1.0.view", @"/Views/Mensagens/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mensagens/Create.cshtml", typeof(AspNetCore.Views_Mensagens_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb6e5a1dc530153a1d6278efcbdf0a695baa948", @"/Views/Mensagens/Create.cshtml")]
    public class Views_Mensagens_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mensagem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 370, true);
            WriteLiteral(@"
<h2>Nova Mensagem</h2>

<form id=""createForm"" asp-action=""Create"">
    <div class=""form-group"">
        <label asp-for=""Conteudo""></label>
        <input asp-for=""Conteudo"" class=""form-control"" />
    </div>
    <button type=""submit"" class=""btn btn-primary"">Salvar</button>
</form>

<a asp-action=""Index"" class=""btn btn-secondary"">Voltar para a Lista</a>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(405, 421, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            // Oculta o formulário inicialmente
            $(""#createForm"").hide();

            // Mostra o formulário ao clicar no link para criar uma nova mensagem
            $(""a[href$='/Mensagens/Create']"").click(function (e) {
                e.preventDefault();
                $(""#createForm"").show();
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mensagem> Html { get; private set; }
    }
}
#pragma warning restore 1591
