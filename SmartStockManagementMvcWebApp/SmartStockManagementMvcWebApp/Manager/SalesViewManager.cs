using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartStockManagementMvcWebApp.Gateway;
using SmartStockManagementMvcWebApp.Models.View;

namespace SmartStockManagementMvcWebApp.Manager
{
    public class SalesViewManager
    {
        public List<SalesView> GetSalesBetweenDate(string fromDate, string toDate)
        {

            SalesViewGateway aSalesViewGateway = new SalesViewGateway();

            return aSalesViewGateway.GetSalesBetweenDate(fromDate, toDate);
        }
    }
}