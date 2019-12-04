using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using INTEXPROJECT.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace INTEXPROJECT.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }

        public System.Data.Entity.DbSet<INTEXPROJECT.Models.Credentials> Credentials { get; set; }
    }
}