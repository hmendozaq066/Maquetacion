using Microsoft.EntityFrameworkCore;

namespace Maquetacion.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> op) : base(op) { }

        public DbSet<Imagen> imagenes { get; set; }

    }
}
