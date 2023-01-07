using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;
using Portfolyo_AY.Entities;

namespace Portfolyo_AY.Controllers
{

    public class MainController : Controller
    {
        MsSqlContext _context = new();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendMessage(ContactForm form)
        {
            _context.ContactForms.Add(form);
            _context.SaveChanges();
            return RedirectToAction("/Main/Index/#contact");
        }

    }
}
