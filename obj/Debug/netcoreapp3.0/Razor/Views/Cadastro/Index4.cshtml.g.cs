#pragma checksum "C:\Users\User\Documents\RoleTopMVC\Views\Cadastro\Index4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d427a065f73827d7eee26e8a52981bcf1fbcd1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Index4), @"mvc.1.0.view", @"/Views/Cadastro/Index4.cshtml")]
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
#line 1 "C:\Users\User\Documents\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d427a065f73827d7eee26e8a52981bcf1fbcd1b", @"/Views/Cadastro/Index4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Index4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon-google.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("GOOGLE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Cadastro100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main>\r\n\r\n\t<div class=\"limiter\">\r\n            <div class=\"container-Cadastro100\">\r\n                <div class=\"wrap-Cadastro100 p-l-50 p-r-50 p-t-77 p-b-30\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d427a065f73827d7eee26e8a52981bcf1fbcd1b4897", async() => {
                WriteLiteral(@"
                        <span class=""Cadastro100-form-title p-b-55"">
                            Cadastro
                        </span>
    
                        <div class=""wrap-input100 validate-input m-b-16"" data-validate = ""Valid email is required: ex@abc.xyz"">
                            <input class=""input100"" type=""text"" name=""nome"" placeholder=""Nome Completo"">
                            <span class=""focus-input100""></span>
                            <span class=""symbol-input100"">
                                <span class=""lnr lnr-envelope""></span>
                            </span>
                        </div>
    
                        <div class=""wrap-input100 validate-input m-b-16"" data-validate = ""Valid email is required: ex@abc.xyz"">
                                <input class=""input100"" type=""text"" name=""email"" placeholder=""Email"">
                                <span class=""focus-input100""></span>
                                <span class=""symbol-input100"">
 ");
                WriteLiteral(@"                                   <span class=""lnr lnr-envelope""></span>
                                </span>
                        </div>

                        <div class=""wrap-input100 validate-input m-b-16"" data-validate = ""Password is required"">
                            <input class=""input100"" type=""text"" name=""CPF ou CNPJ"" placeholder=""CPF ou CNPJ"">
                            <span class=""focus-input100""></span>
                            <span class=""symbol-input100"">
                            <span class=""lnr lnr-envelope""></span>
                            </span>
                        </div>

                        <div class=""wrap-input100 validate-input m-b-16"" data-validate = ""Password is required"">
                            <input class=""input100"" type=""text"" name=""celular"" placeholder=""Celular (xx) xxxx-xxxx"">
                            <span class=""focus-input100""></span>
                            <span class=""symbol-input100"">
                          ");
                WriteLiteral(@"      <span class=""lnr lnr-envelope""></span>
                            </span>
                        </div>

                        <div class=""wrap-input100 validate-input m-b-16"" data-validate = ""Password is required"">
                                <input class=""input100"" type=""password"" name=""senha"" placeholder=""Crie uma senha"">
                                <span class=""focus-input100""></span>
                                <span class=""symbol-input100"">
                                    <span class=""lnr lnr-lock""></span>
                                </span>
                        </div>
                        <div class=""container-Cadasrto100-form-btn p-t-25"">
                            <button type=""submit"" class=""Cadastro100-form-btn"">
                                Cadastrar-se 
                            </button>
                        </div>
    
                        <div class=""text-center w-full p-t-42 p-b-22"">
                            <span class=""txt");
                WriteLiteral(@"1"">
                                Cadastre-se também com 
                            </span>
                        </div>
    
                        <a href=""#"" class=""btn-face m-b-10"">
                            <i class=""fa fa-facebook-official""></i>
                            Facebook
                        </a>
    
                        <a href=""#"" class=""btn-google m-b-10"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1d427a065f73827d7eee26e8a52981bcf1fbcd1b8878", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            Google\r\n                        </a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 6 "C:\Users\User\Documents\RoleTopMVC\Views\Cadastro\Index4.cshtml"
AddHtmlAttributeValue("", 207, Url.Action("Cadastrar" , "Cadastro"), 207, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
