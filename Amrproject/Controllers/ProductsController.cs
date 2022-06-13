using Amrproject.IRepo;
using Amrproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amrproject.Controllers
{
    public class ProductsController : Controller

    {
        private readonly IProductsClassRepository ProductsClassRepository;


        public ProductsController(IProductsClassRepository _ProductsServices)
        {
            ProductsClassRepository = _ProductsServices;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products products)
        {
            if (ModelState.IsValid)
            {
                bool result = await ProductsClassRepository.Add(products);
                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
           
        }




    }
}

