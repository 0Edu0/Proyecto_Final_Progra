using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra
{
    public class Cliente
    {
        public string Nombre;
        public int DPI;
        public int Celular;
        public string Correo;
        public int Tarjeta;
        public string Ingreso;
        public string Salida;
        public int Acompañantes;
        private string connectionString = "server=localhost;user=root;database=proyectofinal;port=3306;password=kevin";

        public void agregar()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Nota: Ingresa la fecha de esta manera (1 de enero de 2024)");
                    Console.WriteLine("Ingresa tu numero de DPI.");
                    int DPICliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa tu nombre completo.");
                    string NombreCliente = Console.ReadLine();
                    Console.WriteLine("Ingresa tu numero de celular.");
                    int CelularCliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa tu correo electronico.");
                    string CorreoCliente = Console.ReadLine();
                    Console.WriteLine("Ingresa los digitos de tu tarjeta de debito o credito.");
                    int TarjetaCliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de tu ingreso al hotel.");
                    string IngresoCliente = Console.ReadLine();
                    Console.WriteLine("Fecha de salida.");
                    string SalidaCliente = Console.ReadLine();
                    Console.WriteLine("Ingresa el numero de acompañantes.");
                    int AcompañantesCliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Datos ingresados exitosamente.");

                    string query = "INSERT INTO cliente (DPI,Nombre,Celular,CorreoElectronico,Tarjeta,FechaIngreso,FechaSalida,Acompañantes) VALUES (´" + DPICliente + "´,´" + NombreCliente + "´,´" + CelularCliente + "´,´" + CorreoCliente + "´,´" + TarjetaCliente + "´,´" + IngresoCliente + "´,´" + SalidaCliente + "´,´" + AcompañantesCliente + "´);";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    Console.WriteLine("Registro guardado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);

            }
        }

        public void Consultar()
        {
            Console.WriteLine("Ingresa el codigo de reservacion:");
        }
    }
}
