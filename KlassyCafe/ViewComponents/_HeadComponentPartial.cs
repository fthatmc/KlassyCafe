using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
