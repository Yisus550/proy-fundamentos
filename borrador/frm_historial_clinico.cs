using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrador
{
    public partial class frm_historial_clinico : Form
    {
        private MySqlConnection connection;
        private string connectionString;
        public frm_historial_clinico()
        {
            InitializeComponent();
            connectionString = "server=localhost;database=tu_base_de_datos;uid=tu_usuario;pwd=tu_contraseña;";
            connection = new MySqlConnection(connectionString);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HistorialClinico_Load(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click_1(object sender, EventArgs e)
        {
           
              
        }
    }
  }

