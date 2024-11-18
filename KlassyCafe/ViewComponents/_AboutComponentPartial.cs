using KlassyCafe.Services.AboutUsServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly IAboutUsServices _aboutUsServices;

        public _AboutComponentPartial(IAboutUsServices aboutUsServices)
        {
            _aboutUsServices = aboutUsServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _aboutUsServices.GetAllAboutUsWithImageAndVideoAsync();
            return View(values);
        }
    }
}
