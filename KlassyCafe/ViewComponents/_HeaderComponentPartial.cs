using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _HeaderComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
