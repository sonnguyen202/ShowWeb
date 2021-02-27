using Ecommerce.Domain.Models;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.Admin.SupplierModel;
using EcommerceCommon.Infrastructure.Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EcommerceCommon.Infrastructure.Helper.Helper;

namespace Ecommerce.Admin.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;
        private readonly IWebHostEnvironment _hostEnvironment;
        public SupplierController(ISupplierService supplierService, IWebHostEnvironment hostEnvironment)
        {
            _supplierService = supplierService;
            _hostEnvironment = hostEnvironment;
        }
        public async Task<IActionResult> GetSupplierList()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _supplierService.GetSupplierAdminViewModels();
            return View(model);
        }

        // GET: Supplier/Create
        [NoDirectAccess]
        public async Task<IActionResult> Create()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AddSupplierViewModel AddSupplierViewModel)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (ModelState.IsValid)
            {
                if (await _supplierService.AddSupplierAsync(AddSupplierViewModel))
                {
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", await _supplierService.GetSupplierAdminViewModels()) });
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Create", AddSupplierViewModel) });
        }

        // GET: Supplier/Edit/
        public async Task<ActionResult> Edit(Guid Id)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _supplierService.GetEditSupplierViewModel(Id);
            if (model == null)
                return NotFound();
            return View(model);
        }

        // POST: Supplier/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditSupplierViewModel EditSupplierViewModel)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (ModelState.IsValid)
            {
                if (await _supplierService.EditSupplierAsync(EditSupplierViewModel))
                {
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", await _supplierService.GetSupplierAdminViewModels()) });
                }
                else
                {
                    return NotFound();
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Edit", EditSupplierViewModel) });
        }

        // POST: Supplier/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (await _supplierService.DeleteSupplierAsync(id))
            {
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", await _supplierService.GetSupplierAdminViewModels()) });
            }
            else
            {
                return NotFound();
            }
        }
    }
}
