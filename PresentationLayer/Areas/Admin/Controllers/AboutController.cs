﻿using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AboutController : Controller
    {
        private readonly IAboutManager _aboutManager;

        public AboutController(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        // GET: AboutController
        public async Task<IActionResult> Index()
        {
            // var listele = _aboutManager.GetList();
            var listeledto = _aboutManager.GetAboutListManager();
            return View(listeledto);
        }


        // GET: AboutController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: AboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(About about, IFormFile? ImageUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    if (ImageUrl is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrl.CopyTo(stream1);
                        about.ImageUrl = ImageUrl.FileName;
                    }

                    _aboutManager.Add(about);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: AboutController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var verigetir=_aboutManager.GetByID(id);
            return View(verigetir);
        }

        // POST: AboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, About about, IFormFile? ImageUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    if (ImageUrl is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrl.CopyTo(stream1);
                        about.ImageUrl = ImageUrl.FileName;
                    }

                    _aboutManager.Update(about);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: AboutController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _aboutManager.GetByID(id);
            return View(verigetir);
        }

        // POST: AboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, About about)
        {
            try
            {
                _aboutManager.Remove(about);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }
    }
}
