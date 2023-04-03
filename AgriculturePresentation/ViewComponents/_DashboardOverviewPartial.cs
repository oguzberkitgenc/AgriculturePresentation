using DataAccesLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            DateTime dt = DateTime.Now;
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.servicesCount=c.Services.Count();
            ViewBag.messageCount=c.Contects.Count();
            ViewBag.currentMessage = c.Contects.Where(x=>x.Date.Month ==dt.Month).Count();
            
            ViewBag.annaouncementTrue=c.Announcements.Where(x=>x.Status==true).Count();
            ViewBag.annaouncementFalse=c.Announcements.Where(x=>x.Status==false).Count();

            ViewBag.urunPazarlama1 = c.Teams.Where(x => x.Title == "C#, ASP.NET Yazılım Geliştirici").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.urunPazarlama2 = c.Teams.Where(x => x.Title == "Go Yazılım Geliştiricisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.urunPazarlama3 = c.Teams.Where(x => x.Title == "Pyton Veri Bilimcisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.urunPazarlama4 = c.Teams.Where(x => x.Title == "C++ Geliştiricisi").Select(y => y.PersonName).FirstOrDefault();


            return View();
        }
    }
}
