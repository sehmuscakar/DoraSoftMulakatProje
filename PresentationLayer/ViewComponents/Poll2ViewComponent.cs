using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class Poll2ViewComponent:ViewComponent
    {
        private readonly IPollManager _pollManager;

        public Poll2ViewComponent(IPollManager pollManager)
        {
            _pollManager = pollManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _pollManager.GetPollListManager();
            return View(listele);
        }
    }
}
