using System;
using System.Globalization;

public class Reservas
{
	public int IdReserva {get; set; }
	public bool Estado { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public string IdCliente { get; set; }
}
