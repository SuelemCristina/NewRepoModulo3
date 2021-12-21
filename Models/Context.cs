using Microsoft.EntityFrameworkCore;

namespace AgenciaBoaViagem.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<Promocoes> Promocoes { get; set; }

        public DbSet<Contato> Contato { get; set; }


    }
}
