using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.Admin.OrderModel;
using Ecommerce.TestAPI;
using EcommerceCommon.Infrastructure.Helper;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ecommerce.Admin.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IUserProfileService _userProfileService ;



        public DashboardController(IProductService productService, IOrderService orderService, IUserProfileService userProfileService)
        {
            _productService = productService;
            _orderService = orderService;
            _userProfileService = userProfileService;

        }

        // GET: Dashboard
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            //var baseUrl = "https://localhost:44329/weatherforecast";
            //var result = await baseUrl.AppendPathSegment("/get").GetJsonAsync<List<WeatherForecast>>();
            ViewBag.ThisMonth = DateTime.Now.Month;
            ViewBag.TotalRevenueThisMonth = await _orderService.GetRevenueThisMonth();
            ViewBag.TotalRevenueThisYear = await _orderService.GetRevenueThisYear();
            ViewBag.TotalProduct = await _productService.GetTotalQuantityProductRemainAdmin();
            ViewBag.TotalQuantityProductOrdered = await _productService.GetTotalQuantityProductOrderedAdmin();
            ViewBag.NewOrders = await _orderService.GetOrderNewAdminViewModels();
            ViewBag.CountProcessOrder = await _orderService.GetCountOrderProcess();
            ViewBag.GetNewAccount = await _userProfileService.GetCountNewCustomer();
            return View();
        }
        public async Task<IActionResult> GetRevenueThisMonth()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var revenue = await _orderService.GetRevenueMonthAdminViewModels();
            var revenueJson = JsonConvert.SerializeObject(revenue);
            return Json(new { revenue = revenueJson});
        }
        public async Task<IActionResult> GetProductOrdered()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _productService.GetProductOrderedAdminViewModels();
            return View(model);
        }
        public async Task<IActionResult> GetProductRemain()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _productService.GetProductRemainAdminViewModels();
            return View(model);
        }

        public async Task<IActionResult> GetOrderProcess()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _orderService.GetOrderProcessAdminViewModels();
            return View(model);
        }

        public async Task<IActionResult> GetNewCustomer()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _userProfileService.GetNewCustomerAdminViewModels();
            return View(model);
        }
        public async Task<IActionResult> EditOrderProcess(string Code)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _orderService.GetEditOrderViewModel(Code);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditOrderProcess(EditOrderViewModel editOrderViewModel)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (await _orderService.EditOrderAsync(editOrderViewModel))
            {
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAllOrderProcess", await _orderService.GetOrderProcessAdminViewModels()) });
            }
            else
            {
                return NotFound();
            }

        }


    }
}