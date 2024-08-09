using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class HabitacionSimple : Habitación
    {
        public int NumeroDeCamas { get; set; }

        public HabitacionSimple(int numero, double precioPorNoche, int numeroDeCamas)
            : base(numero, precioPorNoche)
        {
            NumeroDeCamas = numeroDeCamas;
        }

        public  void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Camas: {NumeroDeCamas}");
        }

    }

}


