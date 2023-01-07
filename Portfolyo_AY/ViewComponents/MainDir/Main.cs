using Microsoft.AspNetCore.Mvc;

namespace Portfolyo_AY.ViewComponents.MainDir
{
    public class Main : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
