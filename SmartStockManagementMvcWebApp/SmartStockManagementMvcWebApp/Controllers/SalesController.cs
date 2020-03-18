using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartStockManagementMvcWebApp.Manager;
using SmartStockManagementMvcWebApp.Models.View;

namespace SmartStockManagementMvcWebApp.Controllers
{
    public class SalesController : Controller
    {
        //
        // GET: /Seles/

        SalesViewManager aSalesViewManager = new SalesViewManager();
        public ActionResult SalesView()
        {
            return View();
        }

        public JsonResult GetSalesBetweenDate(string fromDate, string toDate)
        {
            List<SalesView> aSalesViews = aSalesViewManager.GetSalesBetweenDate(fromDate, toDate);
            return Json(aSalesViews);
        }
    }
}