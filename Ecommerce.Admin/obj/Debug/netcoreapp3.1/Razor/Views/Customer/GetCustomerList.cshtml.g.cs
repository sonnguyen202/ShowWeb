#pragma checksum "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95df83861136270bafb2a03488a61686e4b6b284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetCustomerList), @"mvc.1.0.view", @"/Views/Customer/GetCustomerList.cshtml")]
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
#line 2 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
using EcommerceCommon.Infrastructure.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95df83861136270bafb2a03488a61686e4b6b284", @"/Views/Customer/GetCustomerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0aa8b5ddcd2160cc6f2f80e1dac130565e22477", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_GetCustomerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EcommerceCommon.Infrastructure.ViewModel.Admin.CustomerAdminViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
  
    ViewData["Title"] = "GetCustomerList";
    Layout = "~/Views/Shared/_Layout.cshtml";
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
                    <h1>Khách hàng</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
                        <li class=""breadcrumb-item active"">Khách hàng</li>
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
                    <div class=""card"">

                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table");
            WriteLiteral(@" id=""data-table"" class=""table table-bordered table-striped text-center"">
                                <thead>
                                    <tr >
                                        <th style=""width:30px !important""> STT </th>
                                        <th style=""width:120px !important""> Tên khách hàng </th>
                                        <th style=""width:80px !important""> Giới tính </th>
                                        <th style=""width:160px !important""> Địa chỉ </th>
                                        <th style=""width:80px !important""> Ngày sinh </th>
                                        <th style=""width:80px !important""> Số điện thoại </th>
                                        <th style=""width:100px !important""> Ảnh Avatar </th>
                                    </tr>
                                </thead>
                                <tbody>

");
#line 50 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#line 53 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                       Write(stt);

#line default
#line hidden
            WriteLiteral("</td>\r\n                                        <td>");
#line 54 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            WriteLiteral(" </td>\r\n");
#line 55 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                         if (item.Gender == Gender.Male)
                                        {

#line default
#line hidden
            WriteLiteral("                                            <td> Nam</td>\r\n");
#line 58 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            WriteLiteral("                                            <td> Nữ</td>\r\n");
#line 62 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                        }

#line default
#line hidden
            WriteLiteral("                                        <td>");
#line 63 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                       Write(item.Address);

#line default
#line hidden
            WriteLiteral("</td>\r\n                                        <td>");
#line 64 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                       Write(item.Birthday);

#line default
#line hidden
            WriteLiteral(" </td>\r\n                                        <td>");
#line 65 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
            WriteLiteral(" </td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "95df83861136270bafb2a03488a61686e4b6b2848604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3124, "~/images/", 3124, 9, true);
#line 66 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
AddHtmlAttributeValue("", 3133, item.AvatarUrl, 3133, 15, false);

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
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#line 68 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Admin\Views\Customer\GetCustomerList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EcommerceCommon.Infrastructure.ViewModel.Admin.CustomerAdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
