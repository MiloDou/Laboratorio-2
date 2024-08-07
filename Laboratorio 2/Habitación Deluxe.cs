using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    
    public class Habitación_Deluxe : Managment
    {

        public int NumeroDeCamas { get; set; }

        public void AddSimpleRoom()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        HABITACIÓN DELUXE");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

            Console.Write("Escribe Número de habitación");
            int numerode = Convert.ToInt32(Console.ReadLine());
            NumeroDeRoom(numerode);

            Console.Write("Escribe Precio por Noche: ");
            string precio = Console.ReadLine();
            preciopornoche(precio);

            Console.WriteLine();

           

            Console.Write("Escribe la descripción: ");
            string description = Console.ReadLine();

            Console.Write("Escriba cliente asignado: ");
            string cliente = Console.ReadLine();
            Console.WriteLine("Es");


            Habitación NuevaSimple = new Habitación();
            HabitaciónSimple.Add(NuevaSimple);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nProducto {name}, Correctamente registrado");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();

        }
    }
}
