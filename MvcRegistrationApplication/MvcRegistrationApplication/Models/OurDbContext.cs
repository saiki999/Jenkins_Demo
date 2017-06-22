using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;  // to access data from entity framework context 

namespace MvcRegistrationApplication.Models
{
    public class OurDbContext: DbContext // inherit DbContext Class
    {
        public DbSet<UserAccount> userAccounts { get; set; }
    }
}