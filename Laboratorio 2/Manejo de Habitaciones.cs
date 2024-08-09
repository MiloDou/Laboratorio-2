using Laboratorio_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Managment 
    {
        
        public List<HabitacionSimple> HabitacionesSimples;
        public List<HabitacionDoble> HabitacionesDobles;
        public List<HabitacionDeluxe> HabitacionesDeluxe;
        public List<Suite> Suites;

        public Managment()
        {
            HabitacionesSimples = new List<HabitacionSimple>();
            HabitacionesDobles = new List<HabitacionDoble>();
            HabitacionesDeluxe = new List<HabitacionDeluxe>();
            Suites = new List<Suite>();
        }

        public void AddSimpleRoom()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        HABITACIÓN SIMPLE");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

            Console.Write("Escribe Número de habitación: ");
            int numerode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe Precio por Noche: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba número de camas: ");
            int numeroDeCamas = Convert.ToInt32(Console.ReadLine());

            HabitacionSimple nuevaSimple = new HabitacionSimple(numerode, precio, numeroDeCamas);
            HabitacionesSimples.Add(nuevaSimple);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nHabitación Simple Número {numerode} añadida correctamente.");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
        }

        public void AddDoubleRoom()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        HABITACIÓN DOBLE");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

            Console.Write("Escribe Número de habitación: ");
            int numerode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe Precio por Noche: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("¿Tiene vista al mar? (sí/no): ");
            bool vistaAlMar = Console.ReadLine().ToLower() == "sí";

            HabitacionDoble nuevaDoble = new HabitacionDoble(numerode, precio, vistaAlMar);
            HabitacionesDobles.Add(nuevaDoble);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nHabitación Doble Número {numerode} añadida correctamente.");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
        }

        public void AddDeluxeRoom()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        HABITACIÓN DELUXE");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

            Console.Write("Escribe Número de habitación: ");
            int numerode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe Precio por Noche: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba servicios extras (e.g., Desayuno incluido, acceso al spa): ");
            string serviciosExtras = Console.ReadLine();

            HabitacionDeluxe nuevaDeluxe = new HabitacionDeluxe(numerode, precio, serviciosExtras);
            HabitacionesDeluxe.Add(nuevaDeluxe);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nHabitación Deluxe Número {numerode} añadida correctamente.");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
        }

       
        public void AddSuiteRoom()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("        SUITE");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

            Console.Write("Escribe Número de habitación: ");
            int numerode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe Precio por Noche: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número de habitaciones en la suite: ");
            int numeroDeHabitaciones = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Tiene jacuzzi? (sí/no): ");
            bool tieneJacuzzi = Console.ReadLine().ToLower() == "sí";

            Suite nuevaSuite = new Suite(numerode, precio, numeroDeHabitaciones, tieneJacuzzi);
            Suites.Add(nuevaSuite);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nSuite Número {numerode} añadida correctamente.");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
        }


        public void ShowRooms()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        HABITACIONES DISPONIBLES");
            Console.ResetColor();
            Console.WriteLine("-------------------------------\n");

            if (HabitacionesSimples.Count > 0)
            {
                Console.WriteLine("Habitaciones Simples:");
                foreach (var habitacion in HabitacionesSimples)
                {
                    habitacion.MostrarInformacion();
                    Console.WriteLine();
                }
            }

            if (HabitacionesDobles.Count > 0)
            {
                Console.WriteLine("Habitaciones Dobles:");
                foreach (var habitacion in HabitacionesDobles)
                {
                    habitacion.MostrarInformacion();
                    Console.WriteLine();
                }
            }

            if (HabitacionesDeluxe.Count > 0)
            {
                Console.WriteLine("Habitaciones Deluxe:");
                foreach (var habitacion in HabitacionesDeluxe)
                {
                    habitacion.MostrarInformacion();
                    Console.WriteLine();
                }
            }

            if (Suites.Count > 0)
            {
                Console.WriteLine("Suites:");
                foreach (var habitacion in Suites)
                {
                    habitacion.MostrarInformacion();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
        }


    }



}
  


