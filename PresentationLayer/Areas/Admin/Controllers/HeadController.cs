using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class HeadController : Controller
    {
        private readonly IHeadManager _headManager;

        public HeadController(IHeadManager headManager)
        {
            _headManager = headManager;
        }

        // GET: HeadController
        public async Task<IActionResult> Index()
        {
            //  var listele = _headManager.GetList();
           var listeledto = _headManager.GetHeadListManager();
            return View(listeledto);
        }
        // GET: HeadController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: HeadController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Head head)
        {
            try
            {
              
                   _headManager.Add(head);
                
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: HeadController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var datagetir = _headManager.GetByID(id);
            return View(datagetir);
        }

        // POST: HeadController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Head head)
        {
            try
            {
               
                    _headManager.Update(head);
             
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: HeadController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var datagetir = _headManager.GetByID(id);
            return View(datagetir);
        }

        // POST: HeadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Head head)
        {
            try
            {
                _headManager.Remove(head);
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
