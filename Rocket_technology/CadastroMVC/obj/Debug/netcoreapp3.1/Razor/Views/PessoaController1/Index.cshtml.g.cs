#pragma checksum "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75550f79ad499f09789601e8474f1649c235e653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PessoaController1_Index), @"mvc.1.0.view", @"/Views/PessoaController1/Index.cshtml")]
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
#line 1 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\_ViewImports.cshtml"
using Cadastro_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\_ViewImports.cshtml"
using Cadastro_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75550f79ad499f09789601e8474f1649c235e653", @"/Views/PessoaController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6899097f2994a84af44be42e7091689451c309d7", @"/Views/_ViewImports.cshtml")]
    public class Views_PessoaController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Lista de Registro</h1>

<!-- Criando uma tabela para mostrar os dados de forma organizada -->

<table class=""table table-bordered table-striped"">
    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Email</th>
        <th>Telefone</th>
        <th>EDITAR</th>
        <th>EXCLUIR</th>
    </tr>

    <!--O laço FOR será repetido quantas vezes forem o número de registros recuperados -->
");
#nullable restore
#line 21 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
     for(int i = 0; i < Model.Rows.Count; i++) 
    { 
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 25 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
   Write(Model.Rows[i][0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 26 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
   Write(Model.Rows[i][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 27 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
   Write(Model.Rows[i][2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 28 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
   Write(Model.Rows[i][3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 746, 1);
#nullable restore
#line 30 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
WriteAttributeValue("", 676, Url.Action("Edit", "PessoaController1", new { @id=@Model.Rows[i][0]}), 676, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EDITAR</a></td>\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 774, "\"", 853, 1);
#nullable restore
#line 31 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
WriteAttributeValue("", 781, Url.Action("Delete", "PessoaController1", new { @id=@Model.Rows[i][0]}), 781, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EXCLUIR</a></td>\n</tr>\n");
#nullable restore
#line 33 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 945, 1);
#nullable restore
#line 36 "C:\Users\macam\source\repos\Rocket_technology\CadastroMVC\Views\PessoaController1\Index.cshtml"
WriteAttributeValue("", 903, Url.Action("Create", "PessoaController1"), 903, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Novo Cadastro</a>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
