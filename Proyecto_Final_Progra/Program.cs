using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Proyecto_Final_Progra
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool continuar = true;
            Cliente cliente = new Cliente();
            Habitaciones habitaciones = new Habitaciones();
            while (continuar)
            {
                Console.WriteLine("Menu de reservaciones");
                Console.WriteLine("1. Crear reservacion");
                Console.WriteLine("2. Consultar reservaciones");
                Console.WriteLine("3. Actualizar reservacion");
                Console.WriteLine("4. Eliminar reservacion");
                Console.WriteLine("5. Salir del menu");
                Console.WriteLine("Ingresar una opcion:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida. Por favor ingrese un número válido.");
                    continue;
                }
                else
                {

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingresa tus datos");
                            cliente.agregar();
                            habitaciones.SolicitarDatos();
                            break;
                        case 2:
                            Console.WriteLine("Consultar reservaciones...");
                            cliente.consultar();
                            break;
                        case 3:
                            Console.WriteLine("Actualizar reservación...");
                            break;
                        case 4:
                            Console.WriteLine("Eliminar reservación...");
                            cliente.eliminar();
                            break;
                        case 5:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor seleccione una opción del menú.");
                            break;
                    }
                }
            }
            Console.WriteLine("Saliendo del programa...");
        }
    }
}
