using Microsoft.EntityFrameworkCore;
using PersonalContactsList.Domain;
using System.Configuration;

namespace PersonalContactsList.Data
{
    public class ContactsContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Adresses { get; set; }

        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer( @"Data Source=.\sqlexpress02;Initial Catalog=CONTACTS;User ID=dev;" );
        }
    }
}
