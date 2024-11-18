using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _ScriptComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
