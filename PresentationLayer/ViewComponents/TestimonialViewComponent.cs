using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        private readonly ITestimonialManager _testimonialManager;

        public TestimonialViewComponent(ITestimonialManager testimonialManager)
        {
            _testimonialManager = testimonialManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _testimonialManager.GetList();
            return View(listele);
        }
    }
}
