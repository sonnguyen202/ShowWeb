#pragma checksum "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c95744f969a124f7d759134bcfff33f665ef39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductList_SearchProduct), @"mvc.1.0.view", @"/Views/ProductList/SearchProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c95744f969a124f7d759134bcfff33f665ef39", @"/Views/ProductList/SearchProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductList_SearchProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EcommerceCommon.Infrastructure.ViewModel.Web.ProductHomepage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:32px; height:32px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    var productPerPage = 4;
    var productNumber = Model.Count();
    var PageNumber = Math.Ceiling((double)(productNumber) / (double)(productPerPage));

#line default
#line hidden
            WriteLiteral("\r\n\r\n\r\n<div class=\"product-list\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"product-list-left\">\r\n                <div class=\"row\">\r\n\r\n");
#line 17 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                     if (ViewBag.ListSize != null)
                    {

#line default
#line hidden
            WriteLiteral(@"                        <div class=""col-sm-12"">
                            <div class=""side border mb-1"">
                                <h3>
                                    Kích thước
                                </h3>
                                <div class=""block-26 mb-2"">
                                    <ul>
");
#line 26 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                         foreach (var item in ViewBag.ListSize)
                                        {

#line default
#line hidden
            WriteLiteral("                                            <li><a href=\"#\">");
#line 28 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n");
#line 29 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                        }

#line default
#line hidden
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#line 34 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                    }

#line default
#line hidden
#line 35 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                     if (ViewBag.ListColor != null)
                    {

#line default
#line hidden
            WriteLiteral(@"                        <div class=""col-sm-12"">
                            <div class=""side border mb-1"">
                                <h3>
                                    Màu sắc
                                </h3>
                                <ul>
");
#line 43 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                     foreach (var item in ViewBag.ListColor)
                                    {

#line default
#line hidden
            WriteLiteral("                                        <li><a href=\"#\">");
#line 45 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
            WriteLiteral("</a></li>\r\n");
#line 46 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                    }

#line default
#line hidden
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n");
#line 50 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                    }

#line default
#line hidden
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"product-list-right\">\r\n                <div class=\"row row-pb-md paginate\">\r\n");
#line 58 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                     foreach (var item in Model)
                    {
                        if (Model.IndexOf(item) == productPerPage)
                        {
                            break;
                        }
                        if (item.ProductHomepageAttributeViewModel.Count != 0)
                        {

#line default
#line hidden
            WriteLiteral("                            <div class=\"col-md-3 text-left pb-3 item-paginate\">\r\n                                <div class=\"product-entry border\">\r\n                                    <div class=\"productimg\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2741, "\"", 2868, 1);
#line 69 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
WriteAttributeValue("", 2748, Url.Action("GetProductDetail","ProductDetail",new { ProductAttributeId = item.ProductHomepageAttributeViewModel[0].Id}), 2748, 120, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"prod-img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e7c95744f969a124f7d759134bcfff33f665ef399131", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2943, "~/images/", 2943, 9, true);
#line 70 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
AddHtmlAttributeValue("", 2952, item.ProductHomepageAttributeViewModel[0].UrlImage, 2952, 51, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 70 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
AddHtmlAttributeValue("", 3028, item.Name, 3028, 10, false);

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
            WriteLiteral("\r\n                                        </a>\r\n                                    </div>\r\n");
#line 73 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                     if (item.ProductHomepageAttributeViewModel.Count > 1)
                                    {

#line default
#line hidden
            WriteLiteral("                                        <ul class=\" product-image-color\">\r\n");
#line 76 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                             foreach (var item1 in item.ProductHomepageAttributeViewModel)
                                            {

#line default
#line hidden
            WriteLiteral("                                                <li style=\"width:34px ; height:32px\">\r\n                                                    <a class=\"prod-img color\"");
            BeginWriteAttribute("href", " href=\"", 3657, "\"", 3748, 1);
#line 79 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
WriteAttributeValue("", 3664, Url.Action("GetProductDetail","ProductDetail",new { ProductAttributeId = item1.Id}), 3664, 84, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3749, "\"", 3763, 1);
#line 79 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
WriteAttributeValue("", 3754, item1.Id, 3754, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e7c95744f969a124f7d759134bcfff33f665ef3912850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3833, "~/images/", 3833, 9, true);
#line 80 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
AddHtmlAttributeValue("", 3842, item1.UrlImage, 3842, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 80 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
AddHtmlAttributeValue("", 3882, item.Name, 3882, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </a>\r\n                                                </li>\r\n");
#line 83 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                            }

#line default
#line hidden
            WriteLiteral("                                        </ul>\r\n");
#line 85 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                    }

#line default
#line hidden
            WriteLiteral("                                    <div class=\"desc\">\r\n                                        <h2 class=\"text-center product-title\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4357, "\"", 4484, 1);
#line 88 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
WriteAttributeValue("", 4364, Url.Action("GetProductDetail","ProductDetail",new { ProductAttributeId = item.ProductHomepageAttributeViewModel[0].Id}), 4364, 120, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"prod-img\">\r\n                                                ");
#line 89 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            WriteLiteral(@"
                                            </a>
                                        </h2>
                                        <span class=""text-center price"">
                                            <del>
                                                <span class=""price-amount "">");
#line 94 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                                                       Write(item.ProductHomepageAttributeViewModel[0].Price);

#line default
#line hidden
            WriteLiteral("₫</span>\r\n                                            </del>\r\n                                            <ins>\r\n                                                <span class=\"price-amount \">\r\n                                                    ");
#line 98 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                               Write(item.ProductHomepageAttributeViewModel[0].PriceSale);

#line default
#line hidden
            WriteLiteral("₫\r\n");
            WriteLiteral("                                                </span>\r\n                                                <span class=\"percent deal\">-");
#line 101 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                                                                       Write(item.ProductHomepageAttributeViewModel[0].PercentSale);

#line default
#line hidden
            WriteLiteral("%</span>\r\n                                            </ins>\r\n                                        </span>\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#line 108 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
                        }
                    }

#line default
#line hidden
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#line 138 "C:\Users\Admin\Source\Repos\ShoeWeb\Ecommerce.Web\Views\ProductList\SearchProduct.cshtml"
Write(await Component.InvokeAsync("Brand"));

#line default
#line hidden
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EcommerceCommon.Infrastructure.ViewModel.Web.ProductHomepage>> Html { get; private set; }
    }
}
#pragma warning restore 1591