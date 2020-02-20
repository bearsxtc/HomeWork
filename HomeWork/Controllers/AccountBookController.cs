using HomeWork.Service;
using HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class AccountBookController : Controller
    {
        // GET: AccountBook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccountBookList()
        {
            var listDataViewModle = AccountBookAPI.GetData();
            return PartialView(listDataViewModle);
        }

        public ActionResult Create(AccountBookViewModel accountBookViewModel) 
        {
            new AccountBookAPI().Create(accountBookViewModel);
            return RedirectToAction("AccountBookList");
        }
    }
}