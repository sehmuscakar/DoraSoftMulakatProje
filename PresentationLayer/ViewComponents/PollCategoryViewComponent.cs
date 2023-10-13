using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class PollCategoryViewComponent:ViewComponent
    {
        private readonly IPollCategoryManager _pollCategoryManager;

        public PollCategoryViewComponent(IPollCategoryManager pollCategoryManager)
        {
            _pollCategoryManager = pollCategoryManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _pollCategoryManager.GetList();
            return View(listele);
        }
    }
}
