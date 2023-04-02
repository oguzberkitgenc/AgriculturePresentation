﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementsService _announcementsService;

        public AnnouncementController(IAnnouncementsService announcementsService)
        {
            _announcementsService = announcementsService;
        }

        public IActionResult Index()
        {
            var values = _announcementsService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement) 
        {
            announcement.Status = true;
            announcement.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            _announcementsService.Insert(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _announcementsService.GetById(id);
            _announcementsService.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var value = _announcementsService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditAnnouncement(Announcement announcement)
        {
            _announcementsService.Update(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcementsService.AnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcementsService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
