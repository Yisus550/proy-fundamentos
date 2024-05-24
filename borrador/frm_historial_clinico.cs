using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace borrador
{
    public partial class frm_historial_clinico : Form
    {
        private DataGridView claseDataGridView;


        public frm_historial_clinico()
        {
            InitializeComponent();
         
            
        }

        private void btnenviar_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=veterinaria;User ID=Jose;Password=perrito123;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))

            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Historial_Medico (Nombre_Mascota, Tipo_Vacuna, Fecha_AplicacionV, Descripcion_Traumas, " +
                        "Fecha_Accidente, Recibio_Tratamiento, EspecifiqueT, " +
                        "Tipo_Desparasitante, Fecha_AplicacionD, Algun_Medicamento, EspecifiqueM, Alergias, EspecifiqueA, Alguna_Cirugia, " +
                        "Fecha_Cirugia, EspecifiqueCirugia, Cirujano) VALUES (@NombreMascota," +
                        " @TipoVacuna, @FechaAplicacionV, @DescripcionTraumas, @FechaAccidente, @RecibioTratamiento, @EspecifiqueT, " +
                        "@TipoDesparasitante, @FechaAplicacionD, @AlgunMedicamento, @EspecifiqueM, @Alergias, @EspecifiqueA, @AlgunaCirugia, " +
                        "@FechaCirugia, @EspecifiqueCirugia, @Cirujano)";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    //Enviar parametros
                    command.Parameters.AddWithValue("@nombreMascota", txtnombreM.Text);
                    command.Parameters.AddWithValue("@TipoVacuna", txt_vacuna.Text);
                    command.Parameters.AddWithValue("@FechaAplicacionV", fechaAplicacion.Value);
                    command.Parameters.AddWithValue("@DescripcionTraumas", txt_descripcion.Text);
                    command.Parameters.AddWithValue("@FechaAccidente", fecha_accidente.Value);
                    command.Parameters.AddWithValue("@RecibioTratamiento", rbt_si.Checked ? "si" : "no");
                    command.Parameters.AddWithValue("@EspecifiqueT", txt_especifique.Text);
                    command.Parameters.AddWithValue("@TipoDesparasitante", txt_tipoDesparasitante.Text);
                    command.Parameters.AddWithValue("@FechaAplicacionD", fecha_aplicacion.Value);
                    command.Parameters.AddWithValue("@AlgunMedicamento", rbt_siMe.Checked ? "si" : "no");
                    command.Parameters.AddWithValue("@EspecifiqueM", txt_especifiqueM.Text);
                    command.Parameters.AddWithValue("@Alergias", rbt_siAl.Checked ? "si" : "no");
                    command.Parameters.AddWithValue("@EspecifiqueA", txt_especifiqueAle.Text);
                    command.Parameters.AddWithValue("@AlgunaCirugia", rbt_siCir.Checked ? "si" : "no");
                    command.Parameters.AddWithValue("@FechaCirugia", fecha_cirugia.Value);
                    command.Parameters.AddWithValue("@EspecifiqueCirugia", txt_especifiqueCir.Text);
                    command.Parameters.AddWithValue("@Cirujano", txt_cirujano.Text);
                    command.ExecuteNonQuery();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente.");
                    LimpiarParametros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }

            }
        }

        public void LimpiarParametros()
        {
            // Resetear campos
            txt_vacuna.Clear();
           fechaAplicacion.Value= DateTime.Now;
           txt_descripcion.Clear();
           fecha_accidente.Value= DateTime.Now;
            rbt_si.Checked=false;
           txt_especifique.Clear();
           txt_tipoDesparasitante.Clear();
           fecha_aplicacion.Value=DateTime.Now;
           rbt_siMe.Checked=false;
           txt_especifiqueM.Clear();
             rbt_siAl.Checked=false;
             txt_especifiqueAle.Clear();
          rbt_siCir.Checked =false;
            fecha_cirugia.Value = DateTime.Now;
            txt_especifiqueCir.Clear();
           txt_cirujano.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que contiene el DataGridView
            Data_gridview formularioMascotas = new Data_gridview();

            // Mostrar el formulario como un cuadro de diálogo modal
            if (formularioMascotas.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow filaSeleccionada = formularioMascotas.FilaSeleccionada;

                if (filaSeleccionada != null)
                {
                    // Obtener los datos de la mascota seleccionada
                    string nombreMascota = Convert.ToString(filaSeleccionada.Cells["nombre"].Value);
                    int edadMascota = Convert.ToInt32(filaSeleccionada.Cells["edad"].Value);
                    string razaMascota = Convert.ToString(filaSeleccionada.Cells["raza"].Value);
                    DateTime nacimiento = Convert.ToDateTime(filaSeleccionada.Cells["fecha_nacimiento"].Value);
                    string sexoMascota = Convert.ToString(filaSeleccionada.Cells["sexo"].Value);
                    string colorMascota = Convert.ToString(filaSeleccionada.Cells["color"].Value);
                    string esterilizado = Convert.ToString(filaSeleccionada.Cells["esterilizado"].Value);
                    string especie = Convert.ToString(filaSeleccionada.Cells["especie"].Value);


                    // Asignar los valores a los controles del formulario principal
                    if (esterilizado == "Si")
                    {
                        checkEsi.Checked = true;
                        checkEno.Checked = false;
                    }
                    else if (esterilizado == "No")
                    {
                        checkEsi.Checked = false;
                        checkEno.Checked = true;
                    }
                    if (especie == "Perro")
                    {
                        rbt_perro.Checked = true;
                    }
                    else if (especie == "Gato")
                    {
                        rbt_gato.Checked=true;
                        
                    }
                    else if (especie == "Otro") 
                    {
                        rbt_otro.Checked = true;
                    }
                    txtnombreM.Text = nombreMascota;
                    txtedad.Text = edadMascota.ToString();
                    txtraza.Text = razaMascota;
                    txt_nacimiento.Text = nacimiento.ToString("yyyy-MM-dd");
                    txtsexo.Text= sexoMascota;
                    txtcolor.Text = colorMascota;
                   
                  
                  
            }

            }
        }

        }
    } 




