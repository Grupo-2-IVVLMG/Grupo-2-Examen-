using Microsoft.EntityFrameworkCore;
using ExamenParcial.Models;
using PrimerParcialProgra.Models;

namespace ExamenParcial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }
    }
}