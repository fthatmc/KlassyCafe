using KlassyCafe.DAL.Context;
using KlassyCafe.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Controllers
{
    public class DefaultController : Controller
    {
        private readonly KlassyContext _context;
        private readonly IProductServices _productService;

        public DefaultController(KlassyContext context, IProductServices productService)
        {
            _context = context;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<PartialViewResult> GetProductListByCategory(int id)
        {
            var values = await _productService.GetProductListByCategoryAsync(id);
            return PartialView(values);
        }



        // rezervasyon yap kısmı yapılacak ajax ile
        // signalr tarafı kaldı
       
    }
}
