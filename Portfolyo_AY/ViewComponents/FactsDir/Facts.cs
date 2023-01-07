using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;

namespace Portfolyo_AY.ViewComponents.FactsDir
{
    public class Facts : ViewComponent
    {
        MsSqlContext _context4 = new();
        public IViewComponentResult Invoke()
        {
            var data = _context4.Facts.FirstOrDefault(x => x.Id == 1);
            return View(data);
        }
    }
}
