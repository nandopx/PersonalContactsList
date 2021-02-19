using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalContactsList.Data
{
    class ContactsContext : DbContext
    {
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer( ConfigurationManager.ConnectionStrings["ContactsConn"].ConnectionString );
        }
    }
}
