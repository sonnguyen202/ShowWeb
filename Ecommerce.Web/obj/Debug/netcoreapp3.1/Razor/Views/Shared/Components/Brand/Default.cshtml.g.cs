#pragma checksum "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\Shared\Components\Brand\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e69a323cd3399b2d108395a934426af3e7da373b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Brand_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Brand/Default.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\_ViewImports.cshtml"
using Ecommerce.Web;

#line default
#line hidden
#line 2 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\_ViewImports.cshtml"
using Ecommerce.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e69a323cd3399b2d108395a934426af3e7da373b", @"/Views/Shared/Components/Brand/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Brand_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Ecommerce.Service.ViewModels.Web.Homepage.ManufacturerHomepageViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-8 offset-sm-2 text-center colorlib-heading colorlib-heading-sm"">
            <h2><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Đối tác tin cậy</font></font></h2>
        </div>
    </div>
    <div id=""logo-carousel"">
");
#line 9 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\Shared\Components\Brand\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            WriteLiteral("            <div class=\"slide col-md-12\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e69a323cd3399b2d108395a934426af3e7da373b3779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 516, "~/images/", 516, 9, true);
#line 11 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\Shared\Components\Brand\Default.cshtml"
AddHtmlAttributeValue("", 525, item.UrlImage, 525, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#line 12 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\Shared\Components\Brand\Default.cshtml"
        }

#line default
#line hidden
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Ecommerce.Service.ViewModels.Web.Homepage.ManufacturerHomepageViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591