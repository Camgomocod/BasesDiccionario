using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BasesDiccionario.Connection
{
    class Connect
    {
        private string connectionString;

        public Connect(string usuario, string contraseña, string host, int puerto, string servicio)
        {
            // Construir la cadena de conexión
            connectionString = $"User Id={usuario};Password={contraseña};Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={puerto}))(CONNECT_DATA=(SERVICE_NAME={servicio})));";
        }

        public void Conectar()
        {
            // Crear la conexión
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();
                    Console.WriteLine("Conexión exitosa con la base de datos Oracle.");

                    // Aquí puedes ejecutar las consultas necesarias
                }
                catch (OracleException ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
    }
}
