using ContatosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatosMVC.Data
{
    public class BancoContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
