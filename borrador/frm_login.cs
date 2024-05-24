using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrador
{
   
    public partial class frm_login : Form
    {
        private string NombreUsuario;

        private bool MostrarContraseña = false;

        public frm_login()
        {
            InitializeComponent();

            btn_mostrarContra.Text = "Mostrar";
            txt_Contra.UseSystemPasswordChar = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            new frm_principal().closeLogin();
            new frm_principal().setPanelMenuEnable(true);
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=veterianria;User=root;Password=;Pooling=false;";
            string username = txt_Usuario.Text;
            string password = txt_Contra.Text;


            ValidarUsuario(username, password, connectionString);
        }

        public void AgarrarUsuario(string usuario) {
            this.NombreUsuario =usuario;
        }
        private string ObtenerNombreUsuario()
        {
            return NombreUsuario;
        }

        private void ValidarUsuario(string username, string password, string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombre_usuario AND contrasena = @contrasena";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre_usuario", username);
                    cmd.Parameters.AddWithValue("@contrasena", password);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        GuardarHoraEntrada(connection, username);
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
            
        

        private void btn_mostrarContraseña_Click(object sender, EventArgs e)
        {
            // Alterna la visibilidad de la contraseña
            if (MostrarContraseña)
            {
                // Oculta la contraseña
                txt_Contra.UseSystemPasswordChar = true;
                btn_mostrarContra.Text = "Mostrar";
            }
            else
            {
                // Muestra la contraseña
                txt_Contra.UseSystemPasswordChar = false;
                btn_mostrarContra.Text = "Ocultar";
            }

            // Cambia el estado de visibilidad
            MostrarContraseña = !MostrarContraseña;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void GuardarHoraEntrada(MySqlConnection conexion, string nombreUsuario)
        {
            string consulta = "INSERT INTO registro_entradas_salidas (usuario, fecha_entrada) VALUES (@usuario, @fecha_entrada)";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@usuario", nombreUsuario);
                comando.Parameters.AddWithValue("@fecha_entrada", DateTime.Now);
                comando.ExecuteNonQuery();
                Console.WriteLine("Hora de entrada registrada para " + nombreUsuario);
            }
        }
    }
}
