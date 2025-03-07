using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica__I_D_i_d.Modelo;

namespace Prueba_Tecnica__I_D_i_d.Data
{
    public class AppDbContext : DbContext
    {
        public required DbSet<Cliente> Clientes { get; set; }
        public required DbSet<Estados> Estados { get; set; }
        public required DbSet<Habitaciones> Habitaciones { get; set; }
        public required DbSet<Reservas> Reservas { get; set; }
        public required DbSet<Sede> Sedes { get; set; }
        public required DbSet<Temporadada> Temporadas { get; set; }
        public required DbSet<TipoHabitacion> TipoHabitaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Hotel.db");
        }
    }
}
