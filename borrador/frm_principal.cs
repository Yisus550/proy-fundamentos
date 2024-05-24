using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrador
{
    public partial class frm_principal : Form
    {
        Boolean loginSucces = false;
        private string NombreUsuario = "Jose";

        public frm_principal()
        {
            InitializeComponent();
            openChildForm(new frm_login());

           
        }

        public void closeLogin()
        {
            panelChildForm.Controls.Clear();
        }
 
        public void setPanelMenuEnable(Boolean value)
        {
            panelMenu.Enabled = value;
        }

        public static Form MainForm { get; set; }

        private static Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void setVisibleSubmenu(Panel panel)
        {
            if (!panel.Visible)
            {
                panel.Visible = true;
            } else
            {
                panel.Visible = false;
            }
        }

        private void btnRegistroMascotas_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_registro_citas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelMenu2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelMenu2.Visible = false;
        }

        private void btnRegistroCitas_Click(object sender, EventArgs e)
        {
            setVisibleSubmenu(submenuCitas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_registro_mascotas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_historial_clinico());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e, string nombreUsuario)
        {
            
          
        }
        private void IniciarSesion(string nombre_usuario)
        {
            this.NombreUsuario = nombre_usuario;
        }

        // Método para obtener el nombre de usuario desde la configuración de la aplicación
        private string ObtenerNombreUsuario()
        {
            return NombreUsuario;
        }


        private void btn_CerrarS_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=veterinaria;uid=Jose;password=perrito123";
           

            

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                // Actualizar la hora de salida del usuario en la base de datos
                ActualizarHoraSalida(conexion, NombreUsuario);
                // Realizar otras acciones antes de cerrar la sesión

                MessageBox.Show("Cerrando Sesion");
                frm_login log = new frm_login();
                openChildForm(new frm_login()) ;
            }
        }

        private void ActualizarHoraSalida(MySqlConnection conexion, string nombreUsuario)
        {
            string consulta = "UPDATE registro_entradas_salidas SET fecha_salida = @fecha_salida WHERE usuario = @usuario";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@usuario", nombreUsuario);
                comando.Parameters.AddWithValue("@fecha_salida", DateTime.Now);
                comando.ExecuteNonQuery();
                Console.WriteLine("Hora de salida registrada para " + nombreUsuario);
              
            }
        }
    }
 }

