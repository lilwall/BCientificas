using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCientificas.Controllers
{
    public class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=localhost;Initial Catalog=ServiciosWeb;Integrated Security=True");
                cn.Open();
                Console.WriteLine("Conectado"); // Cambiar por alertas en aspx
                


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error a la hora de conectar" + ex.ToString()); // Cambiar por alertas en aspx
            }
        }
    



    }
}