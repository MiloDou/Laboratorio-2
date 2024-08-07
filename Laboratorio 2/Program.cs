using System.Collections.Concurrent;
using System.Security.AccessControl;

namespace HotelVillaReal
{
    class program
    {
        static void main(string[] args)
        {
            try
            {
                ShowMenu();
                Console.Write("Elegir una opcion: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            bool Continuar = true;
                            while (Continuar)
                            {
                                try
                                {
                                    RoomMenu();
                                    Console.Write("Seleccionar habitación: ");
                                    int option1 = Convert.ToInt32(Console.ReadLine());
                                    switch (option1)
                                    {
                                        case 1:
                                            {

                                            }break;
                                            case 2: 
                                                {

                                                }break;
                                        case 3:
                                            {

                                            }
                                            break;
                                        case 4:
                                            {

                                            }
                                            break;
                                        case 5:
                                            {
                                                Continuar = false;
                                                Console.WriteLine("Presiona Enter para regresar...");
                                            }
                                            break;







                                    }
                                }
                                catch
                                {

                                }
                                Console.ReadKey(); 
                            }

                        }
                        break;
                    case 2:
                        {

                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {

                        }
                        break;
                    case 5:
                        {

                        }
                        break;
                    case 6:
                        {

                        }
                        break;
                }
            }
            catch
            {

            }Console.ReadKey();
        }
        static void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Agregar habitación ");
            Console.WriteLine("2. Eliminar habitación");
            Console.WriteLine("3. Mostrar habitación");
            Console.WriteLine("4. Asignar Habitación a cliente");
            Console.WriteLine("5. Liberar habitación");
            Console.WriteLine("6. Salir");

        }
        static void RoomMenu()
        {
            Console.WriteLine("MENU DE HABITACION");
            Console.WriteLine("1. Habitacion Simple");
            Console.WriteLine("2. Habitación doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Habitacion Deluxe");
            Console.WriteLine("5. Regresar al menú");
        }
    }
}