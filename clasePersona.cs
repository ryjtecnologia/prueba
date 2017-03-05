using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace capaNegocios
{
    public class clasePersona : capaDatos.claseABD
    {
        public DataTable traerPersonas()
        {
            string csql = "select * from persona";           
            return traerDatos(csql);        
        }
        public DataTable buscarPersonasPorNombre(string dato)
        {
            string csql = "select * from persona where nombre = 'dato'";
            csql = csql.Replace("dato", dato);
            return traerDatos(csql);
        }
        public DataTable buscarPersonasPorInicio(string dato)
        {
            string csql = "select * from persona where idpersona like 'dato%' or nombre like 'dato%' or direccion like 'dato%' or telefono like 'dato%'";
            csql = csql.Replace("dato", dato);
            return traerDatos(csql);
        }
        public DataTable buscarPersonasPorNombreFin(string dato)
        {
            string csql = "select * from persona where nombre like '%dato'";
            csql = csql.Replace("dato", dato);
            return traerDatos(csql);
        }
        public DataTable buscarPersonasPorNombreContenga(string dato)
        {
            string csql = "select * from persona where nombre like '%dato%'";
            csql = csql.Replace("dato", dato);
            return traerDatos(csql);
        }

        public string[] valores=new string[4];
        string tabla = "persona";

        public int insertar()
        {
            string csql = "Insert into #tabla# values('#valores0','#valores1','#valores2','#valores3')";
            csql = csql.Replace("#tabla#",tabla);
            csql = csql.Replace("#valores0", valores[0]);
            csql = csql.Replace("#valores1", valores[1]);
            csql = csql.Replace("#valores2", valores[2]);
            csql = csql.Replace("#valores3", valores[3]);
            return modificarDatos(csql);
        }

        




    }
}
