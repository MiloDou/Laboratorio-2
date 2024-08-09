using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class HabitacionDoble : Habitación
    {

        public bool VistaAlMar { get; set; }

        public HabitacionDoble(int numero, double precioPorNoche, bool vistaAlMar)
            : base(numero, precioPorNoche)
        {
            VistaAlMar = vistaAlMar;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Vista al Mar: {(VistaAlMar ? "Sí" : "No")}");
        }
    }
}
