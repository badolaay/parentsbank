using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parents_Bank.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public Account Account { get; set; }
        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        [Required]
        public String Note { get; set; }
    }
}