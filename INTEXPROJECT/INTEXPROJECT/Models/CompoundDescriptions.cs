using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEXPROJECT.Models
{
    public class CompoundDescriptions
    {
        [Key]
        public int Compound_ID { get; set; }

        public string Name { get; set; }
    }
}