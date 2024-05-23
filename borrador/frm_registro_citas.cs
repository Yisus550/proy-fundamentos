using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace borrador
{
    public partial class frm_registro_citas : Form
    {

        //Aqui se llenan los parametros con la base de datos que creamos

        public frm_registro_citas()
        {
            InitializeComponent();
            IniciarHoraComboBox();
        }

        private void IniciarHoraComboBox()
        {
            for (int hora = 0; hora < 24; hora++)
            {
                for (int minuto = 0; minuto < 60; minuto += 30) // intervalos de 30 minutos
                {
                    cbx_Hora.Items.Add($"{hora:D2}:{minuto:D2}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=veterinaria;User Id=Jose;Password=perrito123;"; 

            string especie = rbt_perro.Checked ? "Perro" :
                             rbt_gato.Checked ? "Gato" :
                             rbt_otro.Checked ? txt_otro.Text : "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO citas (Medico, nombre_mascota, especie, raza, propietario, telefono, fecha, hora, sintomas) VALUES (@Medico, @nombre_mascota, @especie, @raza, @propietario, @telefono, @fecha, @hora, @sintomas)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        //Enviar parametros
                        command.Parameters.AddWithValue("@Medico", cbx_medico.Text);
                        command.Parameters.AddWithValue("@nombre_mascota", txtnombreM.Text);
                        command.Parameters.AddWithValue("@especie", especie);
                        command.Parameters.AddWithValue("@raza", txtraza.Text);
                        command.Parameters.AddWithValue("@propietario", txt_propietario.Text);
                        command.Parameters.AddWithValue("@telefono", txt_telefono.Text);
                        command.Parameters.AddWithValue("@fecha", dateTime_fecha.Value.Date);
                        command.Parameters.AddWithValue("@hora", cbx_Hora.Text);
                        command.Parameters.AddWithValue("@sintomas", txt_sintomas.Text);

                        command.ExecuteNonQuery();

                        // Limpiar los campos después de enviar
                        LimpiarParametros();

                    }
                        MessageBox.Show("Cita registrada exitosamente.");
                }catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar cita: " + ex.Message);
                }
            }
        }
            private void LimpiarParametros()   //Limpiar campos despues de mandar cita
            {
                cbx_medico.SelectedIndex = -1;
                txtnombreM.Clear();
                rbt_perro.Checked = false;
                rbt_gato.Checked = false;
                rbt_otro.Checked = false;
                txt_otro.Clear();
                txtraza.Clear();
                txt_propietario.Clear();
                txt_telefono.Clear();
                dateTime_fecha.Value = DateTime.Now;
                cbx_Hora.SelectedIndex = -1;
                txt_sintomas.Clear();
            }
        
    }
}

    

