using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;

namespace Portfolyo_AY.ViewComponents.AboutDir
{
    public class About : ViewComponent
    {
        MsSqlContext _context2 = new();
        public IViewComponentResult Invoke()
        {
            var data = _context2.Abouts.FirstOrDefault(x => x.Id == 1);
            return View(data);
        }
    }
}
