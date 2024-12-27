using Microsoft.EntityFrameworkCore;
using TelefonRehberi.Models;

namespace TelefonRehberi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
} 