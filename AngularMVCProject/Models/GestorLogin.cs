using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
//using System.Data; // Permite utilizar el data set para llenar un data view o table
//using System.Data.Sql;
using System.Data.SqlClient; //Permite utilizar las variables que se delclaran luego como sqlconnection (para poder realizar la conexion),
                             // sqlcomm(para poder hacer sentencias en SQL), entre otras. 
                             //Se deben crear las instancias SqlConnection, SqlCommand (permite realizar las instrucciones de SQL) y SqlDataReader.
//using System.Windows.Forms; // Es para poder utilizar el MessageBox.Show("mensaje") en esta clase.
namespace AngularMVCProject.Models
{
    public class GestorLogin
    {
        public bool ValidarLogin(LoginRequest ploginRequest)
        {
            //string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();
            string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=dbHomeBank;Integrated Security=True";
            // La anterior sentencia establece la ruta de la cadena de conexion para poder buscar y hacer la conexion a la BD.
            bool result = false;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open(); // Abre la conexion. Para probar la conexion se puede utulizar las sentencias Try-Catch
                // Prueba si la conexion se realizó correctamente.
                Console.WriteLine("Conectado");
                SqlCommand comm = new SqlCommand("pa_obtener_login", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@username", ploginRequest.Username));
                comm.Parameters.Add(new SqlParameter("@password", ploginRequest.Password));
                

                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    result = true;
                }

            }
            return result;

        }
    }
}