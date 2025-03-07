namespace Prueba_Tecnica__I_D_i_d.Modelo
{
    public class Reservas
    {
	    public int IdReserva {get; set; }
	    public bool Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdCliente { get; set; }
    
        public int IdHabitacion { get; set; }
        public int IdSede { get; set; }
    }
}
