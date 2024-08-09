using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_2
{
    public class Habitación
    {

        public int NumeroDeHabitacion { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitación(int NumeroDeRoom, double precioPorNoche)
        {
            NumeroDeHabitacion = NumeroDeRoom;
            PrecioPorNoche = precioPorNoche;
            Disponible = true;
            ClienteAsignado = null;


        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Número de Habitación: {NumeroDeHabitacion}, Precio por Noche: {PrecioPorNoche:C}, Disponible: {Disponible}, Cliente: {ClienteAsignado}");
        }

        public void CambiarDisponibilidad(bool disponible)
        {
            Disponible = disponible;
        }

        public void AsignarCliente(string nombreCliente)
        {
            if (Disponible)
            {
                ClienteAsignado = nombreCliente;
                CambiarDisponibilidad(false);
            }
            else
            {
                Console.WriteLine("La habitación no está disponible.");
            }
        }

        public void LiberarHabitacion()
        {
            ClienteAsignado = string.Empty;
            CambiarDisponibilidad(true);
        }
    }
}

