using Microsoft.EntityFrameworkCore;
using GestionInventiarioApi_Pablo.Models;

namespace GestionInventiarioApi_Pablo.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Articulos> Articulos { get; set; }
    }
}
