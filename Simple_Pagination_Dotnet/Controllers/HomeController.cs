using Microsoft.AspNetCore.Mvc;
using Simple_Pagination_Dotnet.Interfaces;
using Simple_Pagination_Dotnet.Pagination;

namespace Simple_Pagination_Dotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] QueryParameters queryParameters)
        {
            if (queryParameters is null) queryParameters = new QueryParameters();
            return View(await _productRepository.GetAllAsync(queryParameters));
        }
    }
}