using EnterpriseCoreMvc.Core.Products;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index()
        {
            var products = await _productsService.GetAllAsync();
            return View(products);
        }
    }
}