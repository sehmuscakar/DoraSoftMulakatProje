using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class PollController : Controller
    {
        private readonly IPollManager _pollManager;

        public PollController(IPollManager pollManager)
        {
            _pollManager = pollManager;
        }

        // GET: PollController
        public async Task<IActionResult> Index()
        {
            // var listele = _pollManager.GetList();
            var listeledto = _pollManager.GetPollListManager();
            return View(listeledto);
        }

        // GET: PollController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: PollController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Poll poll, IFormFile? ImageUrl)
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
                        poll.ImageUrl = ImageUrl.FileName;
                    }

                    _pollManager.Add(poll);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: PollController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var datagetir = _pollManager.GetByID(id);
            return View(datagetir);
        }

        // POST: PollController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Poll poll, IFormFile? ImageUrl)
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
                        poll.ImageUrl = ImageUrl.FileName;
                    }

                    _pollManager.Update(poll);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: PollController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var datagetir = _pollManager.GetByID(id);
            return View(datagetir);
        }

        // POST: PollController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Poll poll)
        {
            try
            {
                _pollManager.Remove(poll);   
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
