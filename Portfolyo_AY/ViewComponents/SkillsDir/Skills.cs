using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;

namespace Portfolyo_AY.ViewComponents.SkillsDir
{
    public class Skills : ViewComponent
    {
        MsSqlContext _context = new();
        public IViewComponentResult Invoke()
        {
            var data = _context.Skills.ToList();
            return View(data);
        }
    }
}
