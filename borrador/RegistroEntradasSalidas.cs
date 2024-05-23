using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace borrador
{
    public class RegistroEntradasSalidas
    {
        public static void GuardarHoraEntrada(MySqlConnection conexion, string nombreUsuario)
        {
            string consulta = "INSERT INTO registro_entrada_salidas (usuario, hora_entrada) VALUES (@nombreUsuario, @horaEntrada)";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@usuario", nombreUsuario);
                comando.Parameters.AddWithValue("@horaEntrada", DateTime.Now);
                comando.ExecuteNonQuery();
                Console.WriteLine("Hora de entrada registrada para " + nombreUsuario);
            }
        }
    }

    
}
