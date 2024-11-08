using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using BasesDiccionario.Connection;
using Oracle.ManagedDataAccess.Types;

namespace BasesDiccionario
{

    public partial class MainForm : Form
    {
        private Connect conn;
        public MainForm(Connect conexion)
        {
            InitializeComponent();
            conn = conexion;
        }

        private void btTablas_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();

            try
            {
                conn.abrirConexion();

                using (OracleCommand cmd = new OracleCommand("info_tabla", conn.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetro de salida: REF CURSOR
                    OracleParameter paramResultado = new OracleParameter("resultado", OracleDbType.RefCursor);
                    paramResultado.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)paramResultado.Value).GetDataReader();

                    // Leer los resultados del cursor
                    while (reader.Read())
                    {
                        string tableName = reader.GetString(0);
                        string columnName = reader.GetString(1);
                        string dataType = reader.GetString(2);
                        string nullable = reader.GetString(3);

                        textBoxResultados.AppendText($"|--- INFO TABLE {tableName} ---|\n");
                        textBoxResultados.AppendText($" -> COLUMN NAME: {columnName}\n");
                        textBoxResultados.AppendText($" -> DATA TYPE: {dataType}\n");
                        textBoxResultados.AppendText($" -> NULLABLE: {nullable}\n");
                        textBoxResultados.AppendText("                                                           \n");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta" + ex.Message);
            }
            finally
            {
                conn.cerrarConexion();
            }


        }

        private void btFuncionalidad_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();

            try
            {
                conn.abrirConexion();

                using (OracleCommand cmd = new OracleCommand("funcionalidad", conn.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetro de salida: REF CURSOR
                    OracleParameter paramResultado = new OracleParameter("resultado", OracleDbType.RefCursor);
                    paramResultado.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();

                    // Leer los resultados del cursor
                    using (OracleDataReader reader = ((OracleRefCursor)paramResultado.Value).GetDataReader())
                    {
                        while (reader.Read())
                        {
                            string functionName = reader.GetString(0); // Nombre de la función
                            string sourceCode = reader.GetString(1);  // Código fuente de la función

                            // Agregar los resultados al TextBox
                            textBoxResultados.AppendText($"Function Name: {functionName}\n");
                            textBoxResultados.AppendText($"Source Code: {sourceCode.Substring(0, Math.Min(sourceCode.Length, 4000))}\n");  // Mostrar hasta 4000 caracteres
                            textBoxResultados.AppendText("----------------------------------------\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta" + ex.Message);
            }
            finally
            {
                conn.cerrarConexion();
            }
        }

        private void btTrigger_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();

            try
            {
                conn.abrirConexion();

                using (OracleCommand cmd = new OracleCommand("visualizar_disparadores", conn.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetro de salida: REF CURSOR
                    OracleParameter paramResultado = new OracleParameter("resultado", OracleDbType.RefCursor);
                    paramResultado.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    // Ejecutar el procedimiento


                    // Leer los resultados del cursor
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string triggerName = reader.GetString(0);
                            string tableName = reader.GetString(1);

                            // Mostrar el resultado en un TextBox o ListBox
                            textBoxResultados.AppendText($"Trigger Name: {triggerName}, Table Name: {tableName}\n");
                            textBoxResultados.AppendText("----------------------------------------\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta" + ex.Message);
            }
            finally
            {
                conn.cerrarConexion();
            }
        }

        private void btProcedimiento_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();

            try
            {
                conn.abrirConexion();

                using (OracleCommand cmd = new OracleCommand("lista_procedimientos", conn.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetro de salida: REF CURSOR
                    OracleParameter paramResultado = new OracleParameter("resultado", OracleDbType.RefCursor);
                    paramResultado.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();

                    // Leer los resultados del cursor
                    using (OracleDataReader reader = ((OracleRefCursor)paramResultado.Value).GetDataReader())
                    {
                        while (reader.Read())
                        {
                            string procedureName = reader.GetString(0);
                            textBoxResultados.AppendText($"--> {procedureName}\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta" + ex.Message);
            }
            finally
            {
                conn.cerrarConexion();
            }
        }

        private void btVista_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();

            try
            {
                conn.abrirConexion();

                using (OracleCommand cmd = new OracleCommand("p_vistas", conn.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetro de salida: REF CURSOR
                    OracleParameter paramResultado = new OracleParameter("resultado", OracleDbType.RefCursor);
                    paramResultado.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();

                    // Leer los resultados del cursor
                    using (OracleDataReader reader = ((OracleRefCursor)paramResultado.Value).GetDataReader())
                    {
                        while (reader.Read())
                        {
                            string viewName = reader.GetString(0);  // Nombre de la vista
                            string viewQuery = reader.GetString(1); // Consulta asociada a la vista
                            textBoxResultados.AppendText($"Vista Tabla: -> {viewName}");
                            textBoxResultados.AppendText($"Query: -> {viewQuery}");
                            textBoxResultados.AppendText($"--------------------------------------");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta" + ex.Message);
            }
            finally
            {
                conn.cerrarConexion();
            }
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();

            try
            {
                conn.abrirConexion();

                using (OracleCommand cmd = new OracleCommand("visualizar_tablas_con_columnas", conn.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Parámetro de salida: REF CURSOR
                    OracleParameter paramResultado = new OracleParameter("resultado", OracleDbType.RefCursor);
                    paramResultado.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();

                    // Leer los resultados del cursor
                    using (OracleDataReader reader = ((OracleRefCursor)paramResultado.Value).GetDataReader())
                    {
                        while (reader.Read())
                        {
                            string tableName = reader.GetString(0); // Nombre de la tabla
                            textBoxResultados.AppendText($"Tabla: {tableName}\n");
                            textBoxResultados.AppendText("--------------------------------------\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta" + ex.Message);
            }
            finally
            {
                conn.cerrarConexion();
            }
        }
    }
}
