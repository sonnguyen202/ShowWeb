#pragma checksum "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6843f319d71a29e45fd7a9a48a5bb6facbbc6ffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manufacturer__ViewAll), @"mvc.1.0.view", @"/Views/Manufacturer/_ViewAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6843f319d71a29e45fd7a9a48a5bb6facbbc6ffb", @"/Views/Manufacturer/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aa8b5ddcd2160cc6f2f80e1dac130565e22477", @"/Views/_ViewImports.cshtml")]
    public class Views_Manufacturer__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ecommerce.Service.ViewModels.Admin.ManufacturerModel.ManufacturerAdminViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("manufacturer-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px ; height:60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
   
    var stt = 1;

#line default
#line hidden
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Nhà sản xuất</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
                        <li class=""breadcrumb-item active"">Nhà sản xuất</li>
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
                        <div class=""card-header "">
                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1098, "\"", 1210, 7);
            WriteAttributeValue("", 1108, "showInPopup(\'", 1108, 13, true);
#line 31 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
WriteAttributeValue("", 1121, Url.Action("Create","Manufacturer",null,Context.Request.Scheme), 1121, 64, false);

#line default
#line hidden
            WriteAttributeValue("", 1185, "\',\'Tạo", 1185, 6, true);
            WriteAttributeValue(" ", 1191, "mới", 1192, 4, true);
            WriteAttributeValue(" ", 1195, "nhà", 1196, 4, true);
            WriteAttributeValue(" ", 1199, "sản", 1200, 4, true);
            WriteAttributeValue(" ", 1203, "xuất\')", 1204, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success text-white""><i class=""fas fa-pencil-alt""></i>Thêm mới</a>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""data-table"" class=""table table-bordered table-striped text-center"">
                                <thead>
                                    <tr>
                                        <th style=""width:30px !important""> STT </th>
                                        <th style=""width:100px !important""> Logo</th>
                                        <th style=""width:120px !important""> Tên nhà sản xuất</th>
                                        <th style=""width:120px !important""> Mã nhà sản xuất</th>
                                        <th style=""width:120px !important""> Website</th>
                                        <th> Mô tả </th>
                                        <th style=""width:80px !important""> Chức năng </th>
           ");
            WriteLiteral("                         </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#line 48 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#line 51 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                           Write(stt);

#line default
#line hidden
            WriteLiteral("</td>\r\n                                            <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6843f319d71a29e45fd7a9a48a5bb6facbbc6ffb8977", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2619, "~/images/", 2619, 9, true);
#line 52 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
AddHtmlAttributeValue("", 2628, item.Logo, 2628, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
AddHtmlAttributeValue("", 2645, item.Name, 2645, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  </td>\r\n                                            <td> ");
#line 53 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                            Write(item.Name);

#line default
#line hidden
            WriteLiteral("  </td>\r\n                                            <td> ");
#line 54 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                            Write(item.CodeName);

#line default
#line hidden
            WriteLiteral("  </td>\r\n                                            <td> ");
#line 55 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                            Write(item.Website);

#line default
#line hidden
            WriteLiteral("  </td>\r\n                                            <td>");
#line 56 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                           Write(item.Description);

#line default
#line hidden
            WriteLiteral(" </td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3109, "\"", 3234, 7);
            WriteAttributeValue("", 3119, "showInPopup(\'", 3119, 13, true);
#line 58 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
WriteAttributeValue("", 3132, Url.Action("Edit","Manufacturer",new { id =item.Id},Context.Request.Scheme), 3132, 76, false);

#line default
#line hidden
            WriteAttributeValue("", 3208, "\',\'Cập", 3208, 6, true);
            WriteAttributeValue(" ", 3214, "nhật", 3215, 5, true);
            WriteAttributeValue(" ", 3219, "nhà", 3220, 4, true);
            WriteAttributeValue(" ", 3223, "sản", 3224, 4, true);
            WriteAttributeValue(" ", 3227, "xuất\')", 3228, 7, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Cập nhật nhà sản xuất\" class=\"btn btn-primary text-white \"><i class=\"fas fa-random\"></i></a>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6843f319d71a29e45fd7a9a48a5bb6facbbc6ffb13254", async() => {
                WriteLiteral(@"
                                                    <button type=""submit"" title=""Xóa nhà sản xuất"" class=""btn btn-danger"">
                                                        <i class=""fa fa-trash"" aria-hidden=""true""></i>
                                                    </button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#line 66 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Manufacturer\_ViewAll.cshtml"
                                        stt++;
                                    }

#line default
#line hidden
            WriteLiteral(@"
                                </tbody>
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
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ecommerce.Service.ViewModels.Admin.ManufacturerModel.ManufacturerAdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591