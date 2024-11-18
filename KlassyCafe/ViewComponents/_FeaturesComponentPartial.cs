
using KlassyCafe.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _FeaturesComponentPartial : ViewComponent
    {
        private readonly IProductServices _productService;

        public _FeaturesComponentPartial(IProductServices productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _productService.GetProductIsFeatureTrue();
            return View(values);
        }
    }
}
