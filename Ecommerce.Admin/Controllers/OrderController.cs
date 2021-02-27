using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.Admin.OrderModel;
using EcommerceCommon.Infrastructure.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Admin.Controllers
{
    [Route("order")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderHistoryService _orderHistoryService;
        public OrderController(IOrderService orderService, IOrderHistoryService orderHistoryService)
        {
            _orderService = orderService;
            _orderHistoryService = orderHistoryService;
        }
        [Route("")]
        public async Task<IActionResult> GetOrderList()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var models = await _orderService.GetOrderAdminViewModels();
            return View(models);
        }

        [Route("info/{code}")]
        public async Task<IActionResult> GetOrderInfo(string Code)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var models = await _orderService.GetOrderInfoAdminViewModelByCode(Code);
            return View(models);
        }
        [Route("history/{code}")]
        public async Task<IActionResult> GetOrderHistory(string Code)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var models = await _orderHistoryService.GetCustomerOrderHistoryModel(Code);
            return View(models);
        }
        [Route("edit/{code?}")]
        public async Task<IActionResult> Edit(string Code)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _orderService.GetEditOrderViewModel(Code);
            return View(model);
        }
        [Route("edit/{code?}")]
        [HttpPost]
        public async Task<IActionResult> Edit(EditOrderViewModel editOrderViewModel)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (await _orderService.EditOrderAsync(editOrderViewModel))
            {
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", await _orderService.GetOrderAdminViewModels()) });
            }
            else
            {
                return NotFound();
            }
            
        }

    }
}