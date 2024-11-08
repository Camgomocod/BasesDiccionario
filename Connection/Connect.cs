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
        private String usuario, contraseña, host, servicio;
        private int puerto;


        public Connect()
        {
            
        }

        public Boolean Conectar(String p_user, String p_pass)
        {
            host = "localhost";
            puerto = 1521;
            servicio = "xe";

            usuario = "labbd2";
            contraseña = "labbd2";

            // Construir la cadena de conexión
            connectionString = $"User Id={usuario};Password={contraseña};Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={puerto}))(CONNECT_DATA=(SID={servicio})));";

            OracleConnection conn = new OracleConnection(connectionString);

            if (p_user.Equals(usuario) && p_pass.Equals(contraseña))
                {
                    try
                    {
                        // Abrir la conexión
                        conn.Open();
                        Console.WriteLine("Conexión exitosa con la base de datos Oracle.");

                        return true;
                        // Aquí puedes ejecutar las consultas necesarias
                    }
                    catch (OracleException ex)
                    {
                        Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                    }
               }
                

            return false;
        }
    }
}
