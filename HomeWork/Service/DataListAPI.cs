using HomeWork.Models;
using HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork.Service
{
    public class DataListAPI
    {
        private static ModelTest _modelTest = new ModelTest();

        public static List<DataViewModel> GetData()
        {
            List<DataViewModel> ListViewModel = new List<DataViewModel>();
            var accountBooks = _modelTest.AccountBooks.OrderByDescending(x => x.Dateee);

            foreach (var item in accountBooks)
            {
                ListViewModel.Add(new DataViewModel
                {
                    DateTime = item.Dateee,
                    Price = item.Amounttt,
                    Category = item.Categoryyy.ToString(),
                });
            }

            return ListViewModel;
        }
    }
}