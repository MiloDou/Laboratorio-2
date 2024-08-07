using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Habitación
    {

        public int NumeroDeHabitacion { get; set; }
        public int nombre { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitación(int NumeroDeRoom, int nombre, double precioPorNoche, bool disponible, string clienteAsignado)
        {
            NumeroDeHabitacion = NumeroDeRoom;
            this.nombre = nombre;
            PrecioPorNoche = precioPorNoche;
            this.disponible = disponible;
            ClienteAsignado = clienteAsignado;


        }
    }
}
