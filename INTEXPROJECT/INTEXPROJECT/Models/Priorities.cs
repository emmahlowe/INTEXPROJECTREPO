using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEXPROJECT.Models
{
        [Table("Priorities")]
    public class Priorities
    {
        public int Priority_ID { get; set; }

        public string Description { get; set; }
    }
}