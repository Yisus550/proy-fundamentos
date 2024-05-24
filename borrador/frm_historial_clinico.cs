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

                
                    MessageBox.Show("Datos guardados correctamente.");
                    LimpiarParametros();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }

            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
                try
            {
                conn.Open();
                string query = "INSERT INTO Registro_consultas (Nombre_Mascota, Fecha_consulta, Consultas_anteriores, Motivo, " +
                        "Examen_fisico, Diagnostico, Pruebas_realizadas, Resultados, Medicamentos, Dosis, Como_Tomarlo," +
                        " Dieta_recomendada, Cuidados_especiales, Especifique, Respuesta_tratamiento, Cambios_sintomas, " +
                        "Recomendaciones) VALUES (@NombreMascota, @Fecha_consulta, @Consultas_anteriores, @Motivo, @Examen_fisico, @Diagnostico," +
                        " @Pruebas_realizadas, @Resultados, @Medicamentos, @Dosis, @Como_Tomarlo, @Dieta_recomendada, @Cuidados_especiales, " +
                        "@Especifique, @Respuesta_tratamiento, @Cambios_sintomas, @Recomendaciones)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombreMascota", txtnombreM.Text);
                command.Parameters.AddWithValue("@Fecha_consulta", fecha_consulta.Value);
                command.Parameters.AddWithValue("@Consultas_anteriores", cbx_consultas.Text);
                command.Parameters.AddWithValue("@Motivo", txt_motivoCon.Text);
                command.Parameters.AddWithValue("@Examen_fisico",txt_examenFi.Text);
                command.Parameters.AddWithValue("@Diagnostico", txt_Diagnostico.Text);
                command.Parameters.AddWithValue("@Pruebas_realizadas", cbx_PruebasRealizadas.Text);
                command.Parameters.AddWithValue("@Resultados", txt_ResultadosPuebas.Text);
                command.Parameters.AddWithValue("@Medicamentos", txt_Medicamentos.Text);
                command.Parameters.AddWithValue("@Dosis", txt_Dosis.Text);
                command.Parameters.AddWithValue("@Como_Tomarlo", txt_Tomarlo.Text);
                command.Parameters.AddWithValue("@Dieta_recomendada", txt_dietaRec.Text);
                command.Parameters.AddWithValue("@Cuidados_especiales", rbt_CEsi.Checked ? true : false);
                command.Parameters.AddWithValue("@Especifique", txt_EspecifiqueCE.Text);
                command.Parameters.AddWithValue("@Respuesta_tratamiento", txt_respuestraTR.Text);
                command.Parameters.AddWithValue("@Cambios_sintomas", txt_CambiosSin.Text);
                command.Parameters.AddWithValue("@Recomendaciones", txt_NuevasRecom.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro guardado exitosamente.");
                    Limpiar();
                    LimpiarParametros();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
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
        private void Limpiar()
        {
            fecha_consulta.Value = DateTime.Now;
            cbx_consultas.SelectedIndex = -1;
            txt_motivoCon.Clear();
            txt_examenFi.Clear();
            txt_Diagnostico.Clear();
            cbx_PruebasRealizadas.SelectedIndex = -1;
            txt_ResultadosPuebas.Clear();
            txt_Medicamentos.Clear();
            txt_Dosis.Clear();
            txt_Tomarlo.Clear();
            txt_dietaRec.Clear();
            rbt_CEsi.Checked = false;
            rbt_CEno.Checked = false;
            txt_EspecifiqueCE.Clear();
            txt_respuestraTR.Clear();
            txt_CambiosSin.Clear();
            txt_NuevasRecom.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=veterinaria;User ID=Jose;Password=perrito123;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
                try
            {
                conn.Open();
                string query = "UPDATE Registro_consultas SET Fecha_consulta=@Fecha_consulta, Consultas_anteriores=@Consultas_anteriores, Motivo=@Motivo, Examen_fisico=@Examen_fisico, Diagnostico=@Diagnostico, Pruebas_realizadas=@Pruebas_realizadas, Resultados=@Resultados, Medicamentos=@Medicamentos, Dosis=@Dosis, Como_Tomarlo=@Como_Tomarlo, Dieta_recomendada=@Dieta_recomendada, Cuidados_especiales=@Cuidados_especiales, Especifique=@Especifique, Respuesta_tratamiento=@Respuesta_tratamiento, Cambios_sintomas=@Cambios_sintomas, Recomendaciones=@Recomendaciones WHERE ID=@ID";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Fecha_consulta", fecha_consulta.Value);
                    command.Parameters.AddWithValue("@Consultas_anteriores", cbx_consultas.Text);
                    command.Parameters.AddWithValue("@Motivo", txt_motivoCon.Text);
                    command.Parameters.AddWithValue("@Examen_fisico", txt_examenFi.Text);
                    command.Parameters.AddWithValue("@Diagnostico", txt_Diagnostico.Text);
                    command.Parameters.AddWithValue("@Pruebas_realizadas", cbx_PruebasRealizadas.Text);
                    command.Parameters.AddWithValue("@Resultados", txt_ResultadosPuebas.Text);
                    command.Parameters.AddWithValue("@Medicamentos", txt_Medicamentos.Text);
                    command.Parameters.AddWithValue("@Dosis", txt_Dosis.Text);
                    command.Parameters.AddWithValue("@Como_Tomarlo", txt_Tomarlo.Text);
                    command.Parameters.AddWithValue("@Dieta_recomendada", txt_dietaRec.Text);
                    command.Parameters.AddWithValue("@Cuidados_especiales", rbt_CEsi.Checked ? true : false);
                    command.Parameters.AddWithValue("@Especifique", txt_EspecifiqueCE.Text);
                    command.Parameters.AddWithValue("@Respuesta_tratamiento", txt_respuestraTR.Text);
                    command.Parameters.AddWithValue("@Cambios_sintomas", txt_CambiosSin.Text);
                    command.Parameters.AddWithValue("@Recomendaciones", txt_NuevasRecom.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    } 




