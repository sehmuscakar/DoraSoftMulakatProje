﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly IContactCompanyManager _contactCompanyManager;

        public FooterViewComponent(IContactCompanyManager contactCompanyManager)
        {
            _contactCompanyManager = contactCompanyManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _contactCompanyManager.GetList();
            return View(listele);
        }
    }
}
