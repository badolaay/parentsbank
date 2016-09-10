using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parents_Bank.Models
{
    public class Account
    {
        public long Id { get; set; }
        public string Owner { get; set; }
        public string Recipient { get; set; }
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }
        public double InterestRate { get; set; }

    }
}