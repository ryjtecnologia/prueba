using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace capaDatos
{
    public class claseABD
    {
        private OleDbConnection conectar()
        {
            string cadena_conexion = "Provider=SQLOLEDB.1;Provider=SQLNCLI11.1;Data Source=ROLY_TEC;Integrated Security=SSPI;Initial Catalog=ventas";
            OleDbConnection conex = new OleDbConnection(cadena_conexion);
            conex.Open();
            return conex;
        }

        protected DataTable  traerDatos(string csql)
        {
            OleDbDataAdapter ada = new OleDbDataAdapter(csql, conectar());
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }
        protected int modificarDatos(string csql)
        {
           OleDbCommand comando = new OleDbCommand(csql, conectar());
           return comando.ExecuteNonQuery();
        }
    }
}
