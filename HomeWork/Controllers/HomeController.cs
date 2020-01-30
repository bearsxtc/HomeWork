﻿using HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DataList()
        {
            DataViewModel viewModel;
            List<DataViewModel> ListViewModel = new List<DataViewModel>();
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                int price = Convert.ToInt32(rand.Next(0, 50000));
                int typeNumber = Convert.ToInt16(rand.Next(0, 2));

                viewModel = new DataViewModel() 
                {
                    Number = i + 1,
                    Category = (typeNumber == 0) ? "支出" : "收入",
                    DateTime = DateTime.Now,
                    Price = price
                };
                ListViewModel.Add(viewModel);
            }

            return View(ListViewModel);
        }


        public ActionResult Index()
        {
            return View();
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