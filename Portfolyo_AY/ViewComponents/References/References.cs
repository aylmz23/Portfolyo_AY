using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;

namespace Portfolyo_AY.ViewComponents.References
{
    public class References : ViewComponent
    {
        MsSqlContext _context3 = new();
        public IViewComponentResult Invoke()
        {
            var data = _context3.References.ToList();
            return View(data);
        }
    }
}
