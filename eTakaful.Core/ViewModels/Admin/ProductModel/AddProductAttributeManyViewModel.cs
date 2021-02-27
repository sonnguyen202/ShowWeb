using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ecommerce.Service.ViewModels.Admin.ProductModel
{
    public class AddProductAttributeManyViewModel
    {
        public Guid ProductId { get; set; }
        [DisplayName("Kích cỡ")]
        public Guid ProductSizeId { get; set; }
        [DisplayName("Màu Sắc")]
        public Guid ProductColorId { get; set; }
        [DisplayName("Giá")]
        public string Price { get; set; }
        [DisplayName("Giá khuyến mãi")]
        public string DiscountPrice { get; set; }
        [DisplayName("Số lượng")]
        public string CountStock { get; set; }
    }
}
