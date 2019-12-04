using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEXPROJECT.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int? Customer_ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int? Contact_ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int? Credential_ID { get; set; }

        [Display(Name = "Business Name")]
        public string Name { get; set; }

        [Display(Name = "Business Phone")]
        public string Phone { get; set; }

        [Display(Name = "Business Email")]
        [StringLength(40, MinimumLength = 0, ErrorMessage = "Email must be between 0-40 characters")]
        public string Email { get; set; }

        [Display(Name = "Business Address line 1")]
        public string Address1 { get; set; }

        [Display(Name = "Business Address line 2")]
        public string Address2 { get; set; }

        [Display(Name = "State/Provence")]
        public string StateOrProvence { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        [HiddenInput(DisplayValue = false)]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Discount must be between 0-500 characters")]
        public string Discount { get; set; }
    }
}