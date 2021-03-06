﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartStockManagementMvcWebApp.Gateway;
using SmartStockManagementMvcWebApp.Models;

namespace SmartStockManagementMvcWebApp.Manager
{
    public class StockManager
    {

        StockGateway aStockGateway = new StockGateway();
        public string SaveStockIn(StockIn stockIn)
        {
            stockIn.Date = DateTime.Now.ToString("yyyy-MM-dd");

            var rowAffected = aStockGateway.SaveStockIn(stockIn);
            if (rowAffected[0] > 0 && rowAffected[1] > 0)
            {
                return "Stock In is successfull";
            }
            return "stockIn in failed";
        }

        //public string SaveStockOut(StockOut stockOut)
        //{
        //    var rowAffected = aStockGateway.SaveStockOut(stockOut);
        //    if (rowAffected )
        //    {

        //    }
        //}

        /*public List<SalesView> GetStockInformation()
        {
            List<SalesView> stockSummaries = aStockGateway.GetStockInformation();
            return stockSummaries;
        }*/

        public string StockOut_SaveAll(List<StockOut> stockOutList)
        {
            foreach (var stock in stockOutList)
            {
                stock.Date = DateTime.Now.ToString("yyyy-MM-dd");
            }

            int rowAffected = aStockGateway.StockOut_SaveAll(stockOutList);

            if (rowAffected > 0)
            {
                return "Saved";
            }
            else
            {
                return "Failed";
            }

        }
    }
}