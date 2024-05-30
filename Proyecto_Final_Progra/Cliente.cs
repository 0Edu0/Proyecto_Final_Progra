using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

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
        private static int ContadorClientes = 1;
        private string connectionString = "server=localhost;user=root;database=Proyecto_Final_Progra_I;port=3306;password=dangerloveV20;";
        public string idReserva { get; private set; }

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

                    /*Revisar ID Reserva para guardar en base de datos por Eduardo*/


                    string query = "INSERT INTO cliente (`DPI`, `Nombre`, `Celular`, `Correo Electronico`, `Tarjeta`, `Fecha Ingreso`, `Fecha Salida`, `Acompañantes`) VALUES ('" + DPICliente + "','" + NombreCliente + "','" + CelularCliente + "','" + CorreoCliente + "','" + TarjetaCliente + "','" + IngresoCliente + "','" + SalidaCliente + "','" + AcompañantesCliente + "');";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    Console.WriteLine("Registro guardado");

                    idReserva = Guid.NewGuid().ToString();
                    Console.WriteLine("Tu codigo de reserva es: " + idReserva);
                    string idReservaCliente = Console.ReadLine();
                    
                    Habitaciones habitaciones = new Habitaciones();
                    habitaciones.SolicitarDatos();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);

            }


        }

        /*Pendiente a revisar por Kevin */
        public void consultar()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Ingresa el DPI del cliente que deseas consultar:");
                    int dpiConsulta = Convert.ToInt32(Console.ReadLine());
                    conn.Open();
                    string query = "SELECT * FROM cliente WHERE DPI = @DPI";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DPI", dpiConsulta);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr["DPI"] + "\t" + rdr["nombre"] + "\t" + rdr["celular"] + "\t" + rdr["Correo Electronico"] + "\t" + rdr["Tarjeta"] + "t" + rdr["Fecha Ingreso"] + "\t" + rdr["Fecha Salida"] + "\t" + rdr["Acompañantes"]);

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }

        }

        public void eliminar()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Ingrese DPI de reserva a eliminar: ");
                    int DPI = Convert.ToInt32(Console.ReadLine());
                    string query = "delete from cliente where DPI = '" + DPI + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Close();
                    Console.WriteLine("El registro " + DPI + " se ha eliminado exitosamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}

