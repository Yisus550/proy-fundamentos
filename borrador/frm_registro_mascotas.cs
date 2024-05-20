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
    public partial class frm_registro_mascotas : Form  //"Server=LPKM\\SQLEXPRESS      ;Database= prueba    
    {
        private MySqlConnection connection;
        public frm_registro_mascotas()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=veterinaria;uid=Jose;pwd=perrito123;";
            connection = new MySqlConnection(connectionString);
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            new frm_historial_clinico().ShowDialog();
            this.Hide();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            string nombre = txtnomDueño.Text;
            string correo = txtcorreo.Text;
            string apellido = txtapellido.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtdireccion.Text;

            string nombreMascota = txtnombreM.Text;
            string sexo = txtsexo.Text;
            DateTime fechaNacimiento = fecha.Value;
            string especie = checkperro.Checked ? "Perro" : checkgato.Checked ? "Gato" : "Otros";
            bool esterilizado = checkEsi.Checked;
            string raza = txtraza.Text;
            int edad = int.Parse(txtedad.Text);
            string color = txtcolor.Text;

            int ownerId;
            InsertarOActualizarDueño(nombre, correo, apellido, telefono, direccion, out ownerId);
            InsertarMascota(ownerId, nombreMascota, sexo, fechaNacimiento, especie, esterilizado, raza, edad, color);
            LimpiarParametro();
        }
        private void InsertarOActualizarDueño(string nombre, string correo, string apellido, string telefono, string direccion, out int id_duenio)
        {
            try
            {
                connection.Open();
                string query = "SELECT id FROM datosduenios WHERE correo = @correo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@correo", correo);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    id_duenio = Convert.ToInt32(result);
                    query = "UPDATE datosduenio SET nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion WHERE id = @id";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", id_duenio);
                }
                else
                {
                    query = "INSERT INTO datosduenio (nombre, correo, apellido, telefono, direccion) VALUES (@nombre, @correo, @apellido, @telefono, @direccion)";
                    cmd = new MySqlCommand(query, connection);
                    id_duenio = (int)cmd.LastInsertedId;
                }

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        private void InsertarMascota(int ownerId, string nombreMascota, string sexo, DateTime fechaNacimiento, string especie, bool esterilizado, string raza, int edad, string color)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO datosmascota (ownerId, nombreMascota, sexo, fechaNacimiento, especie, esterilizado, raza, edad, color) " +
                               "VALUES (@ownerId, @nombreMascota, @sexo, @fechaNacimiento, @especie, @esterilizado, @raza, @edad, @color)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ownerId", ownerId);
                cmd.Parameters.AddWithValue("@nombreMascota", nombreMascota);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@especie", especie);
                cmd.Parameters.AddWithValue("@esterilizado", esterilizado);
                cmd.Parameters.AddWithValue("@raza", raza);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@color", color);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
        public void LimpiarParametro() {
            // Resetear campos
            txtnomDueño.Clear();
            txtcorreo.Clear();
            txtapellido.Clear();
            txtTelefono.Clear();
            txtdireccion.Clear();
            txtnombreM.Clear();
            txtsexo.Clear();
            fecha.Value = DateTime.Now;
            checkperro.Checked = false;
            checkgato.Checked = false;
            checkEsi.Checked = false;
            txtraza.Clear();
            txtedad.Clear();
            txtcolor.Clear();
        }

    }
}
   



        
    


