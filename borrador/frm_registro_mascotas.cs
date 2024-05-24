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
            string connectionString = "Server=localhost;Database=veterinaria;User ID=Jose;Password=perrito123;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verificar si el dueño ya existe
                    string selectDuenioQuery = @"SELECT id_duenio FROM datosduenio 
                                                 WHERE nombre = @nombre AND apellido = @apellido AND correo = @correo LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(selectDuenioQuery, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtnomDueño.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtapellido.Text);
                    cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);

                    object result = cmd.ExecuteScalar();
                    long duenioId;

                    if (result != null)
                    {
                        // Si el dueño ya existe, obtener su id
                        duenioId = Convert.ToInt64(result);
                    }
                    else
                    {
                        // Si el dueño no existe, insertarlo y obtener su id
                        string insertDuenioQuery = @"INSERT INTO datosduenio (nombre, apellido, correo, direccion, telefono) 
                                                     VALUES (@nombre, @apellido, @correo, @direccion, @telefono)";

                        cmd = new MySqlCommand(insertDuenioQuery, conn);
                        cmd.Parameters.AddWithValue("@nombre", txtnomDueño.Text);
                        cmd.Parameters.AddWithValue("@apellido", txtapellido.Text);
                        cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                        cmd.ExecuteNonQuery();
                        duenioId = cmd.LastInsertedId;
                    }

                    // Determinar especie
                    string especie = "";
                    if (checkperro.Checked) especie = "Perro";
                    else if (checkgato.Checked) especie = "Gato";
                    else if (checkotro.Checked) especie = "Otros";

                    // Determinar esterilizado
                    bool esterilizado = checkEsi.Checked;

                    // Inserción de la mascota para el dueño
                    string insertMascotaQuery = @"INSERT INTO datosmascota (id_duenio, nombre, sexo, fecha_nacimiento, especie, esterilizado, raza, edad, color) 
                                                  VALUES (@id_duenio, @nombre, @sexo, @fecha_nacimiento, @especie, @esterilizado, @raza, @edad, @color)";

                    cmd = new MySqlCommand(insertMascotaQuery, conn);
                    cmd.Parameters.AddWithValue("@id_duenio", duenioId);
                    cmd.Parameters.AddWithValue("@nombre", txtnombreM.Text);
                    cmd.Parameters.AddWithValue("@sexo", txtsexo.Text);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", DateTime.Parse(fecha.Text));
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@esterilizado", esterilizado);
                    cmd.Parameters.AddWithValue("@raza", txtraza.Text);
                    cmd.Parameters.AddWithValue("@edad", int.Parse(txtedad.Text));
                    cmd.Parameters.AddWithValue("@color", txtcolor.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datos insertados correctamente.");

                    // Limpiar los campos después de la inserción
                    LimpiarParametros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }
    
         public void LimpiarParametros() {
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
   



        
    


