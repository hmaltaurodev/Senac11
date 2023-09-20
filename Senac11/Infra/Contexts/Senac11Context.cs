using Microsoft.EntityFrameworkCore;
using Senac11.Domain;

namespace Senac11.Infra.Contexts
{
    public class Senac11Context : DbContext
    {
        public Senac11Context(DbContextOptions<Senac11Context> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
