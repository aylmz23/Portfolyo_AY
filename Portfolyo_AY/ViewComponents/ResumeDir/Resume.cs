using Microsoft.AspNetCore.Mvc;

namespace Portfolyo_AY.ViewComponents.ResumeDir
{
    public class Resume : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
