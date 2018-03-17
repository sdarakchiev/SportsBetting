﻿using Bytes2you.Validation;
using SportsBetting.Data;
using SportsBetting.DbModels;
using SportsBetting.Models;
using SportsBetting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsBetting.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventService eventService;

        public HomeController(IEventService eventService)
        {
            Guard.WhenArgument(eventService, "eventService").IsNull().Throw();

            this.eventService = eventService;
        }

        public HomeController() : this( new EventService(new SportsBettingContext()))
        {

        }

        public ActionResult Index()
        {
            var viewModel = this.eventService
                .AllEvents()
                .Select(e => new EventViewModel()
                {
                    EventName = e.EventName,
                    OddsForFirstTeam = e.OddsForFirstTeam,
                    OddsForDraw = e.OddsForDraw,
                    OddsForSecondTeam = e.OddsForSecondTeam,
                    EventStartDate = e.EventStartDate
                })
                .ToList();
            
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}