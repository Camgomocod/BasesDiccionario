using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasesDiccionario.Connection;
using System.Data.OracleClient;

namespace BasesDiccionario
{

    public partial class LoginForm : Form
    {
        Connect conn = new Connect();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonConectar_Click(object sender, EventArgs e)
        {
            

            if (conn.validarConexion(txtUser.Text, txtPassword.Text) == true)
            {
                //MessageBox.Show("hola");
                conn.abrirConexion();
                MainForm form2 = new MainForm(conn);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Error al conectar a la Base de Datos");
            }


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
