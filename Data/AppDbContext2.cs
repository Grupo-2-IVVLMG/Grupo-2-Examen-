using Microsoft.EntityFrameworkCore;
using PrimerParcialProgra.Models;   // Para acceder a SupportTicket

namespace PrimerParcialProgra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SupportTicket> SupportTickets { get; set; }
    }
}