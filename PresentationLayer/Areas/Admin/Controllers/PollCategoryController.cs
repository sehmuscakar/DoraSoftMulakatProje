using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class PollCategoryController : Controller
    {
        private readonly IPollCategoryManager _pollCategoryManager;

        public PollCategoryController(IPollCategoryManager pollCategoryManager)
        {
            _pollCategoryManager = pollCategoryManager;
        }

        // GET: PollCategoryController
        public async Task<IActionResult> Index()
        {
            //   var listele = _pollCategoryManager.GetList();
            var listeledto = _pollCategoryManager.GetPollCategoryListManager();
            return View(listeledto);
        }


        // GET: PollCategoryController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: PollCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PollCategory pollCategory)
        {
            try
            {
                _pollCategoryManager.Add(pollCategory);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: PollCategoryController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var verigetir = _pollCategoryManager.GetByID(id);
            return View(verigetir);
        }

        // POST: PollCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PollCategory pollCategory)
        {
            try
            {
                _pollCategoryManager.Update(pollCategory);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: PollCategoryController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _pollCategoryManager.GetByID(id);
            return View(verigetir);
        }

        // POST: PollCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, PollCategory pollCategory)
        {
            try
            {
                _pollCategoryManager.Remove(pollCategory);
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
