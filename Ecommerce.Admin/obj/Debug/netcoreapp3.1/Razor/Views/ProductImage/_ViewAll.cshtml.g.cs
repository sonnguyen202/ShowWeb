#pragma checksum "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "316c76d63518fd1c2f7808cd78aaa88609593623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductImage__ViewAll), @"mvc.1.0.view", @"/Views/ProductImage/_ViewAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316c76d63518fd1c2f7808cd78aaa88609593623", @"/Views/ProductImage/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aa8b5ddcd2160cc6f2f80e1dac130565e22477", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductImage__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EcommerceCommon.Infrastructure.ViewModel.Admin.ProductImageAdminViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
  
    var stt = 1;

#line default
#line hidden
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Ảnh sản phẩm</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">Sản phẩm</a></li>
                        <li class=""breadcrumb-item active"">Ảnh sản phẩm</li>
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
                        <div class=""card-header");
            WriteLiteral("\">\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1171, "\"", 1303, 4);
            WriteAttributeValue("", 1181, "showInPopup(\'", 1181, 13, true);
#line 31 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
WriteAttributeValue("", 1194, Url.Action("Create","ProductImage",new { ProductId = ViewBag.ProductId},Context.Request.Scheme), 1194, 96, false);

#line default
#line hidden
            WriteAttributeValue("", 1290, "\',\'Thêm", 1290, 7, true);
            WriteAttributeValue(" ", 1297, "ảnh\')", 1298, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success text-white""><i class=""fas fa-pencil-alt""></i>Thêm mới</a>
                        </div>

                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""data-table"" class=""table table-bordered table-striped text-center"">
                                <thead>
                                    <tr>
                                        <th style=""width:30px !important"">STT</th>
                                        <th style=""width:200px !important"">Tên sản phẩm</th>
                                        <th style=""width:100px !important"">Màu sắc</th>
                                        <th style=""width:100px !important"">Ảnh</th>
                                        <th style=""width:100px !important"">Ảnh chính</th>
                                        <th style=""width:100px !important"">Chức năng</th>
                                    </tr>
                                </thead>
");
            WriteLiteral("                                <tbody>\r\n\r\n");
#line 49 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#line 52 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                       Write(stt);

#line default
#line hidden
            WriteLiteral("</td>\r\n                                        <td>");
#line 53 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                       Write(item.ProductName);

#line default
#line hidden
            WriteLiteral("</td>\r\n                                        <td> ");
#line 54 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                        Write(item.ColorName);

#line default
#line hidden
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "316c76d63518fd1c2f7808cd78aaa886095936239014", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2762, "~/images/", 2762, 9, true);
#line 55 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
AddHtmlAttributeValue("", 2771, item.ImageLink, 2771, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#line 56 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                         if (item.IsMainImage)
                                        {

#line default
#line hidden
            WriteLiteral("                                            <td>Có</td>\r\n");
#line 59 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            WriteLiteral("                                            <td>Không</td>\r\n");
#line 63 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                        }

#line default
#line hidden
            WriteLiteral("                                        <td>\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3306, "\"", 3422, 5);
            WriteAttributeValue("", 3316, "showInPopup(\'", 3316, 13, true);
#line 65 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
WriteAttributeValue("", 3329, Url.Action("Edit","ProductImage",new { id =item.Id},Context.Request.Scheme), 3329, 76, false);

#line default
#line hidden
            WriteAttributeValue("", 3405, "\',\'Cập", 3405, 6, true);
            WriteAttributeValue(" ", 3411, "nhật", 3412, 5, true);
            WriteAttributeValue(" ", 3416, "ảnh\')", 3417, 6, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Cập nhật ảnh\" class=\"btn btn-primary text-white \"><i class=\"fas fa-random\"></i></a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "316c76d63518fd1c2f7808cd78aaa8860959362312368", async() => {
                WriteLiteral(@"
                                                <button type=""submit"" title=""Xóa ảnh"" class=""btn btn-danger"">
                                                    <i class=""fa fa-trash"" aria-hidden=""true""></i>
                                                </button>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#line 73 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\ProductImage\_ViewAll.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EcommerceCommon.Infrastructure.ViewModel.Admin.ProductImageAdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
