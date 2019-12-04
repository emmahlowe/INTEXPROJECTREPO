using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEXPROJECT.Models
{
    //[Table("WorkOrders")]
    public class WorkOrders
    {
        [Key]
        public int WorkOrder_ID { get; set; }

        public int Customer_ID { get; set; }

        public int Status_ID { get; set; }

        public int Flag_ID { get; set; }

        public int Quoted_Price { get; set; }

        public DateTime Order_Date { get; set; }

        public DateTime Due_Date { get; set; }

        public string Num_Data_Report { get; set; }

        public string Summary_Report { get; set; }

        public string Work_Log { get; set; }

        public string Invoice { get; set; }

        public int Priority_Id { get; set; }

    }
}