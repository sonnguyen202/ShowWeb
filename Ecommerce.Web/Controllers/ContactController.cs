using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceCommon.Infrastructure.ViewModel.Web;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> Contact(int? pageNumber)
        {
            var baseUrl = "https://localhost:44316/api";
            
            var pageSize = 4;
            var count = await baseUrl.AppendPathSegment("/Home/ProductCount").GetJsonAsync<int>();
            var page = Math.Ceiling((decimal)count / (decimal)pageSize);
            pageNumber = pageNumber == null ? 1 : pageNumber.Value;
            ViewBag.PageNumber = pageNumber;
            ViewBag.Page = page;
            var result = await baseUrl.AppendPathSegment("/Home/Index" ).SetQueryParams(new {pageNumber = pageNumber, pageSize = pageSize }).GetJsonAsync<List<ProductHomepage>>();
            return View(result);
        }
    }
}