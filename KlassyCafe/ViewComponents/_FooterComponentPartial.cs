using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
