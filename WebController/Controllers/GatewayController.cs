﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using MyNetSensors.WebController.Code.Hubs;

/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

namespace MyNetSensors.WebController.Controllers
{
    public class GatewayController : Controller
    {
        // GET: Gateway
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Log()
        {
            return View();
        }

        public void ClearLog()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<GatewayHub>();
            context.Clients.All.clearLog();
        }

    }
}