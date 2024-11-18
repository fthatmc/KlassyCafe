using KlassyCafe.Services.SliderServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _SliderComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _SliderComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _sliderService.GetAllSliderIsSliderTrue();
            return View(values);
        }
    }
}
