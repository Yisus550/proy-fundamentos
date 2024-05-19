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
    public partial class frm_registro_mascotas : Form
    {
        private string connectionString = "Server=LPKM\\SQLEXPRESS      ;Database= prueba           ;Integrated Security=True;";
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
           
                string NombreDueño = txtnomDueño.Text;
                string ApellidoDueño = txtapellido.Text;
                string Correo = txtcorreo.Text;
                string Telefono = txtTelefono.Text;  
                string Direccion = txtdireccion.Text;

                string NombreMascota = txtnombreM.Text;
                string SexoMascota = txtsexo.Text;
                string EspecieMascota = SeleccionEspecie();
                string RazaMascota = txtraza.Text;
                string ColorMascota = txtcolor.Text;
                DateTime FechaNacimientoMascota = fecha.Value;
                bool EsterilizadoMascota = checkEsi.Checked;
                int EdadMascota ;

                if (!int.TryParse(txtedad.Text, out EdadMascota))
                {
                    MessageBox.Show("Por favor, ingrese una edad válida para la mascota.");
                    return;
                }

                // Validar entradas antes de guardar
                if (ValidarEntradas(NombreDueño, ApellidoDueño, Correo, Telefono, Direccion, NombreMascota, SexoMascota, EspecieMascota, 
                    RazaMascota, ColorMascota))
                {
                    GuardarRegistroMascotas(NombreDueño, ApellidoDueño, Correo, Telefono, Direccion, NombreMascota,SexoMascota, EspecieMascota, 
                        RazaMascota, ColorMascota,   FechaNacimientoMascota, EsterilizadoMascota, EdadMascota);
                    LimpiarParametros();
                }
            }


            private string SeleccionEspecie()
            {
                if (checkperro.Checked) return "Perro";
                if (checkgato.Checked) return "Gato";
                if (checkotro.Checked) return "Otro";
                return string.Empty;
            }

        private bool ValidarEntradas(string NombreDueño, string ApellidoDueño, string Correo, string Telefono, string Direccion, string NombreMascota,
                      string SexoMascota, string EspecieMascota, string RazaMascota, string ColorMascota)

            {
                if (string.IsNullOrWhiteSpace(NombreDueño) || string.IsNullOrWhiteSpace(ApellidoDueño) || string.IsNullOrWhiteSpace(Correo) ||
                    string.IsNullOrWhiteSpace(Telefono) || string.IsNullOrWhiteSpace(Direccion) || string.IsNullOrWhiteSpace(NombreMascota) ||
                    string.IsNullOrWhiteSpace(SexoMascota) || string.IsNullOrWhiteSpace(EspecieMascota) || string.IsNullOrWhiteSpace(RazaMascota) || 
                    string.IsNullOrWhiteSpace(ColorMascota))
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                    return false;
                }
                return true;
            }

            private void GuardarRegistroMascotas(string NombreDueño, string ApellidoDueño, string Correo, string Telefono, string Direccion,
                                         string NombreMascota, string SexoMascota, string EspecieMascota, string RazaMascota, string ColorMascota, DateTime FechaNacimientoMascota,
                                         bool EsterilizadoMascota, int EdadMascota)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Insertar dueño
                        string DueñoQuery = "INSERT INTO Dueño (NombreDueño, ApellidoDueño, Correo, Telefono, Direccion) " +
                                            "VALUES (@NombreDueño, @ApellidoDueño, @Correo, @Telefono, @Direccion);" +
                                            "SELECT SCOPE_IDENTITY();";
                        SqlCommand ownerCommand = new SqlCommand(DueñoQuery, connection);
                        ownerCommand.Parameters.AddWithValue("@NombreDueño", NombreDueño);
                        ownerCommand.Parameters.AddWithValue("@ApellidoDueño", ApellidoDueño);
                        ownerCommand.Parameters.AddWithValue("@Correo", Correo);
                        ownerCommand.Parameters.AddWithValue("@Telefono", Telefono);
                        ownerCommand.Parameters.AddWithValue("@Direccion", Direccion);

                        int IdDueño = Convert.ToInt32(ownerCommand.ExecuteScalar());

                        // Insertar mascota
                        string MascotaQuery = "INSERT INTO Mascotas (IdDueño, NombreMascota, SexoMascota, EpecieMascota, RazaMascota, ColorMascota, FechaNacimientoMascota, " +
                        "EsterilizadoMascota, EdadMascota) " +
                                          "VALUES (@IdDueño, @NombreMascota, @SexoMascota, @EpecieMascota, @RazaMascota, @ColorMascota, @FechaNacimientoMascota, @EsterilizadoMascota, " +
                                          "@EdadMascota)";
                        SqlCommand petCommand = new SqlCommand(MascotaQuery, connection);
                        petCommand.Parameters.AddWithValue("@IdDueño", IdDueño);
                        petCommand.Parameters.AddWithValue("@NombreMascota", NombreMascota);
                        petCommand.Parameters.AddWithValue("@SexoMascota", SexoMascota);
                        petCommand.Parameters.AddWithValue("@EpecieMascota", EspecieMascota);
                        petCommand.Parameters.AddWithValue("@RazaMascota", RazaMascota);
                        petCommand.Parameters.AddWithValue("@ColorMascota", ColorMascota);
                        petCommand.Parameters.AddWithValue("@FechaNacimientoMascota", FechaNacimientoMascota);
                        petCommand.Parameters.AddWithValue("@EsterilizadoMascota", EsterilizadoMascota);
                        petCommand.Parameters.AddWithValue("@EdadMascota", EdadMascota);

                        petCommand.ExecuteNonQuery();

                        MessageBox.Show("Registro guardado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex.Message);
                    }
                }
            }

            private void LimpiarParametros()
            {
                txtnomDueño.Clear();
                txtapellido.Clear();
                txtcorreo.Clear();
                txtTelefono.Clear();
                txtdireccion.Clear();

                txtnombreM.Clear();
                txtsexo.Clear();

           
                checkperro.Checked = false;
                checkgato.Checked = false;
                checkotro.Checked = false;
                txtraza.Clear();
                txtcolor.Clear();
                fecha.Value = DateTime.Now;
                checkEsi.Checked = false;
                txtedad.Clear();
            }
        }
    }


