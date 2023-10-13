using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class PollViewComponent:ViewComponent
    {
        private readonly IPollManager _pollManager;

        public PollViewComponent(IPollManager pollManager)
        {
            _pollManager = pollManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _pollManager.GetPollListActiveManager();
            return View(listele);
        }

    }
}
