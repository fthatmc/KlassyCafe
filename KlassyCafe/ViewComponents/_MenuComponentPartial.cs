using KlassyCafe.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _MenuComponentPartial : ViewComponent
    {
        private readonly ICategoryServices _categoryService;

        public _MenuComponentPartial(ICategoryServices categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
    }
}
