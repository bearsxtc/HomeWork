using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork.ViewModels
{
    public class AccountBookViewModel
    {
        public Guid ID { get; set; }
        public string Category { get; set; }
        public DateTime DateTime { get; set; }
        public int Price { get; set; }
        public string Remark { get; set; }
    }
}