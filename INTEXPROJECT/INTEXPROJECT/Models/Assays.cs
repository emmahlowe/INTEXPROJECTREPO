using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEXPROJECT.Models
{
    [Table("Assays")]

    public class Assays
    {
        [Key]
        public int LT_Num { get; set; }

        public int Assay_Description_ID { get; set; }

        public int Sequence_Code { get; set; }

        public string Raw_Qualitative_Results { get; set; }

        public string Raw_Quantitative_Results { get; set; }

        public string Analysis_Reports { get; set; }
    }
}
