using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Parents_Bank.Models
{
    [CustomValidation(typeof(Account), "ValidateOwnerRecipientEmail")]
    public class Account
    {
        public long Id { get; set; }

        [EmailAddress]
        public string Owner { get; set; }

        [EmailAddress]
        public string Recipient { get; set; }

        public string Name { get; set; }
        public DateTime OpenDate { get; set; }

        [Range(0, 100)]
        public double InterestRate { get; set; }
        public double Amount { get; set; }

        public double? InterestEarned(int period)
        {
            double interest = this.Amount * period * InterestRate / 100;
            return interest;
        }

        public static ValidationResult ValidateOwnerRecipientEmail(Account account, ValidationContext validationContext)
        {
            if (null != account)
            {
                if (null != account.Owner)
                {
                    string owner = account.Owner.Trim();
                    string recepient = null;
                    if (null != account.Recipient)
                    {
                        recepient = account.Recipient.Trim();
                    }
                    if (owner.Equals(recepient))
                    {
                        return new ValidationResult("Owner and recepent email cant be same");
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                else
                {
                    return new ValidationResult("Owner email cannot be blank");
                }


            }
            else { return ValidationResult.Success; }
        }
    }
}