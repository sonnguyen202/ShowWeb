using Ecommerce.Domain.Models;
using Ecommerce.Service.Interface;
using Ecommerce.Service.ViewModels.Admin.CollectionModel;
using Ecommerce.Service.ViewModels.Admin.CollectionModel;
using EcommerceCommon.Infrastructure.Helper;
using EcommerceCommon.Infrastructure.Ultil;
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
    public class CollectionController : Controller
    {
        // GET: CollectionImage
        private readonly ICollectionService _collectionService;
        private readonly IWebHostEnvironment _hostEnvironment;
        public CollectionController(ICollectionService collectionService, IWebHostEnvironment hostEnvironment)
        {
            _collectionService = collectionService;
            _hostEnvironment = hostEnvironment;
        }
        public async Task<IActionResult> GetCollectionList()
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var collection = await _collectionService.GetCollectionAdminViewModels();
            return View(collection);
        }

        // GET: Collection/Create
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
        public async Task<ActionResult> Create(AddCollectionViewModel AddCollectionViewModel)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (ModelState.IsValid)
            {
                if (await _collectionService.AddCollectionAsync(AddCollectionViewModel, _hostEnvironment.WebRootPath))
                {
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", await _collectionService.GetCollectionAdminViewModels()) });
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Create", AddCollectionViewModel) });
        }


        // GET: Collection/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = await _collectionService.GetEditCollectionViewModel(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: collection/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditCollectionViewModel EditCollectionViewModel)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (ModelState.IsValid)
            {
                if (await _collectionService.EditCollectionAsync(EditCollectionViewModel, _hostEnvironment.WebRootPath))
                {
                    return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", await _collectionService.GetCollectionAdminViewModels()) });

                }
                else
                {
                    return NotFound();
                }
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Edit", EditCollectionViewModel) });

        }

        // POST: Collection/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id)
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
            {
                return RedirectToAction("Login", "Login");
            }
            if (await _collectionService.DeleteCollectionAsync(id, _hostEnvironment.WebRootPath))
            {
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", await _collectionService.GetCollectionAdminViewModels()) });
            }
            else
            {
                return NotFound();
            }


        }

    }
}
