using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
 
        capaNegocios.clasePersona obpersona = new capaNegocios.clasePersona();
        DataTable dtpersona;
        void cargarDatos()
        { 
        
            dtpersona = obpersona.traerPersonas();
            dgpersonas.DataSource = dtpersona;

            
        
        }

        private void btn_traer_datos_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        void buscarPorNombre()
        {
           
            dtpersona = obpersona.buscarPersonasPorNombre(tdato.Text);
            dgpersonas.DataSource = dtpersona;
        }
        void buscarPorInicio()
        {

            dtpersona = obpersona.buscarPersonasPorInicio(tdato.Text);
            dgpersonas.DataSource = dtpersona;
        }
        void buscarPorNombreFin()
        {

            dtpersona = obpersona.buscarPersonasPorNombreFin(tdato.Text);
            dgpersonas.DataSource = dtpersona;
        }
        void buscarPorNombreContiene()
        {

            dtpersona = obpersona.buscarPersonasPorNombreContenga(tdato.Text);
            dgpersonas.DataSource = dtpersona;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (rt.Checked)
            buscarPorNombre();

            if (ri.Checked)
                buscarPorInicio();

            if (rf.Checked)
                buscarPorNombreFin();

            if (rc.Checked)
                buscarPorNombreContiene();


        }

        private void btn_buscarAqui_Click(object sender, EventArgs e)
        {
            buscarAqui();
        }

        void buscarAqui()
        {
            int cr = dtpersona.Rows.Count;

            for (int posf = 0; posf < cr; posf++)
            {
                if ((dtpersona.Rows[posf][0].ToString() == tdato.Text) ||
                    (dtpersona.Rows[posf][1].ToString() == tdato.Text) || 
                    (dtpersona.Rows[posf][2].ToString() == tdato.Text) || 
                    (dtpersona.Rows[posf][3].ToString() == tdato.Text) )
                {
                    t0.Text = dtpersona.Rows[posf][0].ToString();
                    t1.Text = dtpersona.Rows[posf][1].ToString();
                    t2.Text = dtpersona.Rows[posf][2].ToString();
                    t3.Text = dtpersona.Rows[posf][3].ToString();
                    return;
                }
            
            }

           
        }

        void insertarDatos()
        { 
            obpersona.valores[0]= t0.Text;
            obpersona.valores[1]= t1.Text;
            obpersona.valores[2]= t2.Text;
            obpersona.valores[3]= t3.Text;
            if (obpersona.insertar() == 0)
            { 
               
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertarDatos();
        }
    }
}
