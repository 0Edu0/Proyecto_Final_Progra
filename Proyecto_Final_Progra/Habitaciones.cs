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
        private int tipoHabitacion;
        private int costoTotal;

        public void SolicitarDatos ()
        {
            Console.WriteLine("¿Cuantas Habitaciones desea reservar?");
            cantidadHabitaciones = int.Parse(Console.ReadLine());

        }    

    }
}
