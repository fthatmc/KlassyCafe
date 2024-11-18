using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _ChefsComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
