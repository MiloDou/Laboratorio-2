using Laboratorio_2;
using System.Collections.Concurrent;
using System.Security.AccessControl;

namespace HotelVillaReal
{
    using System;
    using System.Collections.Generic;

    namespace HotelManagement
    {
        class Program
        {
            static Managment manejo = new Managment();
            static Habitación habitacion = new Habitación(0, 0);

            static void Main(string[] args)
            {
                bool salir = false;
                while (!salir)
                {
                    try
                    {
                        ShowMenu();
                        Console.Write("Elegir una opción: ");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                {
                                    bool continuar = true;
                                    while (continuar)
                                    {
                                        try
                                        {
                                            RoomMenu();
                                            Console.Write("Seleccionar tipo de habitación: ");
                                            int option1 = Convert.ToInt32(Console.ReadLine());

                                            switch (option1)
                                            {
                                                case 1:
                                                    manejo.AddSimpleRoom();
                                                    break;
                                                case 2:
                                                    manejo.AddDoubleRoom();
                                                    break;
                                                case 3:
                                                    manejo.AddSuiteRoom();
                                                    break;
                                                case 4:
                                                    manejo.AddDeluxeRoom();
                                                    break;
                                                case 5:
                                                    continuar = false;
                                                    Console.WriteLine("Presiona Enter para regresar...");
                                                    break;
                                                default:
                                                    Console.WriteLine("Opción no válida.");
                                                    break;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"Error: {ex.Message}");
                                        }
                                        Console.ReadKey();
                                    }
                                }
                                break;

                            case 2:
                                {
                                    Console.Write("Escriba el número de la habitación a eliminar: ");
                                    int numeroHabitacion = Convert.ToInt32(Console.ReadLine());
                                    EliminarHabitacion(numeroHabitacion);
                                }
                                break;

                            case 3:
                                {
                                    manejo.ShowRooms();
                                }
                                break;

                            case 4:
                                {
                                }
                                break;

                            case 5:
                                {
                                    Console.Write("Escriba el número de la habitación a liberar: ");
                                    int numeroHabitacion = Convert.ToInt32(Console.ReadLine());
                                    LiberarHabitacion(numeroHabitacion);
                                }
                                break;

                            case 6:
                                {
                                    salir = true;
                                    Console.WriteLine("Saliendo del programa...");
                                }
                                break;

                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            static void ShowMenu()
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Agregar habitación");
                Console.WriteLine("2. Eliminar habitación");
                Console.WriteLine("3. Mostrar habitaciones");
                Console.WriteLine("4. Asignar habitación a cliente");
                Console.WriteLine("5. Liberar habitación");
                Console.WriteLine("6. Salir");
            }

            static void RoomMenu()
            {
                Console.WriteLine("MENU DE HABITACION:");
                Console.WriteLine("1. Habitación Simple");
                Console.WriteLine("2. Habitación Doble");
                Console.WriteLine("3. Suite");
                Console.WriteLine("4. Habitación Deluxe");
                Console.WriteLine("5. Regresar al menú principal");
            }

            static void EliminarHabitacion(int numero)
            {

                var habitacion = manejo.HabitacionesSimples.Find(h => h.NumeroDeHabitacion == numero);
                manejo.HabitacionesDobles.Find(h => h.NumeroDeHabitacion == numero);
                manejo.HabitacionesDeluxe.Find(h => h.NumeroDeHabitacion == numero);
                                 manejo.Suites.Find(h => h.NumeroDeHabitacion == numero);

                if (habitacion != null)
                {
                    manejo.HabitacionesSimples.RemoveAll(h => h.NumeroDeHabitacion == numero);
                    manejo.HabitacionesDobles.RemoveAll(h => h.NumeroDeHabitacion == numero);
                    manejo.HabitacionesDeluxe.RemoveAll(h => h.NumeroDeHabitacion == numero);
                    manejo.Suites.RemoveAll(h => h.NumeroDeHabitacion == numero);
                    Console.WriteLine($"Habitación Número {numero} eliminada correctamente.");
                }
                else
                {
                    Console.WriteLine($"No se encontró la habitación con número {numero}.");
                }
            }

            static void LiberarHabitacion(int numero)
            {
                var habitacion = manejo.HabitacionesSimples.Find(h => h.NumeroDeHabitacion == numero);
                manejo.HabitacionesDobles.Find(h => h.NumeroDeHabitacion == numero);
                manejo.HabitacionesDeluxe.Find(h => h.NumeroDeHabitacion == numero); 
                                 manejo.Suites.Find(h => h.NumeroDeHabitacion == numero);

                if (habitacion != null && !habitacion.Disponible)
                {
                    habitacion.LiberarHabitacion();
                    Console.WriteLine($"Habitación Número {numero} liberada correctamente.");
                }
                else
                {
                    Console.WriteLine($"No se pudo liberar la habitación {numero}. Puede estar ya libre o no existir.");
                }
            }
        }
    }
}
