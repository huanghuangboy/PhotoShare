﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace PhotoShare.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhotoShareControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}