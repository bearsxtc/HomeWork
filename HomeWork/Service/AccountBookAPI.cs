using HomeWork.Models;
using HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork.Service
{
    public class AccountBookAPI
    {
        private static ModelTest _modelTest = new ModelTest();

        public static List<AccountBookViewModel> GetData()
        {
            List<AccountBookViewModel> ListViewModel = new List<AccountBookViewModel>();
            var accountBooks = _modelTest.AccountBooks.OrderByDescending(x => x.Dateee);

            foreach (var item in accountBooks)
            {
                ListViewModel.Add(new AccountBookViewModel
                {
                    ID = item.Id,
                    DateTime = item.Dateee,
                    Price = item.Amounttt,
                    Category = item.Categoryyy.ToString(),
                    Remark = item.Remarkkk
                }); ;
            }

            return ListViewModel;
        }

        public void Create(AccountBookViewModel accountBookViewModel)
        {
        }
    }
}