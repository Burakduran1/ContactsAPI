using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(new Contact { FullName = "Burak Can DUran", Address = "Malatya/Yeşilyurt", Email = "s_burak.duran@toyota.com.tr", Phone = 5456951088, Id = Guid.NewGuid() });
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
