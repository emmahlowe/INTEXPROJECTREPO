using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEXPROJECT.Models
{
    [Table("Compounds")]
    public class Compounds
    {
        [Key]
        public int Sequence_Code { get; set; }

        public int Compound_ID { get; set; }

        public int Work_Order_ID { get; set; }

        public int Quantity { get; set; }

        public DateTime Date_Arrived { get; set; }

        public int Received_By { get; set; }

        public DateTime Due_Date { get; set; }

        public string Appearance { get; set; }

        public decimal Client_Weight { get; set; }

        public decimal Lab_Weight { get; set; }

        public decimal Molecular_Mass { get; set; }

        public decimal MTD { get; set; }
    }
}
