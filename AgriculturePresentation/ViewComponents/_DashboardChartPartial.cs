using DataAccesLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardChartPartial : ViewComponent
    {
        AgricultureContext context = new AgricultureContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 27;
            ViewBag.v2 = 70;
            ViewBag.v3 = 1;
            ViewBag.v3 = 2;
            return View();
        }
    }
}
