using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Suite : Habitación
    {
        public int NumeroDeHabitaciones { get; set; }
        public bool TieneJacuzzi { get; set; }

        public Suite(int numero, double precioPorNoche, int numeroDeHabitaciones, bool tieneJacuzzi)
            : base(numero, precioPorNoche)
        {
            NumeroDeHabitaciones = numeroDeHabitaciones;
            TieneJacuzzi = tieneJacuzzi;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Habitaciones: {NumeroDeHabitaciones}, Tiene Jacuzzi: {(TieneJacuzzi ? "Sí" : "No")}");
        }
    }
}
