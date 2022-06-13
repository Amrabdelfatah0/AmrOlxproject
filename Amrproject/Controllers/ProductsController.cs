using Amrproject.IRepo;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}
