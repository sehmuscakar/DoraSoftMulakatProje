using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly IContactCompanyManager contactCompanyManager;

        public HeaderViewComponent(IContactCompanyManager contactCompanyManager)
        {
            this.contactCompanyManager = contactCompanyManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele =contactCompanyManager.GetList();
            return View(listele);
        }
    }
}
