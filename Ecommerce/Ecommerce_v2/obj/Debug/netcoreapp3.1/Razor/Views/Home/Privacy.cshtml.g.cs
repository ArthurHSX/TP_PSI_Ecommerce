#pragma checksum "C:\Users\guste\Desktop\Faculdade\TP_PSI_Ecommerce\Ecommerce\Ecommerce_v2\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717e8b4b30517fdf70a63df3311119b827993705"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\guste\Desktop\Faculdade\TP_PSI_Ecommerce\Ecommerce\Ecommerce_v2\Views\_ViewImports.cshtml"
using Ecommerce_v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guste\Desktop\Faculdade\TP_PSI_Ecommerce\Ecommerce\Ecommerce_v2\Views\_ViewImports.cshtml"
using Ecommerce_v2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717e8b4b30517fdf70a63df3311119b827993705", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790fe405b544c788cc3c39f91ba24b034de3ae0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\guste\Desktop\Faculdade\TP_PSI_Ecommerce\Ecommerce\Ecommerce_v2\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Cadastro de usuário";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row main\">\r\n        <div class=\"main-login main-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "717e8b4b30517fdf70a63df3311119b8279937054624", async() => {
                WriteLiteral(@"

                <div class=""form-group"">
                    <label for=""name"" class=""cols-sm-2 control-label"">Your Name</label>
                    <div class=""cols-sm-10"">
                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""fa fa-user fa"" aria-hidden=""true""></i></span>
                            <input type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Enter your Name"" />
                        </div>
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""email"" class=""cols-sm-2 control-label"">Your Email</label>
                    <div class=""cols-sm-10"">
                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""fa fa-envelope fa"" aria-hidden=""true""></i></span>
                            <input type=""text"" class=""form-control"" name=""email"" id=""email"" placeholder=""Enter you");
                WriteLiteral(@"r Email"" />
                        </div>
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""username"" class=""cols-sm-2 control-label"">Username</label>
                    <div class=""cols-sm-10"">
                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""fa fa-users fa"" aria-hidden=""true""></i></span>
                            <input type=""text"" class=""form-control"" name=""username"" id=""username"" placeholder=""Enter your Username"" />
                        </div>
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""password"" class=""cols-sm-2 control-label"">Password</label>
                    <div class=""cols-sm-10"">
                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""fa fa-lock fa-lg"" aria-hidden=""true""></i></span>
   ");
                WriteLiteral(@"                         <input type=""password"" class=""form-control"" name=""password"" id=""password"" placeholder=""Enter your Password"" />
                        </div>
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""confirm"" class=""cols-sm-2 control-label"">Confirm Password</label>
                    <div class=""cols-sm-10"">
                        <div class=""input-group"">
                            <span class=""input-group-addon""><i class=""fa fa-lock fa-lg"" aria-hidden=""true""></i></span>
                            <input type=""password"" class=""form-control"" name=""confirm"" id=""confirm"" placeholder=""Confirm your Password"" />
                        </div>
                    </div>
                </div>

                <div class=""form-group "">
                    <button type=""button"" class=""btn btn-primary btn-lg btn-block login-button"">Register</button>
                </div>
                <div class=""login-r");
                WriteLiteral("egister\">\r\n                    <a href=\"index.php\">Login</a>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
