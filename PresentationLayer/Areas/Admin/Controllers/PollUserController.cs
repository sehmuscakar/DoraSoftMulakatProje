using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class PollUserController : Controller
    {
        private readonly IPollUserManager _pollUserManager;

        public PollUserController(IPollUserManager pollUserManager)
        {
            _pollUserManager = pollUserManager;
        }

        // GET: PollUserController
        public async Task<IActionResult> Index()
        {
            // var listele = _pollUserManager.GetList();
            var listeledto = _pollUserManager.GetPollUserListManager();
            return View(listeledto);
        }
        // GET: PollUserController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _pollUserManager.GetByID(id);
            return View(verigetir);
        }

        // POST: PollUserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, PollUser pollUser)
        {
            try
            {
                _pollUserManager.Remove(pollUser);
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
