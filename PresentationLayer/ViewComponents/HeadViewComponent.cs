using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class HeadViewComponent:ViewComponent
    {
        private readonly IHeadManager _headManager;

        public HeadViewComponent(IHeadManager headManager)
        {
            _headManager = headManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _headManager.GetList();
            return View(listele);
        }

    }
}
