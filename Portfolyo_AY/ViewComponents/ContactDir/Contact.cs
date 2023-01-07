using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;

namespace Portfolyo_AY.ViewComponents.ContactDir
{
    public class Contact : ViewComponent
    {
        MsSqlContext _context5 = new();
        public IViewComponentResult Invoke()
        {
            var data = _context5.Contacts.FirstOrDefault(x => x.Id == 1);
            return View(data);
        }
    }
}
