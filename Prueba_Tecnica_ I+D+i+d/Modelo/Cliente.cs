namespace Prueba_Tecnica__I_D_i_d.Modelo
{
        public class Cliente
    {
        public required int ClienteId { get; set; }
        public required string Nombre { get; set; }
        public string? Correo { get; set; }

        public int Celular { get; set; }

    }
}

