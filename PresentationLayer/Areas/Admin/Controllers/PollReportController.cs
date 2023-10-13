using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class PollReportController : Controller
    {
        private readonly IPollReportManager _pollReportManager;

        public PollReportController(IPollReportManager pollReportManager)
        {
            _pollReportManager = pollReportManager;
        }

        // GET: PollReportController
        public async Task<IActionResult> Index()
        {
            // var listele = _pollReportManager.GetList();
            var listeledto = _pollReportManager.GetPollReportListManager();
            return View(listeledto);
        }



        // GET: PollReportController/Create
        public async Task<IActionResult> Create()
        {

            return View();
        }

        // POST: PollReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PollReport pollReport)
        {
            try
            {
                _pollReportManager.Add(pollReport);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: PollReportController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var datagetir = _pollReportManager.GetByID(id);
            return View(datagetir);
        }

        // POST: PollReportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,PollReport pollReport)
        {
            try
            {
                _pollReportManager.Update(pollReport);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: PollReportController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var datagetir = _pollReportManager.GetByID(id);
            return View(datagetir);
        }

        // POST: PollReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, PollReport pollReport)
        {
            try
            {
                _pollReportManager.Remove(pollReport);
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
