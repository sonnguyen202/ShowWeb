using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Models;
using Ecommerce.Service.ViewModels;
using Ecommerce.Service.ViewModels.Admin.ProductAttributeModel;
using Ecommerce.Service.ViewModels.Admin.ProductImageModel;
using Ecommerce.Service.ViewModels.Admin.ProductModel;
using Ecommerce.Service.ViewModels.Web.ProductDetail;
using EcommerceCommon.Infrastructure.ViewModel;
using EcommerceCommon.Infrastructure.ViewModel.Admin;
using EcommerceCommon.Infrastructure.ViewModel.Web;

namespace Ecommerce.Service.Interface
{
    public  interface IProductService : IServices<Product>
    {
        Task<List<ProductHomepage>> GetHotTrendProduct();
        Task<List<ProductHomepage>> GetProductTopView();
        Task<List<ProductHomepage>> GetProductByCategory(Guid CategoryId);
        Task<List<ProductHomepage>> GetProductByCategoryPagination(Guid CategoryId,int skip,int take);
        Task<ProductFirstAttributeViewModel> GetProductFirstAttributeByProductAttribute(Guid ProductAttributeId);
        Task<List<ProductAdminViewModel>> GetProductListAdminViewModel();
        Task<ProductDetailAdminViewModel> GetProductDetailAdminViewModel(Guid Id);
        Task<AddProductModel> GetAddProductModel();
        Task<AddProductModel> GetAddProductModel(AddProductViewModel addProductViewModel);
        Task<EditProductModel> GetEditProductModel(Guid Id);
        Task<EditProductModel> GetEditProductModel(EditProductViewModel editProductViewModel);
        Task<bool> CreateProduct(AddProductViewModel addProductViewModel, List<AddProductAttributeManyViewModel> listAttribute, List<AddProductImageViewModel> listImage, string wwwRootPath);
        Task<bool> EditProduct(EditProductViewModel editProductViewModel);
        Task<bool> DeleteProduct(Guid Id,string wwwRootPath);
        Task<int> GetTotalQuantityProductRemainAdmin();
        Task<int> GetTotalQuantityProductOrderedAdmin();
        Task<List<ProductOrderedAdminViewModel>> GetProductOrderedAdminViewModels();
        Task<List<ProductRemainAdminViewModel>> GetProductRemainAdminViewModels();
        Task<List<ProductHomepage>> SearchProduct(string keyword);
        Task<List<ProductHomepage>> GetProductHomepagesPaginate(int pageNumber, int pageSize);
    }
}
