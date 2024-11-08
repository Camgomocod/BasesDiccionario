using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using BasesDiccionario.Connection;

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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResultados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
