using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parents_Bank.Models
{
    public class WishListItem
    {
        public long Id { get; set; }
        public virtual long AccountId { get; set; }
        public virtual Account Account { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        public double Cost { get; set; }
        public string Link { get; set; }
        public Boolean Purchased { get; set; }
    }

}