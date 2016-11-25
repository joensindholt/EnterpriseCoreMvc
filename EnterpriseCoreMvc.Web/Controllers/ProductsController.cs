using EnterpriseCoreMvc.Core.Products;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseCoreMvc.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productsService;

        public ProductsController(IProductService productsService)
        {
            _productsService = productsService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = _productsService.GetAll();
            return View(products);
        }
    }
}