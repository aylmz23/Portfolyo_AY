using Microsoft.AspNetCore.Mvc;

namespace Portfolyo_AY.ViewComponents.PortfolioDir
{
    public class Portfolio : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
