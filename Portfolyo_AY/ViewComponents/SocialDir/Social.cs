using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;

namespace Portfolyo_AY.ViewComponents.SocialDir
{

    public class Social : ViewComponent
    {
        MsSqlContext _contex = new MsSqlContext();
        public IViewComponentResult Invoke()
        {
            var dataList = _contex.Socials.FirstOrDefault(x => x.Id == 1);
            return View(dataList);
        }
    }
}
