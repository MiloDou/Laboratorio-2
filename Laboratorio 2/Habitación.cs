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
        public double PrecioPorNoche { get; set; }
        public bool disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitación(int NumeroDeRoom, double precioPorNoche, bool disponible, string clienteAsignado)
        {
            NumeroDeHabitacion = NumeroDeRoom;
            PrecioPorNoche = precioPorNoche;
            this.disponible = disponible;
            ClienteAsignado = clienteAsignado;


        }
    }
}
