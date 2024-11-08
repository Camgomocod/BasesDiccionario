using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BasesDiccionario.Connection
{
    public class Connect
    {
        private string connectionString;
        private string usuario = "labbd2";
        private string contraseña = "labbd2";
        private string host = "localhost";
        private int puerto = 1521;
        private string servicio = "xe";
        public OracleConnection oracleConnection;


        public Connect()
        {
            // Construir la cadena de conexión una vez
            connectionString = $"User Id={usuario};Password={contraseña};Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={puerto}))(CONNECT_DATA=(SID={servicio})));";
            oracleConnection = new OracleConnection(connectionString);
        }


        public bool validarConexion(string p_user, string p_pass)
        {
            if (p_user.Equals(usuario) && p_pass.Equals(contraseña))
            {
                try
                {
                    oracleConnection.Open();
                    Console.WriteLine("Conexión exitosa con la base de datos Oracle.");
                    return true;
                }
                catch (OracleException ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
            return false;
        }

        public void abrirConexion()
        {
            if (oracleConnection.State != System.Data.ConnectionState.Open)
            {
                oracleConnection.Open();
            }
        }

        // Método para cerrar la conexión
        public void cerrarConexion()
        {
            if (oracleConnection.State != System.Data.ConnectionState.Closed)
            {
                oracleConnection.Close();
            }
        }

        public OracleConnection GetConnection()
        {
            return oracleConnection;
        }


    }
}
