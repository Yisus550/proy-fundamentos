using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string connectionString = "Server=LPKM\\SQLEXPRESS      ;Database= prueba           ;Integrated Security=True;";
        public frm_registro_citas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Parametros a ingresar
            string doctor = cbx_medico.Text;
            string mascota = txtnombreM.Text;
            string especie = SeleccionarEspecie();
            string raza = txtraza.Text;
            string propietario = txt_propietario.Text;
            string telefono = txt_telefono.Text;
            DateTime fecha = dateTime_fecha.Value;
            TimeSpan hora = dateTime_hora.Value.TimeOfDay;
            string sintomas = txt_sintomas.Text;

            // Validar entradas antes de guardar
            if (ValidarEntradas(doctor, mascota, especie, propietario, telefono, sintomas))
            {
                EnviarCita(doctor, mascota, especie, raza, propietario, telefono, fecha, hora, sintomas);
                LimpiarParametros();
            }
        }
            private string SeleccionarEspecie()    //Metodo para el radiobutton
        {
            if (rbt_perro.Checked) return "Perro";
                if (rbt_gato.Checked) return "Gato";
                if (rbt_otro.Checked) return "Otro";
                return string.Empty;
            }


        
            private bool ValidarEntradas(string doctor, string mascota, string especie, string propietario, string telefono, string sintomas)
            {
                if (string.IsNullOrWhiteSpace(doctor) || string.IsNullOrWhiteSpace(mascota) || string.IsNullOrWhiteSpace(especie) ||   //No dejar campos vacios 
                    string.IsNullOrWhiteSpace(propietario) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(sintomas))
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return false;
                }
                return true;
            }


            private void EnviarCita(string doctor, string mascota, string especie, string raza, string propietario, string telefono, DateTime fecha, TimeSpan hora, string sintomas)
            {
            //Aqui se pone el nombre de la tabla que se creo en la base de datos
                string query = "INSERT INTO RegistroCitas (Doctor, mascota, especie, raza, propietario, telefono, fecha, hora, sintomas) " +
                               "VALUES (@Doctor,@mascota, @especie, @raza, @propietario, @telefono, @fecha, @hora, @sintomas)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                    //Agregando parametros
                        command.Parameters.AddWithValue("@Doctor", doctor);
                        command.Parameters.AddWithValue("@mascota", mascota);
                        command.Parameters.AddWithValue("@especie", especie);
                        command.Parameters.AddWithValue("@raza", raza);
                        command.Parameters.AddWithValue("@propietario", propietario);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@hora", hora);
                        command.Parameters.AddWithValue("@sintomas", sintomas);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Cita guardada exitosamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error: " + ex.Message);
                        }
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
                txtraza.Clear();
                txt_propietario.Clear();
                txt_telefono.Clear();
                dateTime_fecha.Value = DateTime.Now;
                dateTime_hora.Value = DateTime.Now;
                txt_sintomas.Clear();
            }
        }
    }


    

