using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Form1 f1;
        bool bf1=false;
        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bf1==false || f1.IsDisposed)
            {
                f1= new Form1();
                bf1=true;
                f1.MdiParent = this;
                f1.Show();
               
            }
        }

        private void mASCOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tIPOSDEENFERMEDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
