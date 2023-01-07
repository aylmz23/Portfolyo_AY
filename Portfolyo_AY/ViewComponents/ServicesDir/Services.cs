using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;

namespace Portfolyo_AY.ViewComponents.ServicesDir
{
    public class Services : ViewComponent
    {
        MsSqlContext _contex = new();
        public IViewComponentResult Invoke()
        {
            ViewBag.Content = "Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.";

            var data = _contex.Services.ToList();
            return View(data);
        }
    }
}
