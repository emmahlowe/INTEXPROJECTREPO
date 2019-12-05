using INTEXPROJECT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INTEXPROJECT.DAL
{
    public class IntexContext : DbContext
    {
        public IntexContext(): base("IntexContext")
        {

        }

        public DbSet<Customers>Customers { get; set; }
        public DbSet<WorkOrders> WOrkOrder { get; set; }
        public DbSet<Compounds> Compound { get; set; }
        public DbSet<Assays> Assay { get; set; }






    }
}