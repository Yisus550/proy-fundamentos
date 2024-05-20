using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrador
{
    public partial class frm_login : Form
    {
        private bool MostrarContraseña = false;

        public frm_login()
        {
            InitializeComponent();
            // Establece el botón de previsualización
            btn_mostrarContra.Text = "Mostrar";
            // Asegura que la contraseña esté oculta al cargar el formulario
            txt_Contra.UseSystemPasswordChar = true;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            new frm_principal().closeLogin();
            new frm_principal().setPanelMenuEnable(true);
        }

        private void btningresar_Click_1(object sender, EventArgs e)  //"Server=LPKM\\SQLEXPRESS;" + "Database=prueba;" + "User Id=Admin;" "Password=admin123;";
        {
            string connectionString = "Server=localhost;" + "Database=veterinaria;" + "User Id=root;" +  "Password=;";

            string query = "SELECT COUNT(1) FROM usuarios WHERE Usuario=@nombre_usuario AND Contraseña=@contrasena";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", txt_Usuario.Text);
                command.Parameters.AddWithValue("@contrasena", txt_Contra.Text);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count == 1)
                {
                    this.Hide();
                    frm_principal princi = new frm_principal();
                    princi.Show();
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
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
    }
}
