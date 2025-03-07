using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using Prueba_Tecnica__I_D_i_d.Modelo;

namespace Prueba_Tecnica__I_D_i_d.Services;



public class Calculo
    {
    private List<Habitaciones> habitaciones;
    private List<Reservas> reservas;
    private List<Temporadada> temporada;
    private List<TipoHabitacion> tipoHabitacion;

    public Calculo(List<Habitaciones> habitaciones, List<Reservas> reservas, List<Temporadada> temporada, List<TipoHabitacion> tipoHabitacion)
    {
        this.habitaciones = habitaciones;
        this.reservas = reservas;
        this.temporada = temporada;
        this.tipoHabitacion = tipoHabitacion;
    }
    public int CalcularPrecio(Reservas reserva)
        {
        var habitacionReservada = (from habitacion in habitaciones
                                   join res in reservas
                                   on habitacion.HabitacionesId equals res.IdHabitacion
                                   where res.ReservasId == reserva.ReservasId
                                   select habitacion).FirstOrDefault();

        if (habitacionReservada == null)
        {
            throw new Exception("No se encontró la habitación asociada a la reserva.");
        }
        var tarifa = (from tipo in tipoHabitacion
                  where tipo.Id == habitacionReservada.TipoHabitacion
                  select tipo).FirstOrDefault();

        if (tarifa == null)
        {
            throw new Exception("No se encontró la habitación asociada a la reserva.");
        }

        return tarifa.Tarifa;
            
        }
}
