#pragma checksum "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "226a18b8dea46a2baadb92ac3f0982e1f441861a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_GetProductOrdered), @"mvc.1.0.view", @"/Views/Dashboard/GetProductOrdered.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\_ViewImports.cshtml"
using Ecommerce.Admin;

#line default
#line hidden
#line 2 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\_ViewImports.cshtml"
using Ecommerce.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226a18b8dea46a2baadb92ac3f0982e1f441861a", @"/Views/Dashboard/GetProductOrdered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aa8b5ddcd2160cc6f2f80e1dac130565e22477", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_GetProductOrdered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EcommerceCommon.Infrastructure.ViewModel.Admin.ProductOrderedAdminViewModel>>
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
#line 2 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
  
    var stt = 1;

#line default
#line hidden
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Sản phẩm bán ra</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
                        <li class=""breadcrumb-item active"">Sản phẩm bán ra</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card "">

                        <!-- /.card-header -->
                        <div class=""card-body"">
                         ");
            WriteLiteral(@"   <table id=""data-table"" class=""table table-bordered table-striped text-center"">
                                <thead>
                                    <tr>
                                        <th style=""width:400px !important"">Thông tin sản phẩm</th>
                                        <th style=""width:60px !important"">Số lượng bán ra</th>
                                        <th style=""width:100px !important"">Tổng doanh thu</th>
                                    </tr>
                                </thead>
                                <tbody>

");
#line 42 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            WriteLiteral("                                        <tr>\r\n                                            <td >\r\n                                                <div class=\"product-item\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "226a18b8dea46a2baadb92ac3f0982e1f441861a5517", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2065, "~/images/", 2065, 9, true);
#line 47 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
AddHtmlAttributeValue("", 2074, item.ProductImage, 2074, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 47 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
AddHtmlAttributeValue("", 2099, item.ProductName, 2099, 17, false);

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
            WriteLiteral("\r\n                                                    <div class=\"product-info\">\r\n                                                        ");
#line 49 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                                   Write(item.ProductName);

#line default
#line hidden
            WriteLiteral("\r\n");
#line 50 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                                         if (item.ProductColor != null)
                                                        {
                                                            

#line default
#line hidden
#line 52 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                                        Write(" ,Màu " + item.ProductColor + " ");

#line default
#line hidden
#line 52 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                                                                                 
                                                        }

#line default
#line hidden
#line 54 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                                         if (item.ProductSize != null)
                                                        {
                                                            

#line default
#line hidden
#line 56 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                                        Write(",Cỡ " + item.ProductSize + " ");

#line default
#line hidden
#line 56 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                                                                              
                                                        }

#line default
#line hidden
            WriteLiteral(@"                                                    </div>
                                                    
                                                </div>
                                                   
                                            </td>
                                            <td>");
#line 63 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                           Write(item.Quantity);

#line default
#line hidden
            WriteLiteral("</td>\r\n                                            <td>");
#line 64 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                            Write(item.TotalPrice);

#line default
#line hidden
            WriteLiteral("đ</td>\r\n                                        </tr>\r\n");
#line 66 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Dashboard\GetProductOrdered.cshtml"
                                        stt++;
                                    }

#line default
#line hidden
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EcommerceCommon.Infrastructure.ViewModel.Admin.ProductOrderedAdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591