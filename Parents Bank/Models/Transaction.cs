using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parents_Bank.Models
{
    [CustomValidation(typeof(Transaction), "ValidateTransaction")]
    public class Transaction
    {
        public long Id { get; set; }
        public virtual long AccountId { get; set; }
        public virtual Account Account { get; set; }
        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        [Required]
        public string Note { get; set; }

        public static ValidationResult ValidateTransaction(Transaction transaction, ValidationContext validationContext)
        {
            if (null != transaction)
            {
                if (Math.Abs(transaction.Amount) < 0.01)
                {
                    return new ValidationResult("Transaction amount can't be 0.00");
                }
                else if (transaction.TransactionDate > DateTime.Now)
                {
                    return new ValidationResult("Transaction date cannot be in future");
                }
                else if (transaction.TransactionDate.Year < DateTime.Now.Year - 1)
                {
                    return new ValidationResult("Transaction date cannot be before current year");
                }
                return ValidationResult.Success;
            }
            return ValidationResult.Success;
        }

    }
}
