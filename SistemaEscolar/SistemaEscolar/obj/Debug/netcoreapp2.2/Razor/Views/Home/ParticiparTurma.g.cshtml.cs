#pragma checksum "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "952e0908188931056ace98ec3a4f9754748b4a06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ParticiparTurma), @"mvc.1.0.view", @"/Views/Home/ParticiparTurma.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ParticiparTurma.cshtml", typeof(AspNetCore.Views_Home_ParticiparTurma))]
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
#line 1 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\_ViewImports.cshtml"
using SistemaEscolar;

#line default
#line hidden
#line 2 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\_ViewImports.cshtml"
using SistemaEscolar.Models;

#line default
#line hidden
#line 3 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\_ViewImports.cshtml"
using business;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"952e0908188931056ace98ec3a4f9754748b4a06", @"/Views/Home/ParticiparTurma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7faae4e139845f67ee8a513d9e732ccd3150fb06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ParticiparTurma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.Turma>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ParticiparTurma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
  
    ViewData["Title"] = "ParticiparTurma";

#line default
#line hidden
            BeginContext(76, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(80, 1842, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "952e0908188931056ace98ec3a4f9754748b4a065428", async() => {
                BeginContext(115, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(121, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "952e0908188931056ace98ec3a4f9754748b4a065813", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 9 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(187, 168, true);
                WriteLiteral("\r\n\r\n    <h1>Participar da Turma</h1>\r\n\r\n    <div>\r\n        <h4>Turma</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(356, 54, false);
#line 18 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayNameFor(model => model.LetraIdentificacao));

#line default
#line hidden
                EndContext();
                BeginContext(410, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(484, 50, false);
#line 21 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayFor(model => model.LetraIdentificacao));

#line default
#line hidden
                EndContext();
                BeginContext(534, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(607, 46, false);
#line 24 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroSala));

#line default
#line hidden
                EndContext();
                BeginContext(653, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(727, 42, false);
#line 27 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayFor(model => model.NumeroSala));

#line default
#line hidden
                EndContext();
                BeginContext(769, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(842, 44, false);
#line 30 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayNameFor(model => model.Materias));

#line default
#line hidden
                EndContext();
                BeginContext(886, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(960, 40, false);
#line 33 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayFor(model => model.Materias));

#line default
#line hidden
                EndContext();
                BeginContext(1000, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(1073, 43, false);
#line 36 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayNameFor(model => model.Horario));

#line default
#line hidden
                EndContext();
                BeginContext(1116, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(1190, 39, false);
#line 39 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayFor(model => model.Horario));

#line default
#line hidden
                EndContext();
                BeginContext(1229, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(1302, 42, false);
#line 42 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayNameFor(model => model.Escola));

#line default
#line hidden
                EndContext();
                BeginContext(1344, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(1418, 43, false);
#line 45 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayFor(model => model.Escola.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1461, 72, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                EndContext();
                BeginContext(1534, 51, false);
#line 48 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayNameFor(model => model.Escola.Endereco));

#line default
#line hidden
                EndContext();
                BeginContext(1585, 73, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
                EndContext();
                BeginContext(1659, 47, false);
#line 51 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
           Write(Html.DisplayFor(model => model.Escola.Endereco));

#line default
#line hidden
                EndContext();
                BeginContext(1706, 54, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(1760, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "952e0908188931056ace98ec3a4f9754748b4a0613218", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 56 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1796, 119, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Cadastrar\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1922, 15, true);
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1937, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "952e0908188931056ace98ec3a4f9754748b4a0616444", async() => {
                BeginContext(1959, 16, true);
                WriteLiteral("voltar para Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1979, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2009, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 67 "D:\Escola\SistemaEscolar\SistemaEscolar\Views\Home\ParticiparTurma.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<business.Turma> Html { get; private set; }
    }
}
#pragma warning restore 1591
