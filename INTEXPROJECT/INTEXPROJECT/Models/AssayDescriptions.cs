using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INTEXPROJECT.Models
{
    public class AssayDescriptions
    {
        public int Assay_Description_ID { get; set; }
        public int Price_ID { get; set; }
        public int Type_ID { get; set; }
        public string Description { get; set; }
        public string Protocol { get; set; }
        public int Completion_Time { get; set; }
        public string Literature_References { get; set; }
    }
}