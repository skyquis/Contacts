using Microsoft.EntityFrameworkCore;
using Contacts.Models;
using Microsoft.AspNetCore.Identity;

namespace Contacts.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) 
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
