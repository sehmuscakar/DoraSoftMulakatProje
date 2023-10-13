using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialManager _testimonialManager;

        public TestimonialController(ITestimonialManager testimonialManager)
        {
            _testimonialManager = testimonialManager;
        }

        // GET: TestimonialController
        public async Task<IActionResult> Index()
        {
          //  var listele = _testimonialManager.GetList();
            var listeledto = _testimonialManager.GetTestimonialListManager();
            return View(listeledto);
        }

        // GET: TestimonialController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: TestimonialController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonial testimonial,IFormFile? Image)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Image is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        Image.CopyTo(stream1);
                        testimonial.Image = Image.FileName;
                    }
                   _testimonialManager.Add(testimonial);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var listele = _testimonialManager.GetById(id);
            return View(listele);
        }

        // POST: TestimonialController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Testimonial testimonial, IFormFile? Image)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Image is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        Image.CopyTo(stream1);
                        testimonial.Image = Image.FileName;
                    }
                    _testimonialManager.Update(testimonial);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var listele = _testimonialManager.GetById(id);
            return View(listele);
        }

        // POST: TestimonialController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Testimonial testimonial)
        {
            try
            {
                _testimonialManager.Remove(testimonial);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
