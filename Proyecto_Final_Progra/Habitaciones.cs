using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra
{
    
    public class Habitaciones
    {
        private int cantidadHabitaciones;
        private string [] tipoHabitacion;
        private int costoTotal;

        public void SolicitarDatos ()
        {
            Console.WriteLine("¿Cuantas Habitaciones desea reservar?");
            cantidadHabitaciones = int.Parse(Console.ReadLine());
            tipoHabitacion = new string[cantidadHabitaciones];

            for (int i = 0; i < cantidadHabitaciones; i++)
            {

                Console.WriteLine($"¿Que tipo desea reservar para la habitacion {i + 1}?");
                Console.WriteLine("1. Habitacion Sencilla - Q 200.00");
                Console.WriteLine("2. Habitacion Normal - Q 300.00");
                Console.WriteLine("3. Habitacion Doble - Q 500.00");
                Console.WriteLine("4. Habitacion Suite - Q 800.00");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        tipoHabitacion[i] = "Sencilla";
                        costoTotal += 200;
                        break;
                    case 2:
                        tipoHabitacion[i] = "Normal";
                        costoTotal += 300;
                        break;
                    case 3:
                        tipoHabitacion[i] = "Doble";
                        costoTotal += 500;
                        break;
                    case 4:
                        tipoHabitacion[i] = "Suite";
                        costoTotal += 800;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        i--;
                        break;
                
                }

            }
            MostrarResumen();
        }    
        public void MostrarResumen()
        {
            Console.WriteLine($"Ha reservado {cantidadHabitaciones} habitaciones de los siguentes tipos:");
            for (int i = 0; i < cantidadHabitaciones; ++i)
            {
                Console.WriteLine($"Habitacion {i + 1}: {tipoHabitacion[i]}");
            }
            { 
                Console.WriteLine($"Costo total     {costoTotal}");
            }

        }
    }
}
    