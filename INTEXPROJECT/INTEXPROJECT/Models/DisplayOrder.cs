using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEXPROJECT.Models
{
    public class DisplayOrder
    {
        [Key]
        public int Workorder_ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Customer_ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Status_ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime Order_Date { get; set; }

        [Display(Name = "Due Date")]
        public DateTime Due_Date { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Sequence_Code { get; set; }

        [Display(Name = "Compound Name")]
        public string Compound_ID { get; set; }

        [Display(Name = "Assay Test")]
        public int Assay_Desc_ID { get; set; }

        [Display(Name = "Compound Weight")]
        public int Client_Weight { get; set; }

    }
}
