using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrador
{
    public partial class Data_gridview : Form
    {
     
        private MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=veterinaria;User ID=Jose;Password=perrito123");
        public DataGridViewRow FilaSeleccionada { get; private set; }

        public Data_gridview()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            CargarDatosMascotas();
        }

        private void CargarDatosMascotas()
        {
            try
            {
                conexion.Open();
                string consulta = "SELECT nombre, edad, raza, fecha_nacimiento, sexo, color, esterilizado, especie FROM datosmascota";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                DataTable datos = new DataTable(); // Usar DataTable en lugar de DataSet
                adaptador.Fill(datos);
                DataMas.DataSource = datos; // Asignar DataTable como DataSource
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las mascotas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (DataMas.SelectedRows.Count > 0)
            {
                FilaSeleccionada = DataMas.SelectedRows[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una mascota antes de hacer clic en Aceptar.");
            }
        }
    

        private void Buscar_Click(object sender, EventArgs e)
        {
            CargarDatosMascotas();
        }

      /*  private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (DataMas.SelectedRows.Count > 0)
            {
                FilaSeleccionada = DataMas.SelectedRows[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una mascota antes de hacer clic en Aceptar.");
            }
        }
      */
        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            if (DataMas.SelectedRows.Count > 0)
            {
                FilaSeleccionada = DataMas.SelectedRows[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una mascota antes de hacer clic en Aceptar.");
            }
        }

        private void salirq_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
 


