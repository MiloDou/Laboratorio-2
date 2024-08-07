using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Habitacion_simple : Managment
    {
        Managment Manejo = new Managment();
        public List<int> NumeroDeCamas { get; set; }

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
            double precio = Convert.ToInt32(Console.ReadLine());
            preciopornoche(precio);

            Console.WriteLine("Escriba número de camas: ");
            int camas = Convert.ToInt32(Console.ReadLine());
            NumeroDeCamas(camas);

            Console.Write("Escriba cliente asignado: ");
            string cliente = Console.ReadLine();

            Console.WriteLine("Esta disponible (y/n) ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool Disponibilidad;

            Habitación NuevaSimple = new Habitación(numerode, precio, Disponibilidad  ,cliente);
            HabitaciónSimple.Add(NuevaSimple);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n Habiación asignada a: {cliente}, Correctamente registrado");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();



        }
    }
