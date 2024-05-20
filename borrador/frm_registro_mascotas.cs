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
    public partial class frm_registro_mascotas : Form  //"Server=LPKM\\SQLEXPRESS      ;Database= prueba    
    {
        private string connectionString = "Server=localhost      ;Database= veterinaria           ;Integrated Security=True;"; 
        public frm_registro_mascotas()
        {
            InitializeComponent();
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            new frm_historial_clinico().ShowDialog();
            this.Hide();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
                                

            string nombreDueno = txtnomDueño.Text;
            string apellidoDueno = txtapellido.Text;
            string correoDueno = txtcorreo.Text;
            string telefonoDueno = txtTelefono.Text;
            string direccionDueno = txtdireccion.Text;

            string nombreMascota = txtnombreM.Text;
            string sexoMascota = txtsexo.Text;
            DateTime fechaNacimientoMascota = fecha.Value;
            string especieMascota = GetSelectedEspecie();
            bool esterilizadoMascota = checkEsi.Checked;
            string razaMascota = txtraza.Text;
            string edadMascota = txtedad.Text;  
            string colorMascota = txtcolor.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar si el dueño ya existe
                    int duenoID = GetDuenoID(connection, nombreDueno, apellidoDueno, correoDueno, telefonoDueno);

                    if (duenoID == 0)
                    {
                        // Insertar un nuevo dueño
                        duenoID = InsertarDueno(connection, nombreDueno, apellidoDueno, correoDueno, telefonoDueno, direccionDueno);
                    }

                    // Insertar la mascota
                    InsertarMascota(connection, duenoID, nombreMascota, sexoMascota, fechaNacimientoMascota, especieMascota, esterilizadoMascota, razaMascota, edadMascota ,colorMascota);

                    MessageBox.Show("Registro exitoso.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetDuenoID(SqlConnection connection, string nombre, string apellido, string correo, string telefono)
        {
            string query = "SELECT id_duenio FROM datosDueno WHERE nombre = @nombre AND apellido = @apellido AND correo = @correo AND telefono = @telefono";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int InsertarDueno(SqlConnection connection, string nombre, string apellido, string correo, string telefono, string direccion)
        {
            string query = "INSERT INTO datosduenio (nombre, correo, direccion,  apellido,telefono) OUTPUT INSERTED.id_duenio VALUES (@nombre, @correo, @direccion, @apellido, @telefono)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                return (int)cmd.ExecuteScalar();
            }
        }

        private void InsertarMascota(SqlConnection connection, int id_duenio, string nombre, string sexo, DateTime fechaNacimiento, string especie, bool esterilizado, string raza, string edad, string color)
        {
            string query = "INSERT INTO datosmascota (id_duenio, nombre, sexo, fecha_nacimiento, especie, esterilizado, raza, edad, color) VALUES (@id_duenio, @nombre, " +
                "@sexo, @fecha_nacimiento, @especie," +" @esterilizado, @raza,@edad, @color)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id_duenio", id_duenio);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@especie", especie);
                cmd.Parameters.AddWithValue("@esterilizado", esterilizado);
                cmd.Parameters.AddWithValue("@raza", raza);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@color", color);

                cmd.ExecuteNonQuery();
            }
        }
            private string GetSelectedEspecie()
        {
            if (checkperro.Checked) return "Perro";
            if (checkgato.Checked) return "Gato";
            if (checkotro.Checked) return "Otro";
            return "";
        }
    
            private void LimpiarCampos()
            {
                // Limpiar los campos del dueño
                txtnomDueño.Text = "";
                txtapellido.Text = "";
                txtcorreo.Text = "";
                txtTelefono.Text = "";
                txtdireccion.Text = "";

                // Limpiar los campos de la mascota
                txtnombreM.Text = "";
                txtsexo.Text = "";
                fecha.Value = DateTime.Now; // Puedes poner una fecha por defecto si lo prefieres
                checkperro.Checked = false;
                checkgato.Checked = false;
                checkotro.Checked = false;
                checkEsi.Checked = false;
                checkEno.Checked = false;
                txtraza.Text = "";
                txtcolor.Text = "";
                txtedad.Text = "";
            }
        }
   }



        
    


