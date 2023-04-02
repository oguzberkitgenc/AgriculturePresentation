using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContectController : Controller
    {
        private readonly IContactService _contactService;

        public ContectController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteMEssage(int id)
        {
            var values=_contactService.GetById(id);
            _contactService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var values=_contactService.GetById(id);
            return View(values);
        }
    }
}
